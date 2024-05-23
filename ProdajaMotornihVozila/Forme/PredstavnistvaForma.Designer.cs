namespace ProdajaMotornihVozila.Forme
{
    partial class PredstavnistvaForma
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
            btnDodaj = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(34, 48);
            listView1.Name = "listView1";
            listView1.Size = new Size(522, 372);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Grad";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Adresa";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ime i Prezime Direktora";
            columnHeader4.Width = 200;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(691, 48);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(164, 40);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj Predstavnistvo";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(691, 244);
            button1.Name = "button1";
            button1.Size = new Size(164, 40);
            button1.TabIndex = 2;
            button1.Text = "Prikazi sadrzaj";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(691, 109);
            button2.Name = "button2";
            button2.Size = new Size(164, 40);
            button2.TabIndex = 3;
            button2.Text = "Izmeni Predstavnistvo";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(691, 177);
            button3.Name = "button3";
            button3.Size = new Size(164, 40);
            button3.TabIndex = 4;
            button3.Text = "Obrisi Predstavnistvo";
            button3.UseVisualStyleBackColor = true;
            // 
            // PredstavnistvaForma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 533);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnDodaj);
            Controls.Add(listView1);
            Name = "PredstavnistvaForma";
            Text = "PredstavnistvaForma";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnDodaj;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}