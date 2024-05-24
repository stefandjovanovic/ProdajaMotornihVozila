namespace ProdajaMotornihVozila.Forme.VozilaForme
{
    partial class DodajVoziloForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Model = new Label();
            Boja = new Label();
            Gorivo = new Label();
            Kubikaza = new Label();
            BrMotora = new Label();
            BrSasije = new Label();
            textBoxModel = new TextBox();
            textBoxBoja = new TextBox();
            textBoxBrMotora = new TextBox();
            textBoxBrSasije = new TextBox();
            numericUpDownKubikaza = new NumericUpDown();
            comboBoxTipGoriva = new ComboBox();
            Info = new GroupBox();
            groupBoxEnd = new GroupBox();
            btnDodaj = new Button();
            btnOdustani = new Button();
            TipVozila = new Label();
            BrPutnika = new Label();
            Nosivost = new Label();
            TeretniProstor = new Label();
            comboBoxTipVozila = new ComboBox();
            textBoxBrPutnika = new TextBox();
            textBoxNosivost = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKubikaza).BeginInit();
            Info.SuspendLayout();
            groupBoxEnd.SuspendLayout();
            SuspendLayout();
            // 
            // Model
            // 
            Model.AutoSize = true;
            Model.Font = new Font("Segoe UI", 12F);
            Model.Location = new Point(37, 33);
            Model.Name = "Model";
            Model.Size = new Size(129, 28);
            Model.TabIndex = 0;
            Model.Text = "Model vozila:";
            // 
            // Boja
            // 
            Boja.AutoSize = true;
            Boja.Font = new Font("Segoe UI", 12F);
            Boja.Location = new Point(56, 105);
            Boja.Name = "Boja";
            Boja.Size = new Size(110, 28);
            Boja.TabIndex = 1;
            Boja.Text = "Boja vozila:";
            // 
            // Gorivo
            // 
            Gorivo.AutoSize = true;
            Gorivo.Font = new Font("Segoe UI", 12F);
            Gorivo.Location = new Point(62, 175);
            Gorivo.Name = "Gorivo";
            Gorivo.Size = new Size(104, 28);
            Gorivo.TabIndex = 2;
            Gorivo.Text = "Tip goriva:";
            // 
            // Kubikaza
            // 
            Kubikaza.AutoSize = true;
            Kubikaza.Font = new Font("Segoe UI", 12F);
            Kubikaza.Location = new Point(1, 239);
            Kubikaza.Name = "Kubikaza";
            Kubikaza.Size = new Size(165, 28);
            Kubikaza.TabIndex = 3;
            Kubikaza.Text = "Kubikaza motora:";
            // 
            // BrMotora
            // 
            BrMotora.AutoSize = true;
            BrMotora.Font = new Font("Segoe UI", 12F);
            BrMotora.Location = new Point(45, 304);
            BrMotora.Name = "BrMotora";
            BrMotora.Size = new Size(121, 28);
            BrMotora.TabIndex = 4;
            BrMotora.Text = "Broj motora:";
            // 
            // BrSasije
            // 
            BrSasije.AutoSize = true;
            BrSasije.Font = new Font("Segoe UI", 12F);
            BrSasije.Location = new Point(64, 372);
            BrSasije.Name = "BrSasije";
            BrSasije.Size = new Size(102, 28);
            BrSasije.TabIndex = 5;
            BrSasije.Text = "Broj sasije:";
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(190, 34);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(186, 27);
            textBoxModel.TabIndex = 6;
            // 
            // textBoxBoja
            // 
            textBoxBoja.Location = new Point(190, 106);
            textBoxBoja.Name = "textBoxBoja";
            textBoxBoja.Size = new Size(186, 27);
            textBoxBoja.TabIndex = 7;
            // 
            // textBoxBrMotora
            // 
            textBoxBrMotora.Location = new Point(190, 305);
            textBoxBrMotora.Name = "textBoxBrMotora";
            textBoxBrMotora.Size = new Size(186, 27);
            textBoxBrMotora.TabIndex = 10;
            // 
            // textBoxBrSasije
            // 
            textBoxBrSasije.Location = new Point(190, 373);
            textBoxBrSasije.Name = "textBoxBrSasije";
            textBoxBrSasije.Size = new Size(186, 27);
            textBoxBrSasije.TabIndex = 11;
            // 
            // numericUpDownKubikaza
            // 
            numericUpDownKubikaza.Font = new Font("Segoe UI", 10F);
            numericUpDownKubikaza.Location = new Point(190, 237);
            numericUpDownKubikaza.Name = "numericUpDownKubikaza";
            numericUpDownKubikaza.Size = new Size(186, 30);
            numericUpDownKubikaza.TabIndex = 12;
            // 
            // comboBoxTipGoriva
            // 
            comboBoxTipGoriva.FormattingEnabled = true;
            comboBoxTipGoriva.Location = new Point(190, 175);
            comboBoxTipGoriva.Name = "comboBoxTipGoriva";
            comboBoxTipGoriva.Size = new Size(186, 28);
            comboBoxTipGoriva.TabIndex = 13;
            // 
            // Info
            // 
            Info.Controls.Add(Model);
            Info.Controls.Add(comboBoxTipGoriva);
            Info.Controls.Add(Boja);
            Info.Controls.Add(numericUpDownKubikaza);
            Info.Controls.Add(Gorivo);
            Info.Controls.Add(textBoxBrSasije);
            Info.Controls.Add(Kubikaza);
            Info.Controls.Add(textBoxBrMotora);
            Info.Controls.Add(BrMotora);
            Info.Controls.Add(textBoxBoja);
            Info.Controls.Add(BrSasije);
            Info.Controls.Add(textBoxModel);
            Info.Location = new Point(12, 12);
            Info.Name = "Info";
            Info.Size = new Size(392, 426);
            Info.TabIndex = 14;
            Info.TabStop = false;
            Info.Text = "Osnovne informacije o vozilu";
            // 
            // groupBoxEnd
            // 
            groupBoxEnd.Controls.Add(btnDodaj);
            groupBoxEnd.Controls.Add(btnOdustani);
            groupBoxEnd.Location = new Point(485, 366);
            groupBoxEnd.Name = "groupBoxEnd";
            groupBoxEnd.Size = new Size(468, 72);
            groupBoxEnd.TabIndex = 15;
            groupBoxEnd.TabStop = false;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(243, 19);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(219, 44);
            btnDodaj.TabIndex = 17;
            btnDodaj.Text = "Dodaj vozilo";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(6, 18);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(165, 44);
            btnOdustani.TabIndex = 16;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            // 
            // TipVozila
            // 
            TipVozila.AutoSize = true;
            TipVozila.Font = new Font("Segoe UI", 12F);
            TipVozila.Location = new Point(620, 45);
            TipVozila.Name = "TipVozila";
            TipVozila.Size = new Size(99, 28);
            TipVozila.TabIndex = 16;
            TipVozila.Text = "Tip vozila:";
            // 
            // BrPutnika
            // 
            BrPutnika.AutoSize = true;
            BrPutnika.Font = new Font("Segoe UI", 12F);
            BrPutnika.Location = new Point(597, 117);
            BrPutnika.Name = "BrPutnika";
            BrPutnika.Size = new Size(122, 28);
            BrPutnika.TabIndex = 17;
            BrPutnika.Text = "Broj putnika:";
            // 
            // Nosivost
            // 
            Nosivost.AutoSize = true;
            Nosivost.Font = new Font("Segoe UI", 12F);
            Nosivost.Location = new Point(626, 190);
            Nosivost.Name = "Nosivost";
            Nosivost.Size = new Size(93, 28);
            Nosivost.TabIndex = 18;
            Nosivost.Text = "Nosivost:";
            // 
            // TeretniProstor
            // 
            TeretniProstor.AutoSize = true;
            TeretniProstor.Font = new Font("Segoe UI", 12F);
            TeretniProstor.Location = new Point(438, 258);
            TeretniProstor.Name = "TeretniProstor";
            TeretniProstor.Size = new Size(281, 28);
            TeretniProstor.TabIndex = 19;
            TeretniProstor.Text = "Teretni prostor otvorenog tipa:";
            // 
            // comboBoxTipVozila
            // 
            comboBoxTipVozila.FormattingEnabled = true;
            comboBoxTipVozila.Location = new Point(764, 45);
            comboBoxTipVozila.Name = "comboBoxTipVozila";
            comboBoxTipVozila.Size = new Size(183, 28);
            comboBoxTipVozila.TabIndex = 20;
            // 
            // textBoxBrPutnika
            // 
            textBoxBrPutnika.Location = new Point(764, 121);
            textBoxBrPutnika.Name = "textBoxBrPutnika";
            textBoxBrPutnika.Size = new Size(183, 27);
            textBoxBrPutnika.TabIndex = 21;
            // 
            // textBoxNosivost
            // 
            textBoxNosivost.Location = new Point(764, 191);
            textBoxNosivost.Name = "textBoxNosivost";
            textBoxNosivost.Size = new Size(183, 27);
            textBoxNosivost.TabIndex = 22;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(764, 258);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 28);
            comboBox1.TabIndex = 23;
            // 
            // DodajVoziloForma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 450);
            Controls.Add(comboBox1);
            Controls.Add(textBoxNosivost);
            Controls.Add(textBoxBrPutnika);
            Controls.Add(comboBoxTipVozila);
            Controls.Add(TeretniProstor);
            Controls.Add(Nosivost);
            Controls.Add(BrPutnika);
            Controls.Add(TipVozila);
            Controls.Add(groupBoxEnd);
            Controls.Add(Info);
            Name = "DodajVoziloForma";
            Text = "DodajVoziloForma";
            ((System.ComponentModel.ISupportInitialize)numericUpDownKubikaza).EndInit();
            Info.ResumeLayout(false);
            Info.PerformLayout();
            groupBoxEnd.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Model;
        private Label Boja;
        private Label Gorivo;
        private Label Kubikaza;
        private Label BrMotora;
        private Label BrSasije;
        private TextBox textBoxModel;
        private TextBox textBoxBoja;
        private TextBox textBoxBrMotora;
        private TextBox textBoxBrSasije;
        private NumericUpDown numericUpDownKubikaza;
        private ComboBox comboBoxTipGoriva;
        private GroupBox Info;
        private GroupBox groupBoxEnd;
        private Button btnOdustani;
        private Button btnDodaj;
        private Label TipVozila;
        private Label BrPutnika;
        private Label Nosivost;
        private Label TeretniProstor;
        private ComboBox comboBoxTipVozila;
        private TextBox textBoxBrPutnika;
        private TextBox textBoxNosivost;
        private ComboBox comboBox1;
    }
}