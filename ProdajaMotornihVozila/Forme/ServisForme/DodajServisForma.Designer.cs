namespace ProdajaMotornihVozila.Forme.ServisForme
{
    partial class DodajServisForma
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxMBRIzvrsioca = new TextBox();
            textBoxIDServisa = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            groupBox1 = new GroupBox();
            btnDodaj = new Button();
            btnOdustani = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBoxBrSasije = new TextBox();
            textBoxRegistarskiBr = new TextBox();
            textBoxModel = new TextBox();
            textBoxGodProizv = new TextBox();
            textBoxOpis = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(81, 26);
            label1.Name = "label1";
            label1.Size = new Size(202, 28);
            label1.TabIndex = 0;
            label1.Text = "Datum prijema vozila:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(59, 95);
            label2.Name = "label2";
            label2.Size = new Size(224, 28);
            label2.TabIndex = 1;
            label2.Text = "Datum zavrsetka servisa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(19, 168);
            label3.Name = "label3";
            label3.Size = new Size(264, 28);
            label3.TabIndex = 2;
            label3.Text = "MBR izvrsioca prijema vozila:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(15, 244);
            label4.Name = "label4";
            label4.Size = new Size(268, 28);
            label4.TabIndex = 3;
            label4.Text = "ID servisa u kome je obavljen:";
            // 
            // textBoxMBRIzvrsioca
            // 
            textBoxMBRIzvrsioca.Location = new Point(317, 172);
            textBoxMBRIzvrsioca.Name = "textBoxMBRIzvrsioca";
            textBoxMBRIzvrsioca.Size = new Size(250, 27);
            textBoxMBRIzvrsioca.TabIndex = 4;
            // 
            // textBoxIDServisa
            // 
            textBoxIDServisa.Location = new Point(317, 245);
            textBoxIDServisa.Name = "textBoxIDServisa";
            textBoxIDServisa.Size = new Size(250, 27);
            textBoxIDServisa.TabIndex = 5;
            textBoxIDServisa.TextChanged += textBox2_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(317, 28);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(317, 96);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(btnOdustani);
            groupBox1.Location = new Point(19, 324);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(548, 88);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // btnDodaj
            // 
            btnDodaj.Font = new Font("Segoe UI", 12F);
            btnDodaj.Location = new Point(347, 27);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(177, 44);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            btnOdustani.Font = new Font("Segoe UI", 12F);
            btnOdustani.Location = new Point(23, 27);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(177, 44);
            btnOdustani.TabIndex = 0;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(636, 28);
            label5.Name = "label5";
            label5.Size = new Size(158, 28);
            label5.TabIndex = 9;
            label5.Text = "Broj sasije vozila:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(644, 96);
            label6.Name = "label6";
            label6.Size = new Size(150, 28);
            label6.TabIndex = 10;
            label6.Text = "Registarski broj:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(665, 170);
            label7.Name = "label7";
            label7.Size = new Size(129, 28);
            label7.TabIndex = 11;
            label7.Text = "Model vozila:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(604, 243);
            label8.Name = "label8";
            label8.Size = new Size(190, 28);
            label8.TabIndex = 12;
            label8.Text = "Godina proizvodnje:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(738, 323);
            label9.Name = "label9";
            label9.Size = new Size(56, 28);
            label9.TabIndex = 13;
            label9.Text = "Opis:";
            // 
            // textBoxBrSasije
            // 
            textBoxBrSasije.Location = new Point(830, 30);
            textBoxBrSasije.Name = "textBoxBrSasije";
            textBoxBrSasije.Size = new Size(266, 27);
            textBoxBrSasije.TabIndex = 14;
            textBoxBrSasije.TextChanged += textBox1_TextChanged;
            // 
            // textBoxRegistarskiBr
            // 
            textBoxRegistarskiBr.Location = new Point(830, 97);
            textBoxRegistarskiBr.Name = "textBoxRegistarskiBr";
            textBoxRegistarskiBr.Size = new Size(266, 27);
            textBoxRegistarskiBr.TabIndex = 15;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(830, 171);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(266, 27);
            textBoxModel.TabIndex = 16;
            // 
            // textBoxGodProizv
            // 
            textBoxGodProizv.Location = new Point(830, 244);
            textBoxGodProizv.Name = "textBoxGodProizv";
            textBoxGodProizv.Size = new Size(266, 27);
            textBoxGodProizv.TabIndex = 17;
            // 
            // textBoxOpis
            // 
            textBoxOpis.Location = new Point(830, 324);
            textBoxOpis.Name = "textBoxOpis";
            textBoxOpis.Size = new Size(266, 27);
            textBoxOpis.TabIndex = 18;
            // 
            // DodajServisForma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 450);
            Controls.Add(textBoxOpis);
            Controls.Add(textBoxGodProizv);
            Controls.Add(textBoxModel);
            Controls.Add(textBoxRegistarskiBr);
            Controls.Add(textBoxBrSasije);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxIDServisa);
            Controls.Add(textBoxMBRIzvrsioca);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DodajServisForma";
            Text = "DodajServisForma";
            Load += DodajServisForma_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxMBRIzvrsioca;
        private TextBox textBoxIDServisa;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private GroupBox groupBox1;
        private Button btnDodaj;
        private Button btnOdustani;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxBrSasije;
        private TextBox textBoxRegistarskiBr;
        private TextBox textBoxModel;
        private TextBox textBoxGodProizv;
        private TextBox textBoxOpis;
    }
}