using System;
using System.Collections;
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
    public partial class LoginForm : Form
    {
        bool canLogin = false;
        public static String currentEmployeeId;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
                passwordTextBox.PasswordChar = '\0';
            else
                passwordTextBox.PasswordChar = '*';
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool validID = false;
            bool successfulLogin = true;
            var loginReqs = new ProjectDBEntities();
            int attempts = 0;
            
            List<Employee> employeeList = loginReqs.Employees.ToList();
            List<Login> loginList = loginReqs.Logins.ToList();
            for (int i = 0; i < employeeList.Count; i++)
            {
                if (employeeList[i].EmployeeID.Equals(usernameTextBox.Text))
                {
                    validID = true;
                    foreach (Login log in loginList)
                    {
                        if (log.EmployeeID.Equals(usernameTextBox.Text))
                        {
                            successfulLogin = false;
                            attempts = log.FailedLogins;
                        }
                    }
                    if (successfulLogin)
                    {
                        errorLabel.Text = "";
                        canLogin = true;
                    }
                    if (employeeList[i].Password.Equals(passwordTextBox.Text) && canLogin)
                    {
                        currentEmployeeId = employeeList[i].EmployeeID;
                        /*
                        if (successfulLogin == false && attempts < 3)
                        {
                            loginReqs.Database.ExecuteSqlCommand("UPDATE Logins SET FailedLogins = REPLACE(" + attempts + ", " +
                                    attempts + ", " + 0 + ") WHERE EmployeeID = '" + usernameTextBox.Text + "';");
                        }
                        */
                        if (usernameTextBox.Text.Equals("10101") && passwordTextBox.Text.Equals("ownerPass"))
                        {
                            CreateUserForm cuf = new CreateUserForm();
                            this.Hide();
                            cuf.ShowDialog(this);
                            this.Close();
                        }
                        else if (passwordTextBox.Text.Contains("defaultPass"))
                        {
                            ChangePasswordForm cpf = new ChangePasswordForm();
                            this.Hide();
                            cpf.ShowDialog(this);
                            this.Close();
                        }
                        else
                        {
                            MainMenuForm mmf = new MainMenuForm();
                            this.Hide();
                            mmf.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        if (usernameTextBox.Text.Equals("10101"))
                            errorLabel.Text = "Incorrect Password. Refer to User Manual for default login.";
                        else
                        {

                            if (successfulLogin)
                                loginReqs.Database.ExecuteSqlCommand("INSERT INTO Logins VALUES ('" + usernameTextBox.Text + "', " + attempts + ");");
                            else
                            {
                                loginReqs.Database.ExecuteSqlCommand("UPDATE Logins SET FailedLogins = REPLACE(" + attempts + ", " +
                                    attempts + ", " + (attempts + 1) + ") WHERE EmployeeID = '" + usernameTextBox.Text + "';");
                                attempts++;
                            }

                            if (attempts < 3)
                                errorLabel.Text = "Incorrect Password. Attempts remaining: " + (3 - attempts);
                            else
                            {
                                errorLabel.Text = "Incorrect Password. Please contact an administrator to reset your password.";
                                canLogin = false;
                            }
                        }
                    }
                }
                if (validID == false)
                errorLabel.Text = "Invalid ID";
            }

        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            currentEmployeeId = null;
        }
    }
}
