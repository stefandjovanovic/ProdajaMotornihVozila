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
            SuspendLayout();
            // 
            // UcitavanjeZaposlenog
            // 
            UcitavanjeZaposlenog.Location = new Point(171, 60);
            UcitavanjeZaposlenog.Name = "UcitavanjeZaposlenog";
            UcitavanjeZaposlenog.Size = new Size(171, 48);
            UcitavanjeZaposlenog.TabIndex = 0;
            UcitavanjeZaposlenog.Text = "Ucitavanje zaposlenog";
            UcitavanjeZaposlenog.UseVisualStyleBackColor = true;
            UcitavanjeZaposlenog.Click += UcitavanjeZaposlenog_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 533);
            Controls.Add(UcitavanjeZaposlenog);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button UcitavanjeZaposlenog;
    }
}
