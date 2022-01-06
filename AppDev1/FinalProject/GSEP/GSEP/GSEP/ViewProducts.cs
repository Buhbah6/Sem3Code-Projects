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

        private void ViewProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.productsDataSet.Products);
        }

        private void searchSkuButton_Click(object sender, EventArgs e)
        {
            bool validProduct = false;
            var dbProducts = new ProjectDBEntities();
            Product currentProduct = new Product();
            List<Product> prodList = dbProducts.Products.ToList();
            foreach (Product product in prodList) {
                if (product.ProductSKU.Equals(skuTextBox.Text))
                {
                    validProduct = true;
                    currentProduct = product;
                }
            }
            if (String.IsNullOrEmpty(skuTextBox.Text) || validProduct == false)
            {
                MessageBox.Show("Sku not found.\nPlease enter a valid Sku to search.",
                    "Sku unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                descTextBox.Text = currentProduct.ProductName;
                priceTextBox.Text = currentProduct.Price + "";
                qtyNumericUpDown.Value = currentProduct.Quantity;
            }
        }

        private void editQtyButton_Click(object sender, EventArgs e)
        {
            bool validProduct = false;
            var dbProducts = new ProjectDBEntities();
            Product currentProduct = new Product();
            List<Product> prodList = dbProducts.Products.ToList();
            foreach (Product product in prodList)
            {
                if (product.ProductSKU.Equals(skuTextBox.Text))
                {
                    validProduct = true;
                    currentProduct = product;
                }
            }
            if (String.IsNullOrEmpty(skuTextBox.Text) || validProduct == false)
            {
                MessageBox.Show("Sku not found.\nPlease enter a valid Sku and Quantity to modify a product.",
                    "Sku unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string command = "UPDATE Products SET Quantity = " + qtyNumericUpDown.Value + " WHERE ProductSku = '" +
                    skuTextBox.Text + "';";
                dbProducts.Database.ExecuteSqlCommand(command);
                this.productsTableAdapter.Fill(this.productsDataSet.Products);
            }
        }

        private void editPriceButton_Click(object sender, EventArgs e)
        {
            bool validProduct = false;
            var dbProducts = new ProjectDBEntities();
            Product currentProduct = new Product();
            List<Product> prodList = dbProducts.Products.ToList();
            foreach (Product product in prodList)
            {
                if (product.ProductSKU.Equals(skuTextBox.Text))
                {
                    validProduct = true;
                    currentProduct = product;
                }
            }
            foreach (Char c in priceTextBox.Text)
            {
                if (!Char.IsNumber(c))
                    validProduct = false;
            }
            if (String.IsNullOrEmpty(skuTextBox.Text) || validProduct == false)
            {
                MessageBox.Show("Sku not found.\nPlease enter a valid Sku and Price to modify a product.",
                    "Sku unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(priceTextBox.Text) || validProduct == false)
            {
                MessageBox.Show("Invalid Price.\nPlease enter a valid Sku and Price to modify a product.",
                    "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string command = "UPDATE Products SET Price = '" + priceTextBox.Text + "'WHERE ProductSku = '" +
                    skuTextBox.Text + "';";
                dbProducts.Database.ExecuteSqlCommand(command);
                this.productsTableAdapter.Fill(this.productsDataSet.Products);
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            var productManagement = new ProjectDBEntities();
            List<Product> productList = productManagement.Products.ToList();
            bool validProduct = true;

            foreach (Product p in productList)
            {
                if (p.ProductSKU.Equals(skuTextBox.Text))
                {
                    validProduct = false;
                    MessageBox.Show("Sku unavailable.\nPlease enter a valid Sku to add a product.",
                    "Sku unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (String.IsNullOrEmpty(skuTextBox.Text) || String.IsNullOrEmpty(descTextBox.Text) || String.IsNullOrEmpty(priceTextBox.Text))
                validProduct = false;
            

            if (validProduct)
            {
                String command = "INSERT INTO Products VALUES ('" + skuTextBox.Text +
                    "','" + descTextBox.Text + "','" + priceTextBox.Text + "','" + qtyNumericUpDown.Value + "');";
                productManagement.Database.ExecuteSqlCommand(command);
            }
                
            else
            {
                MessageBox.Show("Missing Field.\nPlease enter data for all fields to add product successfully.",
                    "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mmf = new MainMenuForm();
            this.Hide();
            mmf.ShowDialog();
            this.Close();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productsDataSet);

        }
    }
}
