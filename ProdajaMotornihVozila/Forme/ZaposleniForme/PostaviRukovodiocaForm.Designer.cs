﻿namespace ProdajaMotornihVozila.Forme.ZaposleniForme
{
    partial class PostaviRukovodiocaForm
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
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 116);
            label1.Name = "label1";
            label1.Size = new Size(574, 31);
            label1.TabIndex = 0;
            label1.Text = "Unesite jmbg rukovodioca za selektovanog zaposlenog";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 194);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(310, 267);
            button1.Name = "button1";
            button1.Size = new Size(119, 40);
            button1.TabIndex = 2;
            button1.Text = "Unesi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PostaviRukovodiocaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "PostaviRukovodiocaForm";
            Text = "PostaviRukovodiocaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}