using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        private static int recordNo = 0;
        Datum[] data;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void previousRecordButton_Click(object sender, EventArgs e)
        {
            if (recordNo - 1 >= 0)
            {
                recordNo--;
                displayInfo();
            }
            else
            {
                recordNo = data.Length - 1;
                displayInfo();
            }
        }

        private void nextRecordButton_Click(object sender, EventArgs e)
        {
            
            if (recordNo + 1 < data.Length)
            {
                ++recordNo;
                displayInfo();
            }
            else
            {
                recordNo = 0;
                displayInfo();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                data = TestClass.getEmployeeData().data;
                displayInfo();
            }
            catch (Exception ex) {
                this.Close();
            }
        }

        public void displayInfo()
        {
            empIDTextBox.Text = data[recordNo].id + "";
            empNameTextBox.Text = data[recordNo].employee_name;
            empSalaryTextBox.Text = String.Format("{0:C}", data[recordNo].employee_salary);
            empAgeTextBox.Text = data[recordNo].employee_age + "";
        }
    }
}
