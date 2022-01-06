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
    public partial class ViewTransactionsForm : Form
    {
        public ViewTransactionsForm()
        {
            InitializeComponent();
        }

        private void ViewTransactionsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transactionsDataSet.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.transactionsDataSet.Transactions);
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
