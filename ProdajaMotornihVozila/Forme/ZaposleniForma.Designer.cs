namespace ProdajaMotornihVozila.Forme
{
    partial class ZaposleniForma
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
            listaZaposlenih = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            btnDetalji = new Button();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            btnPrikaziRkv = new Button();
            btnPostaviRkv = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnPodredjeni = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // listaZaposlenih
            // 
            listaZaposlenih.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listaZaposlenih.Dock = DockStyle.Fill;
            listaZaposlenih.FullRowSelect = true;
            listaZaposlenih.GridLines = true;
            listaZaposlenih.Location = new Point(3, 23);
            listaZaposlenih.Name = "listaZaposlenih";
            listaZaposlenih.Size = new Size(795, 572);
            listaZaposlenih.TabIndex = 0;
            listaZaposlenih.UseCompatibleStateImageBehavior = false;
            listaZaposlenih.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "JMBG";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ime";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Prezime";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Strucna sprema";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tip zaposlenja";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Struka";
            columnHeader6.Width = 120;
            // 
            // btnDetalji
            // 
            btnDetalji.Location = new Point(50, 18);
            btnDetalji.Name = "btnDetalji";
            btnDetalji.Size = new Size(155, 42);
            btnDetalji.TabIndex = 1;
            btnDetalji.Text = "Detalji";
            btnDetalji.UseVisualStyleBackColor = true;
            btnDetalji.Click += btnDetalji_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(50, 83);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(155, 42);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(50, 153);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(155, 42);
            btnIzmeni.TabIndex = 3;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(50, 214);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(155, 42);
            btnObrisi.TabIndex = 4;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnPrikaziRkv
            // 
            btnPrikaziRkv.Location = new Point(50, 17);
            btnPrikaziRkv.Name = "btnPrikaziRkv";
            btnPrikaziRkv.Size = new Size(155, 42);
            btnPrikaziRkv.TabIndex = 5;
            btnPrikaziRkv.Text = "Prikazi rukovodioca";
            btnPrikaziRkv.UseVisualStyleBackColor = true;
            // 
            // btnPostaviRkv
            // 
            btnPostaviRkv.Location = new Point(50, 83);
            btnPostaviRkv.Name = "btnPostaviRkv";
            btnPostaviRkv.Size = new Size(155, 42);
            btnPostaviRkv.TabIndex = 6;
            btnPostaviRkv.Text = "Postavi rukovodioca";
            btnPostaviRkv.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnObrisi);
            groupBox1.Controls.Add(btnIzmeni);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(btnDetalji);
            groupBox1.Location = new Point(842, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(263, 274);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci o zaposlenom";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listaZaposlenih);
            groupBox2.Location = new Point(12, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(801, 598);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista zaposlenih";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnPodredjeni);
            groupBox3.Controls.Add(btnPostaviRkv);
            groupBox3.Controls.Add(btnPrikaziRkv);
            groupBox3.Location = new Point(842, 370);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(265, 200);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Podaci o rukovodiocu";
            // 
            // btnPodredjeni
            // 
            btnPodredjeni.Location = new Point(50, 141);
            btnPodredjeni.Name = "btnPodredjeni";
            btnPodredjeni.Size = new Size(155, 42);
            btnPodredjeni.TabIndex = 7;
            btnPodredjeni.Text = "Prikazi podredjene";
            btnPodredjeni.UseVisualStyleBackColor = true;
            // 
            // ZaposleniForma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 661);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ZaposleniForma";
            Text = "ZaposleniForma";
            Load += ZaposleniForma_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listaZaposlenih;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button btnDetalji;
        private Button btnDodaj;
        private Button btnIzmeni;
        private Button btnObrisi;
        private ColumnHeader columnHeader6;
        private Button btnPrikaziRkv;
        private Button btnPostaviRkv;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnPodredjeni;
    }
}