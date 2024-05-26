namespace ProdajaMotornihVozila.Forme.PredstavnistvoForme
{
    partial class DodajPredstavnistvoForma
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
            btnDodaj = new Button();
            button1 = new Button();
            textBoxGrad = new TextBox();
            textBoxAdresa = new TextBox();
            textBoxJMBG = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 64);
            label1.Name = "label1";
            label1.Size = new Size(59, 28);
            label1.TabIndex = 0;
            label1.Text = "Grad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 145);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 1;
            label2.Text = "Adresa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(85, 215);
            label3.Name = "label3";
            label3.Size = new Size(203, 28);
            label3.TabIndex = 2;
            label3.Text = "Maticni broj direktora";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(402, 301);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(111, 35);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // button1
            // 
            button1.Location = new Point(234, 301);
            button1.Name = "button1";
            button1.Size = new Size(111, 35);
            button1.TabIndex = 4;
            button1.Text = "Odustani";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxGrad
            // 
            textBoxGrad.Location = new Point(379, 68);
            textBoxGrad.Name = "textBoxGrad";
            textBoxGrad.Size = new Size(181, 27);
            textBoxGrad.TabIndex = 5;
            // 
            // textBoxAdresa
            // 
            textBoxAdresa.Location = new Point(379, 149);
            textBoxAdresa.Name = "textBoxAdresa";
            textBoxAdresa.Size = new Size(181, 27);
            textBoxAdresa.TabIndex = 6;
            // 
            // textBoxJMBG
            // 
            textBoxJMBG.Location = new Point(379, 219);
            textBoxJMBG.Name = "textBoxJMBG";
            textBoxJMBG.Size = new Size(181, 27);
            textBoxJMBG.TabIndex = 7;
            // 
            // DodajPredstavnistvoForma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 444);
            Controls.Add(textBoxJMBG);
            Controls.Add(textBoxAdresa);
            Controls.Add(textBoxGrad);
            Controls.Add(button1);
            Controls.Add(btnDodaj);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DodajPredstavnistvoForma";
            Text = "DodajPredstavnistvoForma";
            Load += DodajPredstavnistvoForma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnDodaj;
        private Button button1;
        private TextBox textBoxGrad;
        private TextBox textBoxAdresa;
        private TextBox textBoxJMBG;
    }
}