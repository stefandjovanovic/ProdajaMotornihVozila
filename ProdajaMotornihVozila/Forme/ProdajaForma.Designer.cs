namespace ProdajaMotornihVozila.Forme
{
    partial class ProdajaForma
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnObrisi = new Button();
            btnIzmeni = new Button();
            btnDodaj = new Button();
            btnInfo = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(5, 20);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(409, 240);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "JMBG zaposlenog";
            columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Broj sasije";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ID salona prodaje";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "ID Kupca";
            columnHeader4.Width = 80;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(24, 28);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(423, 266);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista obavljenih prodaja";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnObrisi);
            groupBox2.Controls.Add(btnIzmeni);
            groupBox2.Controls.Add(btnDodaj);
            groupBox2.Controls.Add(btnInfo);
            groupBox2.Location = new Point(515, 28);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(254, 266);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Upravljaj informacijama";
            // 
            // btnObrisi
            // 
            btnObrisi.Font = new Font("Segoe UI", 9F);
            btnObrisi.Location = new Point(46, 214);
            btnObrisi.Margin = new Padding(3, 2, 3, 2);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(163, 40);
            btnObrisi.TabIndex = 3;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Font = new Font("Segoe UI", 9F);
            btnIzmeni.Location = new Point(46, 158);
            btnIzmeni.Margin = new Padding(3, 2, 3, 2);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(163, 40);
            btnIzmeni.TabIndex = 2;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(46, 101);
            btnDodaj.Margin = new Padding(3, 2, 3, 2);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(163, 38);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Obavi prodaju";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnInfo
            // 
            btnInfo.Location = new Point(46, 38);
            btnInfo.Margin = new Padding(3, 2, 3, 2);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(163, 38);
            btnInfo.TabIndex = 0;
            btnInfo.Text = "Informacije";
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // ProdajaForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 361);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProdajaForma";
            Text = "ProdajaForma";
            Load += ProdajaForma_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnDodaj;
        private Button btnInfo;
        private Button btnObrisi;
        private Button btnIzmeni;
    }
}