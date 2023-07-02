using AmtechCalculator.ErrorHandlers;
using AmtechCalculator.Calcule;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Configuration;

namespace AmtechCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private DataExtractor extractor;

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void databaseButton_Click(object sender, EventArgs e)
        {
            string filePath = null;

            MessageBox.Show("Please enter the path of the CSV file:");

            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog1.FileName;
                }
                else
                {
                    this.Close();
                    return;
                }
            }
            DataExtractor localExtractor = new DataExtractor(filePath);
            this.extractor = localExtractor;
            // Save the path in the configuration file
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["FilePath"].Value = filePath;
            config.Save(ConfigurationSaveMode.Modified);

            DataExtractor extractor = new DataExtractor(filePath);
            // Now the 'extractor' object is accessible to other methods within the class
        }



        //PANEL PLACA -----------------------------------------------------------------------------------------------------------------------
        private void personalizatButton_CheckedChanged(object sender, EventArgs e)
        {
            if (personalizatButton.Checked)
            {
                priceTextBox.Visible = true;
            }
            else
            {
                priceTextBox.Visible = false;
            }
        }

        private void priceTextBox_Enter(object sender, EventArgs e)
        {
            if (priceTextBox.Text == "Pret personalizat")
            {
                priceTextBox.Text = "";
            }
        }

        private void priceTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(priceTextBox.Text))
            {
                priceTextBox.Text = "Pret personalizat";
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //error handlers
            ErrorHandler errorHandler = new ErrorHandler();
            errorHandler.eroareCuloare(whiteButton, blackButton, radioVerdePlaca, radioUniversalPlaca);
            errorHandler.eroareValori(latimeTextBox, lungimeTextBox);
            errorHandler.eroareGrosime(grosimeTextBox);
            //errorHandler.nopath(extractor);
            //---------------

            Calcul calcul = new Calcul();



            //Cazul in care placa este neagra
            if (blackButton.Checked)
            {
                //Cazul in care se foloseste pretul din tabel
                if (prestabilitButton.Checked)
                {
                    float lungime, latime, numarbucati;

                    float pretkg = extractor.FindMatchingRow(placaButton, materialBox, blackButton, grosimeTextBox);
                    float greutate = extractor.FindMatchingRowGreutate(placaButton, materialBox, blackButton, grosimeTextBox);

                    float.TryParse(lungimeTextBox.Text, out lungime);
                    float.TryParse(latimeTextBox.Text, out latime);
                    float.TryParse(nrbucTextBox.Text, out numarbucati);

                    float rontextbox1 = calcul.calculPlaca(lungime, latime, greutate, pretkg) * numarbucati;
                    float eurotextbox1 = (float)(rontextbox1 / 5);

                    ronTextBox.Text = rontextbox1.ToString();
                    euroTextBox.Text = eurotextbox1.ToString();
                }
                else if (personalizatButton.Checked)
                {
                    float lungime, latime, numarbucati, pretpersonalizatfloat;

                    float greutate = extractor.FindMatchingRowGreutate(placaButton, materialBox, blackButton, grosimeTextBox);

                    float.TryParse(lungimeTextBox.Text, out lungime);
                    float.TryParse(latimeTextBox.Text, out latime);
                    float.TryParse(nrbucTextBox.Text, out numarbucati);
                    float.TryParse(priceTextBox.Text, out pretpersonalizatfloat);

                    float rontextbox1 = (float)(greutate * (lungime * Math.Pow(10, -3)) + (latime * Math.Pow(10, -3)) * pretpersonalizatfloat) * numarbucati;
                    float eurotextbox1 = (float)(rontextbox1 / 5);

                    ronTextBox.Text = rontextbox1.ToString();
                    euroTextBox.Text = eurotextbox1.ToString();
                }

            }

            //Cazul in care placa este alba
            if (whiteButton.Checked)
            {
                if (prestabilitButton.Checked)
                {
                    float lungime, latime, numarbucati;

                    float pretkg = extractor.FindMatchingRow(placaButton, materialBox, whiteButton, grosimeTextBox);
                    float greutate = extractor.FindMatchingRowGreutate(placaButton, materialBox, whiteButton, grosimeTextBox);

                    float.TryParse(lungimeTextBox.Text, out lungime);
                    float.TryParse(latimeTextBox.Text, out latime);
                    float.TryParse(nrbucTextBox.Text, out numarbucati);

                    float rontextbox1 = calcul.calculPlaca(lungime, latime, greutate, pretkg) * numarbucati;
                    float eurotextbox1 = (float)(rontextbox1 / 5);

                    ronTextBox.Text = rontextbox1.ToString();
                    euroTextBox.Text = eurotextbox1.ToString();
                }
                else if (personalizatButton.Checked)
                {
                    float lungime, latime, numarbucati, pretpersonalizatfloat;

                    float greutate = extractor.FindMatchingRowGreutate(placaButton, materialBox, whiteButton, grosimeTextBox);

                    float.TryParse(lungimeTextBox.Text, out lungime);
                    float.TryParse(latimeTextBox.Text, out latime);
                    float.TryParse(nrbucTextBox.Text, out numarbucati);
                    float.TryParse(priceTextBox.Text, out pretpersonalizatfloat);

                    float rontextbox1 = ((float)Math.Pow(10, -3) * lungime) * ((float)Math.Pow(10, -3) * latime) * greutate * pretpersonalizatfloat * numarbucati;
                    float eurotextbox1 = (float)(rontextbox1 / 5);

                    ronTextBox.Text = rontextbox1.ToString();
                    euroTextBox.Text = eurotextbox1.ToString();
                }
            }
            if (blackButton.Checked)
            {
                //Cazul in care se foloseste pretul din tabel
                if (prestabilitButton.Checked)
                {
                    float lungime, latime, numarbucati;

                    float pretkg = extractor.FindMatchingRow(placaButton, materialBox, blackButton, grosimeTextBox);
                    float greutate = extractor.FindMatchingRowGreutate(placaButton, materialBox, blackButton, grosimeTextBox);

                    float.TryParse(lungimeTextBox.Text, out lungime);
                    float.TryParse(latimeTextBox.Text, out latime);
                    float.TryParse(nrbucTextBox.Text, out numarbucati);

                    float rontextbox1 = calcul.calculPlaca(lungime, latime, greutate, pretkg) * numarbucati;
                    float eurotextbox1 = (float)(rontextbox1 / 5);

                    ronTextBox.Text = rontextbox1.ToString();
                    euroTextBox.Text = eurotextbox1.ToString();
                }
                else if (personalizatButton.Checked)
                {
                    float lungime, latime, numarbucati, pretpersonalizatfloat;

                    float greutate = extractor.FindMatchingRowGreutate(placaButton, materialBox, blackButton, grosimeTextBox);

                    float.TryParse(lungimeTextBox.Text, out lungime);
                    float.TryParse(latimeTextBox.Text, out latime);
                    float.TryParse(nrbucTextBox.Text, out numarbucati);
                    float.TryParse(priceTextBox.Text, out pretpersonalizatfloat);

                    float rontextbox1 = (float)(greutate * (lungime * Math.Pow(10, -3)) + (latime * Math.Pow(10, -3)) * pretpersonalizatfloat) * numarbucati;
                    float eurotextbox1 = (float)(rontextbox1 / 5);

                    ronTextBox.Text = rontextbox1.ToString();
                    euroTextBox.Text = eurotextbox1.ToString();
                }

            }

            //Cazul in care placa este verde
            if (radioVerdePlaca.Checked)
            {
                if (prestabilitButton.Checked)
                {
                    float lungime, latime, numarbucati;

                    float pretkg = extractor.FindMatchingRow(placaButton, materialBox, radioVerdePlaca, grosimeTextBox);
                    float greutate = extractor.FindMatchingRowGreutate(placaButton, materialBox, radioVerdePlaca, grosimeTextBox);

                    float.TryParse(lungimeTextBox.Text, out lungime);
                    float.TryParse(latimeTextBox.Text, out latime);
                    float.TryParse(nrbucTextBox.Text, out numarbucati);

                    float rontextbox1 = calcul.calculPlaca(lungime, latime, greutate, pretkg) * numarbucati;
                    float eurotextbox1 = (float)(rontextbox1 / 5);

                    ronTextBox.Text = rontextbox1.ToString();
                    euroTextBox.Text = eurotextbox1.ToString();
                }
                else if (personalizatButton.Checked)
                {
                    float lungime, latime, numarbucati, pretpersonalizatfloat;

                    float greutate = extractor.FindMatchingRowGreutate(placaButton, materialBox, radioVerdePlaca, grosimeTextBox);

                    float.TryParse(lungimeTextBox.Text, out lungime);
                    float.TryParse(latimeTextBox.Text, out latime);
                    float.TryParse(nrbucTextBox.Text, out numarbucati);
                    float.TryParse(priceTextBox.Text, out pretpersonalizatfloat);

                    float rontextbox1 = ((float)Math.Pow(10, -3) * lungime) * ((float)Math.Pow(10, -3) * latime) * greutate * pretpersonalizatfloat * numarbucati;
                    float eurotextbox1 = (float)(rontextbox1 / 5);

                    ronTextBox.Text = rontextbox1.ToString();
                    euroTextBox.Text = eurotextbox1.ToString();
                }
            }
            //Cazul in care placa este universala
            if (radioUniversalPlaca.Checked)
            {
                if (prestabilitButton.Checked)
                {
                    float lungime, latime, numarbucati;

                    float pretkg = extractor.FindMatchingRow(placaButton, materialBox, radioUniversalPlaca, grosimeTextBox);
                    float greutate = extractor.FindMatchingRowGreutate(placaButton, materialBox, radioUniversalPlaca, grosimeTextBox);

                    float.TryParse(lungimeTextBox.Text, out lungime);
                    float.TryParse(latimeTextBox.Text, out latime);
                    float.TryParse(nrbucTextBox.Text, out numarbucati);

                    float rontextbox1 = calcul.calculPlaca(lungime, latime, greutate, pretkg) * numarbucati;
                    float eurotextbox1 = (float)(rontextbox1 / 5);

                    ronTextBox.Text = rontextbox1.ToString();
                    euroTextBox.Text = eurotextbox1.ToString();
                }
                else if (personalizatButton.Checked)
                {
                    float lungime, latime, numarbucati, pretpersonalizatfloat;

                    float greutate = extractor.FindMatchingRowGreutate(placaButton, materialBox, radioUniversalPlaca, grosimeTextBox);

                    float.TryParse(lungimeTextBox.Text, out lungime);
                    float.TryParse(latimeTextBox.Text, out latime);
                    float.TryParse(nrbucTextBox.Text, out numarbucati);
                    float.TryParse(priceTextBox.Text, out pretpersonalizatfloat);

                    float rontextbox1 = ((float)Math.Pow(10, -3) * lungime) * ((float)Math.Pow(10, -3) * latime) * greutate * pretpersonalizatfloat * numarbucati;
                    float eurotextbox1 = (float)(rontextbox1 / 5);

                    ronTextBox.Text = rontextbox1.ToString();
                    euroTextBox.Text = eurotextbox1.ToString();
                }
            }

        }

        private void placaButton_CheckedChanged(object sender, EventArgs e)
        {
            if (placaButton.Checked)
            {
                placaPanel.Visible = true;
                baraPanel.Visible = false;
                placaPanel.BringToFront();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baraPanel.Visible = false;
            this.KeyPreview = true; // Enable the form to receive key events
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress); // Attach the KeyPress event handler
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Check if the Enter key was pressed
            {
                button1_Click(sender, e);
            }
        }

        //PANEL BARA--------------------------------------------------------------------------------------------------------------------------------------

        private void baraButton_CheckedChanged(object sender, EventArgs e)
        {
            if (baraButton.Checked)
            {
                baraPanel.Visible = true;
                placaPanel.Visible = false;
                baraPanel.BringToFront();
            }
        }

        private void ButonBara_Click(object sender, EventArgs e)
        {

            ErrorHandler errorHandler = new ErrorHandler();
            errorHandler.eroareCuloare(albBaraButton, negruBaraButton, radioVerdeBara, radioUniversalBara);
            errorHandler.eroareValoareLungime(lungimePa6Box);
            errorHandler.eroareGrosime(diamTextBox);
            //errorHandler.nopath(extractor);


            Calcul calcul = new Calcul();



            //Cazul in care bara este neagra
            if (negruBaraButton.Checked)
            {
                //Cazul in care se foloseste pretul din tabel
                if (clientBara.Checked)
                {
                    float lungime, numarbucati;

                    float pretkg = extractor.FindMatchingRow(baraButton, materialBox, negruBaraButton, diamTextBox);
                    float greutate = extractor.FindMatchingRowGreutate(baraButton, materialBox, negruBaraButton, diamTextBox);

                    float.TryParse(lungimePa6Box.Text, out lungime);
                    float.TryParse(nrbucPa6Box.Text, out numarbucati);

                    float baraRON1 = calcul.calculBara(lungime, greutate, pretkg) * numarbucati;
                    float baraEUR1 = (float)(baraRON1 / 5);

                    baraRON.Text = baraRON1.ToString();
                    baraEUR.Text = baraEUR1.ToString();
                }
                else if (personalizatBara.Checked)
                {
                    float lungime, numarbucati, pretpersonalizatfloat;

                    float greutate = extractor.FindMatchingRowGreutate(baraButton, materialBox, negruBaraButton, diamTextBox);

                    float.TryParse(lungimePa6Box.Text, out lungime);
                    float.TryParse(nrbucPa6Box.Text, out numarbucati);
                    float.TryParse(pretpersonalizat.Text, out pretpersonalizatfloat);

                    float baraRON1 = (float)Math.Pow(10, -3) * lungime * greutate * pretpersonalizatfloat * numarbucati;
                    float baraEUR1 = (float)(baraRON1 / 5);

                    baraRON.Text = baraRON1.ToString();
                    baraEUR.Text = baraEUR1.ToString();
                }

            }

            //Cazul in care bara este alba
            if (albBaraButton.Checked)
            {
                if (clientBara.Checked)
                {
                    float lungime, numarbucati;

                    float pretkg = extractor.FindMatchingRow(baraButton, materialBox, albBaraButton, diamTextBox);
                    float greutate = extractor.FindMatchingRowGreutate(baraButton, materialBox, albBaraButton, diamTextBox);

                    float.TryParse(lungimePa6Box.Text, out lungime);
                    float.TryParse(nrbucPa6Box.Text, out numarbucati);

                    float baraRON1 = calcul.calculBara(lungime, greutate, pretkg) * numarbucati;
                    float baraEUR1 = (float)(baraRON1 / 5);

                    baraRON.Text = baraRON1.ToString();
                    baraEUR.Text = baraEUR1.ToString();
                }
                else if (personalizatBara.Checked)
                {
                    float lungime, numarbucati, pretpersonalizatfloat;

                    float greutate = extractor.FindMatchingRowGreutate(baraButton, materialBox, albBaraButton, diamTextBox);

                    float.TryParse(lungimePa6Box.Text, out lungime);
                    float.TryParse(nrbucPa6Box.Text, out numarbucati);
                    float.TryParse(pretpersonalizat.Text, out pretpersonalizatfloat);

                    float baraRON1 = (float)Math.Pow(10, -3) * lungime * greutate * pretpersonalizatfloat * numarbucati;
                    float baraEUR1 = (float)(baraRON1 / 5);

                    baraRON.Text = baraRON1.ToString();
                    baraEUR.Text = baraEUR1.ToString();
                }
            }
            //Cazul in care bara este verde
            if (radioVerdeBara.Checked)
            {
                //Cazul in care se foloseste pretul din tabel
                if (clientBara.Checked)
                {
                    float lungime, numarbucati;

                    float pretkg = extractor.FindMatchingRow(baraButton, materialBox, radioVerdeBara, diamTextBox);
                    float greutate = extractor.FindMatchingRowGreutate(baraButton, materialBox, radioVerdeBara, diamTextBox);

                    float.TryParse(lungimePa6Box.Text, out lungime);
                    float.TryParse(nrbucPa6Box.Text, out numarbucati);

                    float baraRON1 = calcul.calculBara(lungime, greutate, pretkg) * numarbucati;
                    float baraEUR1 = (float)(baraRON1 / 5);

                    baraRON.Text = baraRON1.ToString();
                    baraEUR.Text = baraEUR1.ToString();
                }
                else if (personalizatBara.Checked)
                {
                    float lungime, numarbucati, pretpersonalizatfloat;

                    float greutate = extractor.FindMatchingRowGreutate(baraButton, materialBox, radioVerdeBara, diamTextBox);

                    float.TryParse(lungimePa6Box.Text, out lungime);
                    float.TryParse(nrbucPa6Box.Text, out numarbucati);
                    float.TryParse(pretpersonalizat.Text, out pretpersonalizatfloat);

                    float baraRON1 = (float)Math.Pow(10, -3) * lungime * greutate * pretpersonalizatfloat * numarbucati;
                    float baraEUR1 = (float)(baraRON1 / 5);

                    baraRON.Text = baraRON1.ToString();
                    baraEUR.Text = baraEUR1.ToString();
                }

            }
            //Cazul in care bara este universala
            if (radioUniversalBara.Checked)
            {
                //Cazul in care se foloseste pretul din tabel
                if (clientBara.Checked)
                {
                    float lungime, numarbucati;

                    float pretkg = extractor.FindMatchingRow(baraButton, materialBox, radioUniversalBara, diamTextBox);
                    float greutate = extractor.FindMatchingRowGreutate(baraButton, materialBox, radioUniversalBara, diamTextBox);

                    float.TryParse(lungimePa6Box.Text, out lungime);
                    float.TryParse(nrbucPa6Box.Text, out numarbucati);

                    float baraRON1 = calcul.calculBara(lungime, greutate, pretkg) * numarbucati;
                    float baraEUR1 = (float)(baraRON1 / 5);

                    baraRON.Text = baraRON1.ToString();
                    baraEUR.Text = baraEUR1.ToString();
                }
                else if (personalizatBara.Checked)
                {
                    float lungime, numarbucati, pretpersonalizatfloat;

                    float greutate = extractor.FindMatchingRowGreutate(baraButton, materialBox, radioUniversalBara, diamTextBox);

                    float.TryParse(lungimePa6Box.Text, out lungime);
                    float.TryParse(nrbucPa6Box.Text, out numarbucati);
                    float.TryParse(pretpersonalizat.Text, out pretpersonalizatfloat);

                    float baraRON1 = (float)Math.Pow(10, -3) * lungime * greutate * pretpersonalizatfloat * numarbucati;
                    float baraEUR1 = (float)(baraRON1 / 5);

                    baraRON.Text = baraRON1.ToString();
                    baraEUR.Text = baraEUR1.ToString();
                }

            }
        }

        private void personalizatBara_CheckedChanged(object sender, EventArgs e)
        {
            if (personalizatBara.Checked)
            {
                pretpersonalizat.Visible = true;
            }
            else
            {
                pretpersonalizat.Visible = false;
            }
        }
        private void pretpersonalizat_Enter(object sender, EventArgs e)
        {
            if (pretpersonalizat.Text == "Pret personalizat")
            {
                pretpersonalizat.Text = "";
            }
        }

        private void pretpersonalizat_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pretpersonalizat.Text))
            {
                pretpersonalizat.Text = "Pret personalizat";
            }
        }


    }

}