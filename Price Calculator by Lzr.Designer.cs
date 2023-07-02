namespace AmtechCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            exitButton = new Button();
            groupBox3 = new GroupBox();
            databaseButton = new Button();
            label15 = new Label();
            materialBox = new ComboBox();
            baraPanel = new Panel();
            diamTextBox = new TextBox();
            ButonBara = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            lungimePa6Box = new TextBox();
            baraEUR = new TextBox();
            label13 = new Label();
            label14 = new Label();
            baraRON = new TextBox();
            label16 = new Label();
            label17 = new Label();
            nrbucPa6Box = new TextBox();
            groupBox4 = new GroupBox();
            radioVerdeBara = new RadioButton();
            radioUniversalBara = new RadioButton();
            negruBaraButton = new RadioButton();
            albBaraButton = new RadioButton();
            groupBox5 = new GroupBox();
            pretpersonalizat = new TextBox();
            clientBara = new RadioButton();
            personalizatBara = new RadioButton();
            placaPanel = new Panel();
            grosimeTextBox = new TextBox();
            label9 = new Label();
            ButonPlaca = new Button();
            label1 = new Label();
            label8 = new Label();
            lungimeTextBox = new TextBox();
            euroTextBox = new TextBox();
            latimeTextBox = new TextBox();
            label7 = new Label();
            label3 = new Label();
            ronTextBox = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            nrbucTextBox = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            radioVerdePlaca = new RadioButton();
            radioUniversalPlaca = new RadioButton();
            blackButton = new RadioButton();
            whiteButton = new RadioButton();
            groupBox2 = new GroupBox();
            priceTextBox = new TextBox();
            prestabilitButton = new RadioButton();
            personalizatButton = new RadioButton();
            baraButton = new RadioButton();
            placaButton = new RadioButton();
            openFileDialog1 = new OpenFileDialog();
            distribuitorBara = new RadioButton();
            groupBox3.SuspendLayout();
            baraPanel.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            placaPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Location = new Point(344, 334);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 0;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(databaseButton);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(materialBox);
            groupBox3.Controls.Add(baraPanel);
            groupBox3.Controls.Add(placaPanel);
            groupBox3.Controls.Add(baraButton);
            groupBox3.Controls.Add(placaButton);
            groupBox3.Location = new Point(-2, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(428, 316);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Forma";
            // 
            // databaseButton
            // 
            databaseButton.Location = new Point(337, 16);
            databaseButton.Name = "databaseButton";
            databaseButton.Size = new Size(75, 23);
            databaseButton.TabIndex = 28;
            databaseButton.Text = "Database";
            databaseButton.UseVisualStyleBackColor = true;
            databaseButton.Click += databaseButton_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(196, -2);
            label15.Name = "label15";
            label15.Size = new Size(50, 15);
            label15.TabIndex = 25;
            label15.Text = "Material";
            // 
            // materialBox
            // 
            materialBox.FormattingEnabled = true;
            materialBox.Items.AddRange(new object[] { "PE1000", "PE500", "PA 6 E", "PA 6 G", "POM", "PET", "PEEK", "PP", "PVC", "Textolit", "PTFE" });
            materialBox.Location = new Point(197, 16);
            materialBox.Name = "materialBox";
            materialBox.Size = new Size(121, 23);
            materialBox.TabIndex = 25;
            // 
            // baraPanel
            // 
            baraPanel.Controls.Add(diamTextBox);
            baraPanel.Controls.Add(ButonBara);
            baraPanel.Controls.Add(label10);
            baraPanel.Controls.Add(label11);
            baraPanel.Controls.Add(label12);
            baraPanel.Controls.Add(lungimePa6Box);
            baraPanel.Controls.Add(baraEUR);
            baraPanel.Controls.Add(label13);
            baraPanel.Controls.Add(label14);
            baraPanel.Controls.Add(baraRON);
            baraPanel.Controls.Add(label16);
            baraPanel.Controls.Add(label17);
            baraPanel.Controls.Add(nrbucPa6Box);
            baraPanel.Controls.Add(groupBox4);
            baraPanel.Controls.Add(groupBox5);
            baraPanel.Location = new Point(6, 52);
            baraPanel.Name = "baraPanel";
            baraPanel.Size = new Size(415, 251);
            baraPanel.TabIndex = 27;
            // 
            // diamTextBox
            // 
            diamTextBox.Location = new Point(19, 34);
            diamTextBox.Margin = new Padding(3, 2, 3, 2);
            diamTextBox.Name = "diamTextBox";
            diamTextBox.Size = new Size(110, 23);
            diamTextBox.TabIndex = 26;
            // 
            // ButonBara
            // 
            ButonBara.Location = new Point(19, 208);
            ButonBara.Name = "ButonBara";
            ButonBara.Size = new Size(83, 23);
            ButonBara.TabIndex = 25;
            ButonBara.Text = "Calculează!";
            ButonBara.UseVisualStyleBackColor = true;
            ButonBara.Click += ButonBara_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(305, 229);
            label10.Name = "label10";
            label10.Size = new Size(37, 15);
            label10.TabIndex = 24;
            label10.Text = "EURO";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 12);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 2;
            label11.Text = "Diametru";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(311, 200);
            label12.Name = "label12";
            label12.Size = new Size(32, 15);
            label12.TabIndex = 23;
            label12.Text = "RON";
            // 
            // lungimePa6Box
            // 
            lungimePa6Box.Location = new Point(19, 83);
            lungimePa6Box.Margin = new Padding(3, 2, 3, 2);
            lungimePa6Box.Name = "lungimePa6Box";
            lungimePa6Box.Size = new Size(110, 23);
            lungimePa6Box.TabIndex = 6;
            // 
            // baraEUR
            // 
            baraEUR.BackColor = SystemColors.Info;
            baraEUR.Location = new Point(210, 222);
            baraEUR.Margin = new Padding(3, 2, 3, 2);
            baraEUR.Name = "baraEUR";
            baraEUR.ReadOnly = true;
            baraEUR.Size = new Size(84, 23);
            baraEUR.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(210, 178);
            label13.Name = "label13";
            label13.Size = new Size(54, 15);
            label13.TabIndex = 21;
            label13.Text = "Preț final";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(19, 66);
            label14.Name = "label14";
            label14.Size = new Size(54, 15);
            label14.TabIndex = 8;
            label14.Text = "Lungime";
            // 
            // baraRON
            // 
            baraRON.BackColor = SystemColors.Info;
            baraRON.Location = new Point(210, 195);
            baraRON.Margin = new Padding(3, 2, 3, 2);
            baraRON.Name = "baraRON";
            baraRON.ReadOnly = true;
            baraRON.Size = new Size(84, 23);
            baraRON.TabIndex = 20;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(19, 157);
            label16.Name = "label16";
            label16.Size = new Size(96, 15);
            label16.TabIndex = 19;
            label16.Text = "Număr de bucăți";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(134, 88);
            label17.Name = "label17";
            label17.Size = new Size(29, 15);
            label17.TabIndex = 10;
            label17.Text = "mm";
            // 
            // nrbucPa6Box
            // 
            nrbucPa6Box.Location = new Point(19, 174);
            nrbucPa6Box.Margin = new Padding(3, 2, 3, 2);
            nrbucPa6Box.Name = "nrbucPa6Box";
            nrbucPa6Box.Size = new Size(110, 23);
            nrbucPa6Box.TabIndex = 18;
            nrbucPa6Box.Text = "1";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioVerdeBara);
            groupBox4.Controls.Add(radioUniversalBara);
            groupBox4.Controls.Add(negruBaraButton);
            groupBox4.Controls.Add(albBaraButton);
            groupBox4.Location = new Point(184, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(216, 69);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Culoare";
            // 
            // radioVerdeBara
            // 
            radioVerdeBara.AutoSize = true;
            radioVerdeBara.Location = new Point(6, 44);
            radioVerdeBara.Name = "radioVerdeBara";
            radioVerdeBara.Size = new Size(54, 19);
            radioVerdeBara.TabIndex = 6;
            radioVerdeBara.TabStop = true;
            radioVerdeBara.Text = "Verde";
            radioVerdeBara.UseVisualStyleBackColor = true;
            // 
            // radioUniversalBara
            // 
            radioUniversalBara.AutoSize = true;
            radioUniversalBara.Location = new Point(71, 44);
            radioUniversalBara.Name = "radioUniversalBara";
            radioUniversalBara.Size = new Size(73, 19);
            radioUniversalBara.TabIndex = 5;
            radioUniversalBara.TabStop = true;
            radioUniversalBara.Text = "Universal";
            radioUniversalBara.UseVisualStyleBackColor = true;
            // 
            // negruBaraButton
            // 
            negruBaraButton.AutoSize = true;
            negruBaraButton.Location = new Point(6, 22);
            negruBaraButton.Name = "negruBaraButton";
            negruBaraButton.Size = new Size(58, 19);
            negruBaraButton.TabIndex = 4;
            negruBaraButton.TabStop = true;
            negruBaraButton.Text = "Negru";
            negruBaraButton.TextImageRelation = TextImageRelation.ImageAboveText;
            negruBaraButton.UseVisualStyleBackColor = true;
            // 
            // albBaraButton
            // 
            albBaraButton.AutoSize = true;
            albBaraButton.Location = new Point(70, 22);
            albBaraButton.Name = "albBaraButton";
            albBaraButton.Size = new Size(43, 19);
            albBaraButton.TabIndex = 3;
            albBaraButton.TabStop = true;
            albBaraButton.Text = "Alb";
            albBaraButton.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(distribuitorBara);
            groupBox5.Controls.Add(pretpersonalizat);
            groupBox5.Controls.Add(clientBara);
            groupBox5.Controls.Add(personalizatBara);
            groupBox5.Location = new Point(184, 93);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(231, 76);
            groupBox5.TabIndex = 16;
            groupBox5.TabStop = false;
            groupBox5.Text = "Preț/kg";
            // 
            // pretpersonalizat
            // 
            pretpersonalizat.ForeColor = SystemColors.GrayText;
            pretpersonalizat.Location = new Point(6, 49);
            pretpersonalizat.Name = "pretpersonalizat";
            pretpersonalizat.Size = new Size(122, 23);
            pretpersonalizat.TabIndex = 17;
            pretpersonalizat.Text = "Pret personalizat";
            pretpersonalizat.Visible = false;
            pretpersonalizat.Enter += pretpersonalizat_Enter;
            pretpersonalizat.Leave += pretpersonalizat_Leave;
            // 
            // clientBara
            // 
            clientBara.AutoSize = true;
            clientBara.Checked = true;
            clientBara.Location = new Point(6, 22);
            clientBara.Name = "clientBara";
            clientBara.Size = new Size(56, 19);
            clientBara.TabIndex = 13;
            clientBara.TabStop = true;
            clientBara.Text = "Client";
            clientBara.UseVisualStyleBackColor = true;
            // 
            // personalizatBara
            // 
            personalizatBara.AutoSize = true;
            personalizatBara.Location = new Point(140, 22);
            personalizatBara.Name = "personalizatBara";
            personalizatBara.Size = new Size(88, 19);
            personalizatBara.TabIndex = 14;
            personalizatBara.Text = "Personalizat";
            personalizatBara.UseVisualStyleBackColor = true;
            personalizatBara.CheckedChanged += personalizatBara_CheckedChanged;
            // 
            // placaPanel
            // 
            placaPanel.Controls.Add(grosimeTextBox);
            placaPanel.Controls.Add(label9);
            placaPanel.Controls.Add(ButonPlaca);
            placaPanel.Controls.Add(label1);
            placaPanel.Controls.Add(label8);
            placaPanel.Controls.Add(lungimeTextBox);
            placaPanel.Controls.Add(euroTextBox);
            placaPanel.Controls.Add(latimeTextBox);
            placaPanel.Controls.Add(label7);
            placaPanel.Controls.Add(label3);
            placaPanel.Controls.Add(ronTextBox);
            placaPanel.Controls.Add(label4);
            placaPanel.Controls.Add(label2);
            placaPanel.Controls.Add(label5);
            placaPanel.Controls.Add(nrbucTextBox);
            placaPanel.Controls.Add(label6);
            placaPanel.Controls.Add(groupBox1);
            placaPanel.Controls.Add(groupBox2);
            placaPanel.Location = new Point(6, 52);
            placaPanel.Name = "placaPanel";
            placaPanel.Size = new Size(406, 251);
            placaPanel.TabIndex = 26;
            // 
            // grosimeTextBox
            // 
            grosimeTextBox.Location = new Point(19, 33);
            grosimeTextBox.Margin = new Padding(3, 2, 3, 2);
            grosimeTextBox.Name = "grosimeTextBox";
            grosimeTextBox.Size = new Size(110, 23);
            grosimeTextBox.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(299, 220);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 24;
            label9.Text = "EURO";
            // 
            // ButonPlaca
            // 
            ButonPlaca.Location = new Point(19, 208);
            ButonPlaca.Name = "ButonPlaca";
            ButonPlaca.Size = new Size(83, 23);
            ButonPlaca.TabIndex = 17;
            ButonPlaca.Text = "Calculează!";
            ButonPlaca.UseVisualStyleBackColor = true;
            ButonPlaca.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 12);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Grosime";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(299, 193);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 23;
            label8.Text = "RON";
            // 
            // lungimeTextBox
            // 
            lungimeTextBox.Location = new Point(19, 83);
            lungimeTextBox.Margin = new Padding(3, 2, 3, 2);
            lungimeTextBox.Name = "lungimeTextBox";
            lungimeTextBox.Size = new Size(110, 23);
            lungimeTextBox.TabIndex = 6;
            // 
            // euroTextBox
            // 
            euroTextBox.BackColor = SystemColors.Info;
            euroTextBox.Location = new Point(209, 218);
            euroTextBox.Margin = new Padding(3, 2, 3, 2);
            euroTextBox.Name = "euroTextBox";
            euroTextBox.ReadOnly = true;
            euroTextBox.Size = new Size(85, 23);
            euroTextBox.TabIndex = 22;
            // 
            // latimeTextBox
            // 
            latimeTextBox.Location = new Point(19, 132);
            latimeTextBox.Margin = new Padding(3, 2, 3, 2);
            latimeTextBox.Name = "latimeTextBox";
            latimeTextBox.Size = new Size(110, 23);
            latimeTextBox.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(209, 174);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 21;
            label7.Text = "Preț final";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 66);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 8;
            label3.Text = "Lungime";
            // 
            // ronTextBox
            // 
            ronTextBox.BackColor = SystemColors.Info;
            ronTextBox.Location = new Point(209, 191);
            ronTextBox.Margin = new Padding(3, 2, 3, 2);
            ronTextBox.Name = "ronTextBox";
            ronTextBox.ReadOnly = true;
            ronTextBox.Size = new Size(84, 23);
            ronTextBox.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 115);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 9;
            label4.Text = "Lățime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 157);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 19;
            label2.Text = "Număr de bucăți";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(134, 88);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 10;
            label5.Text = "mm";
            // 
            // nrbucTextBox
            // 
            nrbucTextBox.Location = new Point(19, 174);
            nrbucTextBox.Margin = new Padding(3, 2, 3, 2);
            nrbucTextBox.Name = "nrbucTextBox";
            nrbucTextBox.Size = new Size(110, 23);
            nrbucTextBox.TabIndex = 18;
            nrbucTextBox.Text = "1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(134, 135);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 11;
            label6.Text = "mm";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioVerdePlaca);
            groupBox1.Controls.Add(radioUniversalPlaca);
            groupBox1.Controls.Add(blackButton);
            groupBox1.Controls.Add(whiteButton);
            groupBox1.Location = new Point(184, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(214, 70);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Culoare";
            // 
            // radioVerdePlaca
            // 
            radioVerdePlaca.AutoSize = true;
            radioVerdePlaca.Location = new Point(6, 47);
            radioVerdePlaca.Name = "radioVerdePlaca";
            radioVerdePlaca.Size = new Size(54, 19);
            radioVerdePlaca.TabIndex = 6;
            radioVerdePlaca.TabStop = true;
            radioVerdePlaca.Text = "Verde";
            radioVerdePlaca.UseVisualStyleBackColor = true;
            // 
            // radioUniversalPlaca
            // 
            radioUniversalPlaca.AutoSize = true;
            radioUniversalPlaca.Location = new Point(68, 47);
            radioUniversalPlaca.Name = "radioUniversalPlaca";
            radioUniversalPlaca.Size = new Size(73, 19);
            radioUniversalPlaca.TabIndex = 5;
            radioUniversalPlaca.TabStop = true;
            radioUniversalPlaca.Text = "Universal";
            radioUniversalPlaca.UseVisualStyleBackColor = true;
            // 
            // blackButton
            // 
            blackButton.AutoSize = true;
            blackButton.Location = new Point(6, 22);
            blackButton.Name = "blackButton";
            blackButton.Size = new Size(58, 19);
            blackButton.TabIndex = 4;
            blackButton.TabStop = true;
            blackButton.Text = "Negru";
            blackButton.TextImageRelation = TextImageRelation.ImageAboveText;
            blackButton.UseVisualStyleBackColor = true;
            // 
            // whiteButton
            // 
            whiteButton.AutoSize = true;
            whiteButton.Location = new Point(70, 22);
            whiteButton.Name = "whiteButton";
            whiteButton.Size = new Size(43, 19);
            whiteButton.TabIndex = 3;
            whiteButton.TabStop = true;
            whiteButton.Text = "Alb";
            whiteButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(priceTextBox);
            groupBox2.Controls.Add(prestabilitButton);
            groupBox2.Controls.Add(personalizatButton);
            groupBox2.Location = new Point(184, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(220, 76);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Preț/kg";
            // 
            // priceTextBox
            // 
            priceTextBox.ForeColor = SystemColors.GrayText;
            priceTextBox.Location = new Point(6, 49);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(119, 23);
            priceTextBox.TabIndex = 17;
            priceTextBox.Text = "Pret personalizat";
            priceTextBox.Visible = false;
            priceTextBox.Enter += priceTextBox_Enter;
            priceTextBox.Leave += priceTextBox_Leave;
            // 
            // prestabilitButton
            // 
            prestabilitButton.AutoSize = true;
            prestabilitButton.Checked = true;
            prestabilitButton.Location = new Point(6, 22);
            prestabilitButton.Name = "prestabilitButton";
            prestabilitButton.Size = new Size(77, 19);
            prestabilitButton.TabIndex = 13;
            prestabilitButton.TabStop = true;
            prestabilitButton.Text = "Prestabilit";
            prestabilitButton.UseVisualStyleBackColor = true;
            // 
            // personalizatButton
            // 
            personalizatButton.AutoSize = true;
            personalizatButton.Location = new Point(89, 22);
            personalizatButton.Name = "personalizatButton";
            personalizatButton.Size = new Size(88, 19);
            personalizatButton.TabIndex = 14;
            personalizatButton.Text = "Personalizat";
            personalizatButton.UseVisualStyleBackColor = true;
            personalizatButton.CheckedChanged += personalizatButton_CheckedChanged;
            // 
            // baraButton
            // 
            baraButton.AutoSize = true;
            baraButton.Location = new Point(64, 16);
            baraButton.Name = "baraButton";
            baraButton.Size = new Size(48, 19);
            baraButton.TabIndex = 1;
            baraButton.Text = "Bara";
            baraButton.UseVisualStyleBackColor = true;
            baraButton.CheckedChanged += baraButton_CheckedChanged;
            // 
            // placaButton
            // 
            placaButton.AutoSize = true;
            placaButton.Checked = true;
            placaButton.Location = new Point(5, 16);
            placaButton.Name = "placaButton";
            placaButton.Size = new Size(53, 19);
            placaButton.TabIndex = 0;
            placaButton.TabStop = true;
            placaButton.Text = "Placa";
            placaButton.UseVisualStyleBackColor = true;
            placaButton.CheckedChanged += placaButton_CheckedChanged;
            // 
            // distribuitorBara
            // 
            distribuitorBara.AutoSize = true;
            distribuitorBara.Checked = true;
            distribuitorBara.Location = new Point(57, 22);
            distribuitorBara.Name = "distribuitorBara";
            distribuitorBara.Size = new Size(84, 19);
            distribuitorBara.TabIndex = 18;
            distribuitorBara.TabStop = true;
            distribuitorBara.Text = "Distribuitor";
            distribuitorBara.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 368);
            Controls.Add(groupBox3);
            Controls.Add(exitButton);
            Name = "Form1";
            Text = "Price Calculator by LZR";
            Load += Form1_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            baraPanel.ResumeLayout(false);
            baraPanel.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            placaPanel.ResumeLayout(false);
            placaPanel.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button exitButton;
        private RadioButton blackButton;
        private RadioButton whiteButton;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox latimeTextBox;
        private TextBox lungimeTextBox;
        private RadioButton personalizatButton;
        private RadioButton prestabilitButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox priceTextBox;
        private Label label2;
        private TextBox nrbucTextBox;
        private Button ButonPlaca;
        private Label label9;
        private Label label8;
        private TextBox euroTextBox;
        private Label label7;
        private TextBox ronTextBox;
        private GroupBox groupBox3;
        private RadioButton baraButton;
        private RadioButton placaButton;
        private Panel placaPanel;
        private Panel baraPanel;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox lungimePa6Box;
        private TextBox baraEUR;
        private Label label13;
        private Label label14;
        private TextBox baraRON;
        private Label label16;
        private Label label17;
        private TextBox nrbucPa6Box;
        private GroupBox groupBox4;
        private RadioButton negruBaraButton;
        private RadioButton albBaraButton;
        private GroupBox groupBox5;
        private TextBox pretpersonalizat;
        private RadioButton clientBara;
        private RadioButton personalizatBara;
        private Label label15;
        private ComboBox materialBox;
        private Button ButonBara;
        private RadioButton radioVerdeBara;
        private RadioButton radioUniversalBara;
        private RadioButton radioVerdePlaca;
        private RadioButton radioUniversalPlaca;
        private OpenFileDialog openFileDialog1;
        private Button databaseButton;
        private TextBox diamTextBox;
        private TextBox grosimeTextBox;
        private RadioButton distribuitorBara;
    }
}