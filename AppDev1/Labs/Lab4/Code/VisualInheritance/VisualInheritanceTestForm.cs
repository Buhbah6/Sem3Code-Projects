using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualInheritance
{
    public partial class VisualInheritanceTestForm :
        VisualInheritance.VisualInheritanceBaseForm
    {
    
        public VisualInheritanceTestForm()
        {
            InitializeComponent();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "This program was created by Deitel & Associates.",
            "About This Program", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
    } 
}
