using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSEP
{
    public partial class CreateUserForm : Form
    {
        private bool newAdmin = false;
        private static int userNum;
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void CreateUserForm_Load(object sender, EventArgs e)
        {
            if (this.Owner is LoginForm)
            {
                returnButton.Enabled = false;
                newAdmin = true;
                changeProductsCheckBox.Checked = createUserCheckBox.Checked = transactionCheckBox.Checked =
                passwordCheckBox.Checked = employeeViewCheckBox.Checked = transactionViewCheckBox.Checked = true;
                permsGroupBox.Enabled = false;
                depTextBox.Text = "Owner";
                depTextBox.Enabled = false;
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (fNameTextBox.Text != "" && lNameTextBox.Text != "" && depTextBox.Text != "")
            {
                var dbEntities = new ProjectDBEntities();

                if (userNum == 0)
                    userNum = 1;
                else
                    userNum++;

                if (newAdmin)
                {
                    dbEntities.Database.ExecuteSqlCommand(createNewAdmin(dbEntities));
                }
                else
                    dbEntities.Database.ExecuteSqlCommand(createEmployee(dbEntities));

                fNameTextBox.Text = lNameTextBox.Text = depTextBox.Text = "";
            }
            else
                MessageBox.Show("Text Fields cannot be blank. Please enter first name, last name, and department.", 
                    "Empty Text Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private String createEmployee(ProjectDBEntities db)
        {
            Random rnd = new Random();
            List<Employee> employeeList = db.Employees.ToList();

            String tempID = (Convert.ToInt32(employeeList[employeeList.Count - 1].EmployeeID) + 1) + "";
            for (int i = tempID.Length; i < 5; i++)
                tempID = "0" + tempID;

            String password = "defaultPass" + userNum + rnd.Next(1, 999);

            String command = "INSERT INTO Employees(EmployeeID, Password, FirstName, LastName, Department, Permissions) " +
                "VALUES ('" + tempID + "', '" + password + "', '" + fNameTextBox.Text + "', '" + lNameTextBox.Text +
                "', '" + depTextBox.Text + "', '" + getPermissions() + "');";

            MessageBox.Show(String.Format("Please provide this information to the user: \nEmployee ID: {0}\nPassword: {1}", tempID, password),
                "Employee Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return command;
        }

        private String createNewAdmin(ProjectDBEntities db)
        {
            Random rnd = new Random();
            returnButton.Enabled = true;
            LoginForm.currentEmployeeId = "00001";
            
            String sql = "DELETE FROM Employees WHERE EmployeeID = '10101';";
            db.Database.ExecuteSqlCommand(sql);
            
            String password = "defaultPass" + userNum + rnd.Next(1, 999);
            String command = "INSERT INTO Employees(EmployeeID, Password, FirstName, LastName, Department, Permissions) " +
            "VALUES ('00001', '" + password + "', '" + fNameTextBox.Text + "', '" + lNameTextBox.Text +
            "', '" + depTextBox.Text + "', '" + getPermissions() + "');";

            MessageBox.Show(String.Format("Here is your new login info. Please retain it as it cannot be changed prior to login\nEmployee ID: {0}\nPassword: {1}", "00001", password), 
                "Admin Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            changeProductsCheckBox.Checked = createUserCheckBox.Checked = transactionCheckBox.Checked =
            passwordCheckBox.Checked = employeeViewCheckBox.Checked = transactionViewCheckBox.Checked = false;
            permsGroupBox.Enabled = true;
            depTextBox.Enabled = true;

            newAdmin = false;
            return command;
        }

        private String getPermissions()
        {
            String str = "";
            str += checkBoxVal(changeProductsCheckBox);
            str += checkBoxVal(createUserCheckBox);
            str += checkBoxVal(transactionCheckBox);
            str += checkBoxVal(passwordCheckBox);
            str += checkBoxVal(employeeViewCheckBox);
            str += checkBoxVal(transactionViewCheckBox);
            return str;
        }

        private String checkBoxVal(CheckBox cb)
        {
            String str = "";
            if (cb.Checked) str += "1";
            else str += "0";
            return str;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mmf = new MainMenuForm();
            this.Hide();
            mmf.ShowDialog();
            this.Close();
        }
    }
}
