namespace ProdajaMotornihVozila.Forme
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(344, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 38);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 1;
            label1.Text = "Unesi jmbg rukovodioca";
            // 
            // button1
            // 
            button1.Location = new Point(205, 141);
            button1.Name = "button1";
            button1.Size = new Size(136, 39);
            button1.TabIndex = 2;
            button1.Text = "Potvrdi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(413, 141);
            button2.Name = "button2";
            button2.Size = new Size(136, 39);
            button2.TabIndex = 3;
            button2.Text = "Odustani";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PostaviRukovodiocaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 303);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "PostaviRukovodiocaForm";
            Text = "PostaviRukovodiocaForm";
            Load += PostaviRukovodiocaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}