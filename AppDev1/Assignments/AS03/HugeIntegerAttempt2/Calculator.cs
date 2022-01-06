using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HugeIntegerAttempt2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            HugeInteger firstInt = new HugeInteger();
            HugeInteger secondInt = new HugeInteger();

            firstInt.Input(firstIntTextBox.Text);
            secondInt.Input(secondIntTextBox.Text);
            if (!handleExceptions(firstInt, secondInt))
            {
                checkBoxes(firstInt, secondInt);
                HugeInteger newHugeInt = firstInt.Add(secondInt);
                outputLabel.Text = newHugeInt.ToString();
            }
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            HugeInteger firstInt = new HugeInteger();
            HugeInteger secondInt = new HugeInteger();

            firstInt.Input(firstIntTextBox.Text);
            secondInt.Input(secondIntTextBox.Text);

            if (!handleExceptions(firstInt, secondInt))
            {
                if (firstInt.isLessThan(secondInt))
                    MessageBox.Show("Les valeurs négatives ne sont pas prises en charge. Veuillez réessayer.", "Erreur de nombre négatif", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    checkBoxes(firstInt, secondInt);
                    HugeInteger newHugeInt = firstInt.Subtract(secondInt);
                    outputLabel.Text = newHugeInt.ToString();
                }
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            HugeInteger firstInt = new HugeInteger();
            HugeInteger secondInt = new HugeInteger();

            firstInt.Input(firstIntTextBox.Text);
            secondInt.Input(secondIntTextBox.Text);

            if (!handleExceptions(firstInt, secondInt))
            {
                checkBoxes(firstInt, secondInt);
                HugeInteger newHugeInt = firstInt.Multiply(secondInt);
                outputLabel.Text = newHugeInt.ToString();
            }
        }
        private void divideButton_Click(object sender, EventArgs e)
        {
            HugeInteger firstInt = new HugeInteger();
            HugeInteger secondInt = new HugeInteger();

            firstInt.Input(firstIntTextBox.Text);
            secondInt.Input(secondIntTextBox.Text);

            if (!handleExceptions(firstInt, secondInt))
            {
                checkBoxes(firstInt, secondInt);
                HugeInteger newHugeInt = firstInt.Divide(secondInt);
                outputLabel.Text = newHugeInt.ToString();
            }
        }

        private void remainderButton_Click(object sender, EventArgs e)
        {
            HugeInteger firstInt = new HugeInteger();
            HugeInteger secondInt = new HugeInteger();

            firstInt.Input(firstIntTextBox.Text);
            secondInt.Input(secondIntTextBox.Text);

            if (!handleExceptions(firstInt, secondInt))
            {
                checkBoxes(firstInt, secondInt);
                HugeInteger newHugeInt = firstInt.Remainder(secondInt);
                outputLabel.Text = newHugeInt.ToString();
            }
        }

        private void checkBoxes(HugeInteger int1, HugeInteger int2)
        {
            isZeroCheckBox.Checked = false;
            isEqualToCheckBox.Checked = false;
            isNotEqualToCheckBox.Checked = false;
            isGreaterThanCheckBox.Checked = false;
            isLessThanCheckBox.Checked = false;
            isGreaterThanOrEqualToCheckBox.Checked = false;
            isLessThanOrEqualToCheckBox.Checked = false;

            if (int1.isZero() || int2.isZero())
                isZeroCheckBox.Checked = true;
            if (int1.isEqualTo(int2))
                isEqualToCheckBox.Checked = true;
            if (int1.isNotEqualTo(int2))
                isNotEqualToCheckBox.Checked = true;
            if (int1.isGreaterThan(int2))
                isGreaterThanCheckBox.Checked = true;
            if (int1.isLessThan(int2))
                isLessThanCheckBox.Checked = true;
            if (int1.isGreaterThanOrEqualTo(int2))
                isGreaterThanOrEqualToCheckBox.Checked = true;
            if (int1.isLessThanOrEqualTo(int2))
                isLessThanOrEqualToCheckBox.Checked = true;
        }

        private Boolean handleExceptions(HugeInteger int1, HugeInteger int2)
        {
            foreach (char dig in firstIntTextBox.Text + secondIntTextBox.Text)
            {
                if (!Char.IsNumber(dig))
                {
                    MessageBox.Show("L'entrée ne peut être que des nombres entiers positifs. Veuillez saisir une valeur valide.", "Erreur d'entrée non valide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }

            }

            if (firstIntTextBox.TextLength == 0 || secondIntTextBox.TextLength == 0)
            {
                MessageBox.Show("Les champs de texte ne peuvent pas être vides. Veuillez saisir une valeur.", "Erreur de champ vide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage.UpdateConfig("language", "en");
            Application.Restart();
        }

        private void françaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage.UpdateConfig("language", "fr-CA");
            Application.Restart();
        }
    }
}
