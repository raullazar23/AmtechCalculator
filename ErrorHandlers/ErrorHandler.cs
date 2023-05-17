using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace AmtechCalculator.ErrorHandlers
{
    internal class ErrorHandler
    {


        public ErrorHandler() { }

        public void eroareCuloare(RadioButton whiteRadioButton, RadioButton blackRadioButton)
        {
            if (!whiteRadioButton.Checked && !blackRadioButton.Checked)
            {
                MessageBox.Show("Introduceti o culoare!", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void eroareValori(TextBox latimeTextBox, TextBox lungimeTextBox)
        {
            int lungime, latime;
            if (int.TryParse(latimeTextBox.Text, out latime) && int.TryParse(lungimeTextBox.Text, out lungime))
            {
                // Do something with the integer value
            }
            else
            {
                MessageBox.Show("Introduceti corect valorile!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void eroareGrosime(ComboBox grosimeComboBox)
        {
            if (grosimeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Adaugati grosimea placii/barei!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
