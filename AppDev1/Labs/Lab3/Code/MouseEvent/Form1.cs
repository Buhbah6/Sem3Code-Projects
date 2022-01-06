using System;
using System.Drawing;
using System.Windows.Forms;

namespace MouseEvent
{
    public partial class PainterForm : Form
    {
        bool ShouldPaint { get; set; } = false;
        public PainterForm()
        {
            InitializeComponent();
        }
        private void PainterForm_MouseDown(object sender, MouseEventArgs e)
        {
            ShouldPaint = true;
        }

        private void PainterForm_MouseUp(object sender, MouseEventArgs e)
        {
            ShouldPaint = false;
        }

        private void PainterForm_Move(object sender, MouseEventArgs e)
        {
            if (ShouldPaint)
            {

                using (Graphics graphics = CreateGraphics())
                {
                    graphics.FillEllipse(
                    new SolidBrush(Color.BlueViolet), e.X, e.Y, 4, 4);
                }
            }
        }
    }
}