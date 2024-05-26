namespace ProdajaMotornihVozila
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
            btnZaposleni = new Button();
            btnPredstavnistva = new Button();
            btnVozila = new Button();
            btnServisi = new Button();
            btnProdaje = new Button();
            SuspendLayout();
            // 
            // btnZaposleni
            // 
            btnZaposleni.Location = new Point(341, 78);
            btnZaposleni.Name = "btnZaposleni";
            btnZaposleni.Size = new Size(163, 43);
            btnZaposleni.TabIndex = 2;
            btnZaposleni.Text = "Zaposleni";
            btnZaposleni.UseVisualStyleBackColor = true;
            btnZaposleni.Click += btnZaposleni_Click;
            // 
            // btnPredstavnistva
            // 
            btnPredstavnistva.Location = new Point(341, 146);
            btnPredstavnistva.Name = "btnPredstavnistva";
            btnPredstavnistva.Size = new Size(163, 43);
            btnPredstavnistva.TabIndex = 3;
            btnPredstavnistva.Text = "Predstavnistva";
            btnPredstavnistva.UseVisualStyleBackColor = true;
            btnPredstavnistva.Click += btnPredstavnistva_Click;
            // 
            // btnVozila
            // 
            btnVozila.Location = new Point(341, 215);
            btnVozila.Name = "btnVozila";
            btnVozila.Size = new Size(163, 43);
            btnVozila.TabIndex = 4;
            btnVozila.Text = "Vozila";
            btnVozila.UseVisualStyleBackColor = true;
            btnVozila.Click += btnVozila_Click;
            // 
            // btnServisi
            // 
            btnServisi.Location = new Point(341, 280);
            btnServisi.Name = "btnServisi";
            btnServisi.Size = new Size(163, 43);
            btnServisi.TabIndex = 5;
            btnServisi.Text = "Obavljeni servisi";
            btnServisi.UseVisualStyleBackColor = true;
            btnServisi.Click += btnServisi_Click;
            // 
            // btnProdaje
            // 
            btnProdaje.Location = new Point(341, 348);
            btnProdaje.Name = "btnProdaje";
            btnProdaje.Size = new Size(163, 43);
            btnProdaje.TabIndex = 6;
            btnProdaje.Text = "Obavljene prodaje";
            btnProdaje.UseVisualStyleBackColor = true;
            btnProdaje.Click += btnProdaje_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 533);
            Controls.Add(btnProdaje);
            Controls.Add(btnServisi);
            Controls.Add(btnVozila);
            Controls.Add(btnPredstavnistva);
            Controls.Add(btnZaposleni);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button btnZaposleni;
        private Button btnPredstavnistva;
        private Button btnVozila;
        private Button btnServisi;
        private Button btnProdaje;
    }
}
