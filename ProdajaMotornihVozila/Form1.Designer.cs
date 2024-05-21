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
            UcitavanjeZaposlenog = new Button();
            RadnjaProba = new Button();
            btnZaposleni = new Button();
            btnPredstavnistva = new Button();
            btnVozila = new Button();
            btnServisi = new Button();
            btnProdaje = new Button();
            SuspendLayout();
            // 
            // UcitavanjeZaposlenog
            // 
            UcitavanjeZaposlenog.Location = new Point(171, 60);
            UcitavanjeZaposlenog.Name = "UcitavanjeZaposlenog";
            UcitavanjeZaposlenog.Size = new Size(171, 48);
            UcitavanjeZaposlenog.TabIndex = 0;
            UcitavanjeZaposlenog.Text = "Zaposleni proba";
            UcitavanjeZaposlenog.UseVisualStyleBackColor = true;
            UcitavanjeZaposlenog.Click += UcitavanjeZaposlenog_Click;
            // 
            // RadnjaProba
            // 
            RadnjaProba.Location = new Point(176, 147);
            RadnjaProba.Name = "RadnjaProba";
            RadnjaProba.Size = new Size(161, 50);
            RadnjaProba.TabIndex = 1;
            RadnjaProba.Text = "Radnja proba";
            RadnjaProba.UseVisualStyleBackColor = true;
            RadnjaProba.Click += RadnjaProba_Click;
            // 
            // btnZaposleni
            // 
            btnZaposleni.Location = new Point(711, 31);
            btnZaposleni.Name = "btnZaposleni";
            btnZaposleni.Size = new Size(163, 43);
            btnZaposleni.TabIndex = 2;
            btnZaposleni.Text = "Zaposleni";
            btnZaposleni.UseVisualStyleBackColor = true;
            btnZaposleni.Click += btnZaposleni_Click;
            // 
            // btnPredstavnistva
            // 
            btnPredstavnistva.Location = new Point(711, 99);
            btnPredstavnistva.Name = "btnPredstavnistva";
            btnPredstavnistva.Size = new Size(163, 43);
            btnPredstavnistva.TabIndex = 3;
            btnPredstavnistva.Text = "Predstavnistva";
            btnPredstavnistva.UseVisualStyleBackColor = true;
            btnPredstavnistva.Click += btnPredstavnistva_Click;
            // 
            // btnVozila
            // 
            btnVozila.Location = new Point(711, 168);
            btnVozila.Name = "btnVozila";
            btnVozila.Size = new Size(163, 43);
            btnVozila.TabIndex = 4;
            btnVozila.Text = "Vozila";
            btnVozila.UseVisualStyleBackColor = true;
            btnVozila.Click += btnVozila_Click;
            // 
            // btnServisi
            // 
            btnServisi.Location = new Point(711, 233);
            btnServisi.Name = "btnServisi";
            btnServisi.Size = new Size(163, 43);
            btnServisi.TabIndex = 5;
            btnServisi.Text = "Obavljeni servisi";
            btnServisi.UseVisualStyleBackColor = true;
            btnServisi.Click += btnServisi_Click;
            // 
            // btnProdaje
            // 
            btnProdaje.Location = new Point(711, 301);
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
            ClientSize = new Size(1240, 533);
            Controls.Add(btnProdaje);
            Controls.Add(btnServisi);
            Controls.Add(btnVozila);
            Controls.Add(btnPredstavnistva);
            Controls.Add(btnZaposleni);
            Controls.Add(RadnjaProba);
            Controls.Add(UcitavanjeZaposlenog);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button UcitavanjeZaposlenog;
        private Button RadnjaProba;
        private Button btnZaposleni;
        private Button btnPredstavnistva;
        private Button btnVozila;
        private Button btnServisi;
        private Button btnProdaje;
    }
}
