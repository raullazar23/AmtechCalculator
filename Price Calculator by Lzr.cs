using AmtechCalculator.ErrorHandlers;
using AmtechCalculator.Calcule;

namespace AmtechCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            //error handlers
            ErrorHandler errorHandler = new ErrorHandler();
            errorHandler.eroareCuloare(whiteButton, blackButton);
            errorHandler.eroareValori(latimeTextBox, lungimeTextBox);
            errorHandler.eroareGrosime(grosimeComboBox);
            //---------------



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
            errorHandler.eroareCuloare(albBaraButton, negruBaraButton);
            errorHandler.eroareValoareLungime(lungimePa6Box);
            errorHandler.eroareGrosime(diamPa6ComboBox);


            Calcul calcul = new Calcul();
            DataExtractor dataExtractor = new DataExtractor();


            //Cazul in care bara este neagra
            if (negruBaraButton.Checked)
            {
                //Cazul in care se foloseste pretul din tabel
                if (prestabilitBara.Checked)
                {
                    float lungime, numarbucati;

                    float pretkg = dataExtractor.FindMatchingRow(baraButton, materialBox, negruBaraButton, diamPa6ComboBox);
                    float greutate = dataExtractor.FindMatchingRowGreutate(baraButton, materialBox, negruBaraButton, diamPa6ComboBox);

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

                    float greutate = dataExtractor.FindMatchingRowGreutate(baraButton, materialBox, negruBaraButton, diamPa6ComboBox);

                    float.TryParse(lungimePa6Box.Text, out lungime);
                    float.TryParse(nrbucPa6Box.Text, out numarbucati);
                    float.TryParse(pretpersonalizat.Text, out pretpersonalizatfloat);

                    float baraRON1 =(float)Math.Pow(10,-3) * lungime * greutate * pretpersonalizatfloat * numarbucati;
                    float baraEUR1 = (float)(baraRON1 / 5);

                    baraRON.Text = baraRON1.ToString();
                    baraEUR.Text = baraEUR1.ToString();
                }

            }

            //Cazul in care bara este alba
            if (albBaraButton.Checked)
            {
                if (prestabilitBara.Checked)
                {
                    float lungime, numarbucati;

                    float pretkg = dataExtractor.FindMatchingRow(baraButton, materialBox, albBaraButton, diamPa6ComboBox);
                    float greutate = dataExtractor.FindMatchingRowGreutate(baraButton, materialBox, albBaraButton, diamPa6ComboBox);

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

                    float greutate = dataExtractor.FindMatchingRowGreutate(baraButton, materialBox, albBaraButton, diamPa6ComboBox);

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