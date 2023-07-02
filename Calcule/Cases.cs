using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AmtechCalculator.Calcule;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace AmtechCalculator.Calcule
{
    internal class Cases : Form1
    {

        public void CalculPret(RadioButton buttonCuloare, RadioButton buttonForma)
        {
            float lungime, latime, numarbucati;
            float rontextbox1, eurotextbox1;
            
            Calcul calcul = new Calcul();

            float pretkg = extractor.FindMatchingRow(buttonForma, materialBox, buttonCuloare, grosimeTextBox);
            float greutate = extractor.FindMatchingRowGreutate(buttonForma, materialBox, buttonCuloare, grosimeTextBox);

            float.TryParse(lungimeTextBox.Text, out lungime);
            float.TryParse(latimeTextBox.Text, out latime);
            float.TryParse(nrbucTextBox.Text, out numarbucati);
            if (buttonForma == placaButton)
            {
                rontextbox1 = calcul.calculPlaca(lungime, latime, greutate, pretkg) * numarbucati;
                eurotextbox1 = (float)(rontextbox1 / 5);
                float calculationResultRON = rontextbox1;
                float calculationResultEUR = eurotextbox1;
                ronTextBox.Text = rontextbox1.ToString();
                euroTextBox.Text = eurotextbox1.ToString();
            }
            else if(buttonForma == baraButton) {
                float baraRON1 = calcul.calculBara(lungime, greutate, pretkg) * numarbucati;
                float baraEUR1 = (float)(baraRON1 / 5);
                float calculationResultRON = baraRON1;
                float calculationResultEUR = baraEUR1;
                baraRON.Text = baraRON1.ToString();
                baraEUR.Text = baraEUR1.ToString();
            }
          
        }
    }
}
