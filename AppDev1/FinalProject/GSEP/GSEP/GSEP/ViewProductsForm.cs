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
    public partial class ViewProductsForm : Form
    {
        
        public ViewProductsForm()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productsDataSet1);

        }

        private void ViewProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productsDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.productsDataSet1.Products);


            var permEntities = new ProjectDBEntities();
            List<Employee> employeeList = permEntities.Employees.ToList();
            String perms = "";
            foreach (Employee emp in employeeList)
            {
                if (emp.EmployeeID.Equals(LoginForm.currentEmployeeId))
                    perms = emp.Permissions;
            }
            if (perms.ElementAt(0) == '0')
            {
                addButton.Enabled = false;
                removeButton.Enabled = false;
                updateButton.Enabled = false;

                productSKUTextBox.ReadOnly = true;
                productNameTextBox.ReadOnly = true;
                priceTextBox.ReadOnly = true;
                quantityTextBox.ReadOnly = true;
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var productManagement = new ProjectDBEntities();
            List<Product> employeeList = productManagement.Products.ToList();

            String command = "INSERT INTO Products (ProductSKU, ProductName, Price, Quantity) VALUES ('" + productSKUTextBox.Text +
                "','" + productNameTextBox.Text + "','" + priceTextBox.Text + "','" + quantityTextBox.Text + "',)";
            
            productManagement.Database.ExecuteSqlCommand(command);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var productManagement = new ProjectDBEntities();
            List<Product> employeeList = productManagement.Products.ToList();

            String command = "DELETE * FROM Products WHERE ProductSKU = '" + productSKUTextBox.Text + "';";

            productManagement.Database.ExecuteSqlCommand(command);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var productManagement = new ProjectDBEntities();
            List<Product> employeeList = productManagement.Products.ToList();

            String command = "UPDATE Products SET productName = '" + productSKUTextBox.Text + "', price = '" + 
                priceTextBox.Text + "', quantity = '" + quantityTextBox.Text + "'WHERE ProductSKU = '" + 
                productSKUTextBox.Text + "';";

            productManagement.Database.ExecuteSqlCommand(command);
        }
    }
}
