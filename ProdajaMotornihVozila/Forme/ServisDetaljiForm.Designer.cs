namespace ProdajaMotornihVozila.Forme
{
    partial class ServisDetaljiForm
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
            labelStepenOpr = new Label();
            label1 = new Label();
            labelLimarske = new Label();
            labelMehanicarske = new Label();
            labelFarbarske = new Label();
            labelVulkanizerske = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // labelStepenOpr
            // 
            labelStepenOpr.AutoSize = true;
            labelStepenOpr.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStepenOpr.Location = new Point(40, 29);
            labelStepenOpr.Name = "labelStepenOpr";
            labelStepenOpr.Size = new Size(242, 31);
            labelStepenOpr.TabIndex = 0;
            labelStepenOpr.Text = "Stepen opremljenosti: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 80);
            label1.Name = "label1";
            label1.Size = new Size(125, 31);
            label1.TabIndex = 1;
            label1.Text = "Tip usluga:";
            // 
            // labelLimarske
            // 
            labelLimarske.AutoSize = true;
            labelLimarske.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLimarske.Location = new Point(125, 126);
            labelLimarske.Name = "labelLimarske";
            labelLimarske.Size = new Size(92, 28);
            labelLimarske.TabIndex = 2;
            labelLimarske.Text = "Limarske:";
            // 
            // labelMehanicarske
            // 
            labelMehanicarske.AutoSize = true;
            labelMehanicarske.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMehanicarske.Location = new Point(125, 165);
            labelMehanicarske.Name = "labelMehanicarske";
            labelMehanicarske.Size = new Size(135, 28);
            labelMehanicarske.TabIndex = 3;
            labelMehanicarske.Text = "Mehanicarske:";
            // 
            // labelFarbarske
            // 
            labelFarbarske.AutoSize = true;
            labelFarbarske.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFarbarske.Location = new Point(125, 204);
            labelFarbarske.Name = "labelFarbarske";
            labelFarbarske.Size = new Size(99, 28);
            labelFarbarske.TabIndex = 4;
            labelFarbarske.Text = "Farbarske:";
            // 
            // labelVulkanizerske
            // 
            labelVulkanizerske.AutoSize = true;
            labelVulkanizerske.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelVulkanizerske.Location = new Point(125, 247);
            labelVulkanizerske.Name = "labelVulkanizerske";
            labelVulkanizerske.Size = new Size(134, 28);
            labelVulkanizerske.TabIndex = 5;
            labelVulkanizerske.Text = "Vulkanizerske:";
            // 
            // button1
            // 
            button1.Location = new Point(481, 29);
            button1.Name = "button1";
            button1.Size = new Size(148, 39);
            button1.TabIndex = 6;
            button1.Text = "Servis viseg ranga";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(481, 101);
            button2.Name = "button2";
            button2.Size = new Size(148, 39);
            button2.TabIndex = 7;
            button2.Text = "Servisi nizeg ranga";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ServisDetaljiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 364);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelVulkanizerske);
            Controls.Add(labelFarbarske);
            Controls.Add(labelMehanicarske);
            Controls.Add(labelLimarske);
            Controls.Add(label1);
            Controls.Add(labelStepenOpr);
            Name = "ServisDetaljiForm";
            Text = "ServisDetaljiForm";
            Load += ServisDetaljiForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelStepenOpr;
        private Label label1;
        private Label labelLimarske;
        private Label labelMehanicarske;
        private Label labelFarbarske;
        private Label labelVulkanizerske;
        private Button button1;
        private Button button2;
    }
}