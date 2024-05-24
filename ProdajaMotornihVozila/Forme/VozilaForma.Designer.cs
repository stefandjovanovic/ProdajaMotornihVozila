namespace ProdajaMotornihVozila.Forme
{
    partial class VozilaForma
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
            listaVozila = new ListView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnObrisi = new Button();
            btnInfo = new Button();
            btnIzmeni = new Button();
            btnDodaj = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listaVozila
            // 
            listaVozila.Location = new Point(5, 27);
            listaVozila.Name = "listaVozila";
            listaVozila.Size = new Size(821, 195);
            listaVozila.TabIndex = 0;
            listaVozila.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaVozila);
            groupBox1.Location = new Point(63, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(832, 228);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista vozila";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnObrisi);
            groupBox2.Controls.Add(btnInfo);
            groupBox2.Controls.Add(btnIzmeni);
            groupBox2.Controls.Add(btnDodaj);
            groupBox2.Location = new Point(68, 284);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(331, 276);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Upravljanje vozilima";
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(51, 221);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(227, 38);
            btnObrisi.TabIndex = 6;
            btnObrisi.Text = "Obrisi vozilo";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnInfo
            // 
            btnInfo.Location = new Point(51, 39);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(227, 38);
            btnInfo.TabIndex = 3;
            btnInfo.Text = "Osnovne informacije";
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(51, 160);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(227, 38);
            btnIzmeni.TabIndex = 5;
            btnIzmeni.Text = "Izmeni informacije";
            btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(51, 98);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(227, 38);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj vozilo";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // VozilaForma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 593);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "VozilaForma";
            Text = "VozilaForma";
            Load += VozilaForma_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listaVozila;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnDodaj;
        private Button btnInfo;
        private Button btnObrisi;
        private Button btnIzmeni;
    }
}