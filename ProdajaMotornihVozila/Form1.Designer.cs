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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 533);
            Controls.Add(RadnjaProba);
            Controls.Add(UcitavanjeZaposlenog);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button UcitavanjeZaposlenog;
        private Button RadnjaProba;
    }
}
