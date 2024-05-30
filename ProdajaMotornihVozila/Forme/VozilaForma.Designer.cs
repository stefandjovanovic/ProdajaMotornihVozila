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
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
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
            listaVozila.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listaVozila.FullRowSelect = true;
            listaVozila.GridLines = true;
            listaVozila.Location = new Point(5, 27);
            listaVozila.Name = "listaVozila";
            listaVozila.Size = new Size(814, 195);
            listaVozila.TabIndex = 0;
            listaVozila.UseCompatibleStateImageBehavior = false;
            listaVozila.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Broj sasije";
            columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Boja";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Model";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tip goriva";
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Kubikaza";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Broj motora";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Vlasnistvo";
            columnHeader7.Width = 120;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaVozila);
            groupBox1.Location = new Point(63, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(825, 228);
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
            groupBox2.Location = new Point(120, 305);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(661, 276);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Upravljanje vozilima";
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(218, 208);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(227, 37);
            btnObrisi.TabIndex = 6;
            btnObrisi.Text = "Obrisi vozilo";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnInfo
            // 
            btnInfo.Location = new Point(218, 27);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(227, 37);
            btnInfo.TabIndex = 3;
            btnInfo.Text = "Osnovne informacije";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(218, 147);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(227, 37);
            btnIzmeni.TabIndex = 5;
            btnIzmeni.Text = "Izmeni informacije";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(218, 85);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(227, 37);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj vozilo";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // VozilaForma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 623);
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
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}