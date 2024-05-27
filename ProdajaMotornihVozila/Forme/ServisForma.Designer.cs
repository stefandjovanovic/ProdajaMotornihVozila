namespace ProdajaMotornihVozila.Forme
{
    partial class ServisForma
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
            listaObavljenihServisa = new ListView();
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
            // listaObavljenihServisa
            // 
            listaObavljenihServisa.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listaObavljenihServisa.GridLines = true;
            listaObavljenihServisa.Location = new Point(6, 26);
            listaObavljenihServisa.Name = "listaObavljenihServisa";
            listaObavljenihServisa.Size = new Size(572, 447);
            listaObavljenihServisa.TabIndex = 0;
            listaObavljenihServisa.UseCompatibleStateImageBehavior = false;
            listaObavljenihServisa.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Model";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Registarski broj";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "MBR izvrsioca prijema";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Opis";
            columnHeader4.Width = 200;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaObavljenihServisa);
            groupBox1.Location = new Point(31, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(584, 479);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista obavljenih servisa";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnObrisi);
            groupBox2.Controls.Add(btnIzmeni);
            groupBox2.Controls.Add(btnDodaj);
            groupBox2.Controls.Add(btnInfo);
            groupBox2.Location = new Point(638, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(281, 311);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacije o obavljenom servisu";
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(49, 236);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(182, 46);
            btnObrisi.TabIndex = 3;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(49, 165);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(182, 46);
            btnIzmeni.TabIndex = 2;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(49, 99);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(182, 44);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Obavi novi servis";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnInfo
            // 
            btnInfo.Location = new Point(49, 35);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(182, 44);
            btnInfo.TabIndex = 0;
            btnInfo.Text = "Informacije";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // ServisForma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 519);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ServisForma";
            Text = "ServisForma";
            Load += ServisForma_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listaObavljenihServisa;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnDodaj;
        private Button btnInfo;
        private Button btnObrisi;
        private Button btnIzmeni;
    }
}