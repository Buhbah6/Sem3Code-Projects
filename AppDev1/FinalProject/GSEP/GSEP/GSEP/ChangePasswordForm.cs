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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            bool validInfo = false;
            var passReqs = new ProjectDBEntities();
            List<Employee> employeeList = passReqs.Employees.ToList();
            foreach (Employee emp in employeeList)
            {
                if (emp.EmployeeID.Equals(LoginForm.currentEmployeeId))
                    validInfo = emp.Password == oldPassTextBox.Text;
            }

            if (validInfo)
            {
                if (newPassTextBox.Text.Equals(newPassTextBox2.Text))
                {
                    if (meetsRequirements(newPassTextBox.Text))
                    {
                        String command = "UPDATE Employees SET Password = REPLACE('" + oldPassTextBox.Text + "', '" +
                            oldPassTextBox.Text + "', '" + newPassTextBox.Text + "') WHERE EmployeeID = '" +
                            LoginForm.currentEmployeeId + "';";
                        passReqs.Database.ExecuteSqlCommand(command);
                        MessageBox.Show("Password Changed Successfully. Returning to Main Menu.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainMenuForm mmf = new MainMenuForm();
                        this.Hide();
                        mmf.ShowDialog();
                        this.Close();
                    }
                    else
                        errorLabel.Text = "Password does not meet minimum requirements";
                }
                else
                    errorLabel.Text = "New password doesn't match. Please Try Again.";
            }
            else
                errorLabel.Text = "Old Password is incorrect. Access Denied. Please Try Again.";
            
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                oldPassTextBox.PasswordChar = '\0';
                newPassTextBox.PasswordChar = '\0';
                newPassTextBox2.PasswordChar = '\0';
            }
            else
            {
                oldPassTextBox.PasswordChar = '*';
                newPassTextBox.PasswordChar = '*';
                newPassTextBox2.PasswordChar = '*';
            }
        }

        private bool meetsRequirements(String passwd)
        {
            bool caps = false;
            bool mins = false;
            bool nums = false;
            bool syms = false;
            bool notDefault = false;
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";

            foreach (char c in passwd)
            {
                if (Char.IsUpper(c))
                    caps = true;
                if (Char.IsLower(c))
                    mins = true;
                if (Char.IsNumber(c))
                    nums = true;
                if (specialChar.Contains(c))
                    syms = true;
            }
            if (!passwd.Equals("defaultPass"))
                notDefault = true;
            Console.WriteLine(caps + " " + mins + " " + nums + " " + syms + " " + notDefault);
            return caps && mins && nums && syms && notDefault;
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            if (this.Owner is LoginForm)
            {
                menuButton.Enabled = false;
                menuButton.Visible = false;
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mmf = new MainMenuForm();
            this.Hide();
            mmf.ShowDialog();
            this.Close();
        }
    }
}
