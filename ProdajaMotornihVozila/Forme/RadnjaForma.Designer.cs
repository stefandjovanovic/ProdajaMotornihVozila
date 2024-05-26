namespace ProdajaMotornihVozila.Forme
{
    partial class RadnjaForma
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
            labelSef = new Label();
            btnPrikaziZaposlene = new Button();
            labelServis = new Label();
            labelSalon = new Label();
            btnPrikaziServis = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelSef
            // 
            labelSef.AutoSize = true;
            labelSef.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSef.Location = new Point(58, 40);
            labelSef.Name = "labelSef";
            labelSef.Size = new Size(127, 31);
            labelSef.TabIndex = 0;
            labelSef.Text = "Sef radnje: ";
            // 
            // btnPrikaziZaposlene
            // 
            btnPrikaziZaposlene.Location = new Point(58, 187);
            btnPrikaziZaposlene.Name = "btnPrikaziZaposlene";
            btnPrikaziZaposlene.Size = new Size(190, 43);
            btnPrikaziZaposlene.TabIndex = 1;
            btnPrikaziZaposlene.Text = "Prikazi zaposlene";
            btnPrikaziZaposlene.UseVisualStyleBackColor = true;
            btnPrikaziZaposlene.Click += btnPrikaziZaposlene_Click;
            // 
            // labelServis
            // 
            labelServis.AutoSize = true;
            labelServis.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelServis.Location = new Point(58, 96);
            labelServis.Name = "labelServis";
            labelServis.Size = new Size(174, 31);
            labelServis.TabIndex = 2;
            labelServis.Text = "Poseduje servis:";
            // 
            // labelSalon
            // 
            labelSalon.AutoSize = true;
            labelSalon.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSalon.Location = new Point(58, 143);
            labelSalon.Name = "labelSalon";
            labelSalon.Size = new Size(177, 31);
            labelSalon.TabIndex = 3;
            labelSalon.Text = "Poseduje salon: ";
            // 
            // btnPrikaziServis
            // 
            btnPrikaziServis.Location = new Point(58, 249);
            btnPrikaziServis.Name = "btnPrikaziServis";
            btnPrikaziServis.Size = new Size(190, 44);
            btnPrikaziServis.TabIndex = 4;
            btnPrikaziServis.Text = "Prikazi detalje o servisu";
            btnPrikaziServis.UseVisualStyleBackColor = true;
            btnPrikaziServis.Click += btnPrikaziServis_Click;
            // 
            // button1
            // 
            button1.Location = new Point(301, 249);
            button1.Name = "button1";
            button1.Size = new Size(175, 44);
            button1.TabIndex = 5;
            button1.Text = "Izmeni Radnju";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RadnjaForma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 319);
            Controls.Add(button1);
            Controls.Add(btnPrikaziServis);
            Controls.Add(labelSalon);
            Controls.Add(labelServis);
            Controls.Add(btnPrikaziZaposlene);
            Controls.Add(labelSef);
            Name = "RadnjaForma";
            Text = "RadnjaForma";
            Load += RadnjaForma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSef;
        private Button btnPrikaziZaposlene;
        private Label labelServis;
        private Label labelSalon;
        private Button btnPrikaziServis;
        private Button button1;
    }
}