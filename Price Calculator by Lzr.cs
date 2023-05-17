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
            Calcul calcul = new Calcul();

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

        private void baraButton_CheckedChanged(object sender, EventArgs e)
        {
            if (baraButton.Checked)
            {
                baraPanel.Visible = true;
                placaPanel.Visible = false;
                baraPanel.BringToFront();
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

    }
}