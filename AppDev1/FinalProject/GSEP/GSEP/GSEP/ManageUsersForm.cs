using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSEP
{
    public partial class ManageUsersForm : Form
    {
        bool perms = true;
        
        public ManageUsersForm()
        {
            InitializeComponent();
        }

        private void changePassButton_Click(object sender, EventArgs e)
        {
            var resetPass = new ProjectDBEntities();
            List<Employee> empList = resetPass.Employees.ToList();
            Random rnd = new Random();

            String password = "defaultPass" + 01 + rnd.Next(1, 999);
            if (!String.IsNullOrEmpty(empIDTextBox.Text) || verifyID(resetPass) == false)
            {
                String command = "UPDATE Employees SET password = '" + password + "'WHERE EmployeeID = '" + empIDTextBox.Text + "';";
                resetPass.Database.ExecuteSqlCommand(command);
                MessageBox.Show(String.Format("Password reset successfully.\nPlease provide this information to the user: " +
                   "\nPassword: {0}", password), "Employee Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                List<Login> logins = resetPass.Logins.ToList();
                foreach (Login login in logins)
                {
                    if (login.EmployeeID.Equals(empIDTextBox.Text))
                        resetPass.Database.ExecuteSqlCommand("DELETE FROM Logins WHERE EmployeeID = '" + empIDTextBox.Text + "';");
                }
            }
            else
                MessageBox.Show("To reset a users password, please enter their Employee ID.", "Password Reset Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void editNameButton_Click(object sender, EventArgs e)
        {
            var editName = new ProjectDBEntities();
            string command = "";

            if (String.IsNullOrEmpty(empIDTextBox.Text) || verifyID(editName) == false)
            {
                MessageBox.Show("Invalid Employee ID.\nPlease enter a valid Employee ID with the new first name, the new last name or both.",
                    "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(fNameTextBox.Text) && !String.IsNullOrEmpty(lNameTextBox.Text))
            {
                command = "UPDATE Employees SET LastName = '" + lNameTextBox.Text + "'WHERE EmployeeID = '" +
                    empIDTextBox.Text + "';";
                editName.Database.ExecuteSqlCommand(command);
                MessageBox.Show("Name Changed Successfully.", "Successful Name Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!String.IsNullOrEmpty(fNameTextBox.Text) && String.IsNullOrEmpty(lNameTextBox.Text))
            {
                command = "UPDATE Employees SET FirstName = '" + fNameTextBox.Text + "'WHERE EmployeeID = '" +
                    empIDTextBox.Text + "';";
                editName.Database.ExecuteSqlCommand(command);
                MessageBox.Show("Name Changed Successfully.", "Successful Name Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(fNameTextBox.Text) && String.IsNullOrEmpty(lNameTextBox.Text))
            {
                MessageBox.Show("Invalid Name.\nPlease enter a valid Employee ID with the new first name, the new last name or both.",
                    "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                command = "UPDATE Employees SET FirstName = '" + fNameTextBox.Text + "'WHERE EmployeeID = '" +
                    empIDTextBox.Text + "';" + "UPDATE Employees SET LastName = '" + lNameTextBox.Text + "'WHERE EmployeeID = '" +
                    empIDTextBox.Text + "';";
                editName.Database.ExecuteSqlCommand(command);
                MessageBox.Show("Name Changed Successfully.", "Successful Name Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
            this.employeesTableAdapter.Fill(this.employeesDataSet.Employees);
        }

        private void changeDeptButton_Click(object sender, EventArgs e)
        {
            var changeDept = new ProjectDBEntities();
            string command = "";

            if (String.IsNullOrEmpty(empIDTextBox.Text) || verifyID(changeDept) == false)
            {
                MessageBox.Show("Invalid Employee ID.\nPlease enter a valid Employee ID with the new department.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(depTextBox.Text))
            {
                MessageBox.Show("Invalid Department.\nPlease enter a valid Employee ID with the new department.", "Invalid Department", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                command = "UPDATE Employees SET Department = '" + depTextBox.Text + "'WHERE EmployeeID = '" +
                    empIDTextBox.Text + "';";
                changeDept.Database.ExecuteSqlCommand(command);
                MessageBox.Show("Department Changed Successfully.", "Successful Department Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.employeesTableAdapter.Fill(this.employeesDataSet.Employees);
        }

        private void changePermsButton_Click(object sender, EventArgs e)
        {
            var changePerms = new ProjectDBEntities();
            string command = "";

            if (String.IsNullOrEmpty(empIDTextBox.Text) || verifyID(changePerms) == false)
            {
                MessageBox.Show("Invalid Employee ID.\nPlease enter a valid Employee ID and check the boxes for the permissions you'd like to assign.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                command = "UPDATE Employees SET Permissions = '" + getPermissions() + "'WHERE EmployeeID = '" +
                    empIDTextBox.Text + "';";
                changePerms.Database.ExecuteSqlCommand(command);
                MessageBox.Show("Permissions Changed Successfully.", "Successful Permissions Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.employeesTableAdapter.Fill(this.employeesDataSet.Employees);
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            var deleteUser = new ProjectDBEntities();
            string command = "";

            if (String.IsNullOrEmpty(empIDTextBox.Text) || verifyID(deleteUser) == false)
            {
                MessageBox.Show("Invalid Employee ID.\nPlease enter a valid Employee ID to remove.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dg = MessageBox.Show("Are you sure you want to delete user " + empIDTextBox.Text + "?\n This action cannot be undone.", "Delete User?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    command = "DELETE FROM Employees WHERE EmployeeID = '" + empIDTextBox.Text + "';";
                    deleteUser.Database.ExecuteSqlCommand(command);
                    MessageBox.Show("User Deleted Successfully.", "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User Deletion Cancelled.", "User NOT Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.employeesTableAdapter.Fill(this.employeesDataSet.Employees);
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeesDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employeesDataSet.Employees);

            var permEntities = new ProjectDBEntities();
            List<Employee> employeeList = permEntities.Employees.ToList();
            String perms = "";
            foreach (Employee emp in employeeList)
            {
                if (emp.EmployeeID.Equals(LoginForm.currentEmployeeId))
                    perms = emp.Permissions;
            }

            if (perms.ElementAt(1) == '0')
            {
                updatePermsButton.Enabled = false;
                deleteUserButton.Enabled = false;
                permsGroupBox.Enabled = false;
                editNameButton.Enabled = false;
                changeDeptButton.Enabled = false;
                this.perms = false;
            }
            if (perms.ElementAt(3) == '0')
            {
                resetPassButton.Enabled = false;
                this.perms = false;
            }
                
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mmf = new MainMenuForm();
            this.Hide();
            mmf.ShowDialog();
            this.Close();
        }

        private void empIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (empIDTextBox.Text.Equals(LoginForm.currentEmployeeId))
            {
                resetPassButton.Enabled = false;
                updatePermsButton.Enabled = false;
                deleteUserButton.Enabled = false;
                permsGroupBox.Enabled = false;
            }
            else if (perms == true)
            {
                resetPassButton.Enabled = true;
                updatePermsButton.Enabled = true;
                deleteUserButton.Enabled = true;
                permsGroupBox.Enabled = true;
            }
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

        public bool verifyID(ProjectDBEntities db) 
        {
            List<Employee> list = db.Employees.ToList();
            bool validID = false;
            foreach (Employee emp in list)
            {
                if (emp.EmployeeID.Equals(empIDTextBox.Text))
                    validID = true;
            }
            return validID;
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeesDataSet);

        }
    }
}
