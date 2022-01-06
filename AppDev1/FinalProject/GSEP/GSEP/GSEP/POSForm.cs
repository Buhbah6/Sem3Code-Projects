using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSEP
{
    public partial class POSForm : Form
    {
        private StreamWriter fileWriter;
        double totalPrice = 0;
        bool started = false;
        Transaction transaction;
        Transaction newTransaction;
       
        public POSForm()
        {
            InitializeComponent();
        }

        private void POSForm_Load(object sender, EventArgs e)
        {
            empIDTextBox.Text = LoginForm.currentEmployeeId;
            transaction = new ProjectDBEntities().Transactions.ToList().Last();
            newTransaction = new Transaction();
            newTransaction.TransactionID = (Convert.ToInt32(transaction.TransactionID) + 1) + "";
            for (int i = newTransaction.TransactionID.Length; i < 5; i++)
                newTransaction.TransactionID = "0" + newTransaction.TransactionID;
            newTransaction.TransactionDate = DateTime.Now;
            newTransaction.EmployeeID = empIDTextBox.Text;
            addButton.Enabled = false;
            endButton.Enabled = false;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            if (started)
                endButton_Click(sender, e);
            MainMenuForm mmf = new MainMenuForm();
            this.Hide();
            mmf.ShowDialog();
            this.Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            
            DialogResult result;
            string fileName;
            using (var fileChooser = new SaveFileDialog())
            {
                
                fileChooser.Filter = "Txt Documents (.txt)|*.txt|All files (*.*)|*.*";
                fileChooser.CheckFileExists = false;
                fileChooser.FileName = newTransaction.TransactionID;
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
                
            }
            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        var output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                        fileWriter = new StreamWriter(output);
                        started = true;
                        fileWriter.WriteLine("G.S.E.P\nGraphical Startup Essentials Program");
                        fileWriter.WriteLine("Transaction ID: " + newTransaction.TransactionID + " || Transaction Date: " + newTransaction.TransactionDate);
                        fileWriter.WriteLine("Employee ID: " + newTransaction.EmployeeID + "\n");
                        fileWriter.WriteLine("Transaction:");
                        startButton.Enabled = false;
                        addButton.Enabled = true;
                        endButton.Enabled = true;
                        skuTextBox.ReadOnly = false;
                        qtyNumericUpDown.ReadOnly = false;
                        qtyNumericUpDown.Enabled = true;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error opening file", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool validProduct = false;
            Product product = null;
            try
            {
                var dbAccess = new ProjectDBEntities();
                List<Product> prodList = dbAccess.Products.ToList();
                foreach (Product prod in prodList)
                {
                    if (prod.ProductSKU.Equals(skuTextBox.Text))
                    {
                        validProduct = true;
                        product = prod;
                    }
                }
                if (validProduct)
                {
                    if (product.Quantity >= qtyNumericUpDown.Value)
                    {   
                        product.Quantity -= (int) qtyNumericUpDown.Value;
                        string command = "UPDATE Products SET Quantity = " + (product.Quantity) + " WHERE ProductSku = '" +
                            skuTextBox.Text + "';";
                        dbAccess.Database.ExecuteSqlCommand(command);
                        currentTransactionListBox.Items.Add(product.ToString() + "     " + qtyNumericUpDown.Value);
                        fileWriter.WriteLine(product.ToString());
                        totalPrice += (double)product.Price * (int)qtyNumericUpDown.Value;
                        prevSkuTextBox.Text = product.ProductSKU;
                        priceTextBox.Text = product.Price + "";
                        totalPriceTextBox.Text = totalPrice + "";
                        skuTextBox.Text = "";
                        qtyNumericUpDown.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Quantity is larger than quantity available. Please reduce the quantity of this product on the transaction.",
                    "Insufficient Product Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sku not found.\nPlease enter a valid product sku to add it to the transaction.",
                    "Sku unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error Writing to File", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Format", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            var addTransaction = new ProjectDBEntities();
            try
            {
                double QST = totalPrice * 0.09975;
                double HST = totalPrice * 0.05;
                totalPrice += QST + HST;
                fileWriter.WriteLine("{0, 46} {1:C2}", "GST/HST:", HST);
                fileWriter.WriteLine("{0, 46} {1:C2}", "    QST:",  QST);
                fileWriter.WriteLine("{0, 46} {1:C2}\n", "  Total:",  totalPrice);
                fileWriter.WriteLine("Thank you for using th GSEP POS System. Have a nice day.");
                fileWriter?.Close();
                newTransaction.Total = (decimal) totalPrice;
                string date = newTransaction.TransactionDate.Year + "/" + newTransaction.TransactionDate.Month + "/" + newTransaction.TransactionDate.Day; 
               
                string command = "INSERT INTO Transactions VALUES ('" + newTransaction.TransactionID + "', '"
                    + date + "', " + newTransaction.Total + ", '" + newTransaction.EmployeeID + "');";
                addTransaction.Database.ExecuteSqlCommand(command);
                

            }
            catch (IOException)
            {
                MessageBox.Show("Cannot close file", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MainMenuForm mmf = new MainMenuForm();
            this.Hide();
            mmf.ShowDialog();
            this.Close();
        }
    }
}
