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

        public void eroareCuloare(RadioButton whiteRadioButton, RadioButton blackRadioButton, RadioButton verdeRadioButton, RadioButton universalRadioButton)
        {
            if (!whiteRadioButton.Checked && !blackRadioButton.Checked && !verdeRadioButton.Checked && !universalRadioButton.Checked)
            {
                MessageBox.Show("Introduceti o culoare!", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void eroareValoareLungime(TextBox lungimeTextBox)
        {
            float lungime;
            if (!float.TryParse(lungimeTextBox.Text, out lungime))
            {
                MessageBox.Show("Introduceti corect valorile!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void nopath(DataExtractor extractor)
        {
            if (extractor == null)
                MessageBox.Show("Nu exista baza de date!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Error);           
        }

        public void eroareValori(TextBox latimeTextBox, TextBox lungimeTextBox)
        {
            float lungime, latime;
            if (!float.TryParse(latimeTextBox.Text, out latime) && !float.TryParse(lungimeTextBox.Text, out lungime))
            {
                MessageBox.Show("Introduceti corect valorile!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void eroareGrosime(TextBox grosimeComboBox)
        {
            if (grosimeComboBox == null)
            {
                MessageBox.Show("Adaugati grosimea placii/barei!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
