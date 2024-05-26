namespace ProdajaMotornihVozila.Forme.PredstavnistvoForme
{
    partial class UrediRadnjuForma
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
            textBoxJMBG = new TextBox();
            comboBoxTipRadnje = new ComboBox();
            label2 = new Label();
            groupBoxServis = new GroupBox();
            textBoxServisVisegRanga = new TextBox();
            label5 = new Label();
            label4 = new Label();
            comboBoxStepenOpr = new ComboBox();
            checkBoxFarbarske = new CheckBox();
            checkBoxLimarske = new CheckBox();
            checkBoxVulkanizerske = new CheckBox();
            checkBoxMehanicarske = new CheckBox();
            label3 = new Label();
            button1 = new Button();
            groupBoxServis.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 40);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Maticni broj sefa";
            // 
            // textBoxJMBG
            // 
            textBoxJMBG.Location = new Point(203, 37);
            textBoxJMBG.Name = "textBoxJMBG";
            textBoxJMBG.Size = new Size(232, 27);
            textBoxJMBG.TabIndex = 1;
            // 
            // comboBoxTipRadnje
            // 
            comboBoxTipRadnje.FormattingEnabled = true;
            comboBoxTipRadnje.Items.AddRange(new object[] { "Servis", "Salon", "Servis i salon" });
            comboBoxTipRadnje.Location = new Point(203, 89);
            comboBoxTipRadnje.Name = "comboBoxTipRadnje";
            comboBoxTipRadnje.Size = new Size(151, 28);
            comboBoxTipRadnje.TabIndex = 2;
            comboBoxTipRadnje.SelectedIndexChanged += comboBoxTipRadnje_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 92);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 3;
            label2.Text = "Odaberi tip radnje";
            // 
            // groupBoxServis
            // 
            groupBoxServis.Controls.Add(textBoxServisVisegRanga);
            groupBoxServis.Controls.Add(label5);
            groupBoxServis.Controls.Add(label4);
            groupBoxServis.Controls.Add(comboBoxStepenOpr);
            groupBoxServis.Controls.Add(checkBoxFarbarske);
            groupBoxServis.Controls.Add(checkBoxLimarske);
            groupBoxServis.Controls.Add(checkBoxVulkanizerske);
            groupBoxServis.Controls.Add(checkBoxMehanicarske);
            groupBoxServis.Controls.Add(label3);
            groupBoxServis.Location = new Point(47, 156);
            groupBoxServis.Name = "groupBoxServis";
            groupBoxServis.Size = new Size(657, 210);
            groupBoxServis.TabIndex = 4;
            groupBoxServis.TabStop = false;
            groupBoxServis.Text = "Podaci o servisu";
            // 
            // textBoxServisVisegRanga
            // 
            textBoxServisVisegRanga.Location = new Point(478, 106);
            textBoxServisVisegRanga.Name = "textBoxServisVisegRanga";
            textBoxServisVisegRanga.Size = new Size(125, 27);
            textBoxServisVisegRanga.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(300, 112);
            label5.Name = "label5";
            label5.Size = new Size(150, 20);
            label5.TabIndex = 11;
            label5.Text = "Id servisa viseg ranga";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(300, 46);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 10;
            label4.Text = "Stepen opremljenosti";
            // 
            // comboBoxStepenOpr
            // 
            comboBoxStepenOpr.FormattingEnabled = true;
            comboBoxStepenOpr.Items.AddRange(new object[] { "Nizak", "Srednji", "Visok" });
            comboBoxStepenOpr.Location = new Point(478, 43);
            comboBoxStepenOpr.Name = "comboBoxStepenOpr";
            comboBoxStepenOpr.Size = new Size(151, 28);
            comboBoxStepenOpr.TabIndex = 9;
            comboBoxStepenOpr.SelectedIndexChanged += comboBoxStepenOpr_SelectedIndexChanged;
            // 
            // checkBoxFarbarske
            // 
            checkBoxFarbarske.AutoSize = true;
            checkBoxFarbarske.Location = new Point(104, 168);
            checkBoxFarbarske.Name = "checkBoxFarbarske";
            checkBoxFarbarske.Size = new Size(93, 24);
            checkBoxFarbarske.TabIndex = 8;
            checkBoxFarbarske.Text = "Farbarske";
            checkBoxFarbarske.UseVisualStyleBackColor = true;
            // 
            // checkBoxLimarske
            // 
            checkBoxLimarske.AutoSize = true;
            checkBoxLimarske.Location = new Point(104, 138);
            checkBoxLimarske.Name = "checkBoxLimarske";
            checkBoxLimarske.Size = new Size(89, 24);
            checkBoxLimarske.TabIndex = 7;
            checkBoxLimarske.Text = "Limarske";
            checkBoxLimarske.UseVisualStyleBackColor = true;
            // 
            // checkBoxVulkanizerske
            // 
            checkBoxVulkanizerske.AutoSize = true;
            checkBoxVulkanizerske.Location = new Point(104, 108);
            checkBoxVulkanizerske.Name = "checkBoxVulkanizerske";
            checkBoxVulkanizerske.Size = new Size(120, 24);
            checkBoxVulkanizerske.TabIndex = 6;
            checkBoxVulkanizerske.Text = "Vulkanizerske";
            checkBoxVulkanizerske.UseVisualStyleBackColor = true;
            // 
            // checkBoxMehanicarske
            // 
            checkBoxMehanicarske.AutoSize = true;
            checkBoxMehanicarske.Location = new Point(104, 78);
            checkBoxMehanicarske.Name = "checkBoxMehanicarske";
            checkBoxMehanicarske.Size = new Size(121, 24);
            checkBoxMehanicarske.TabIndex = 5;
            checkBoxMehanicarske.Text = "Mehanicarske";
            checkBoxMehanicarske.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 46);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 0;
            label3.Text = "Tip usluga:";
            // 
            // button1
            // 
            button1.Location = new Point(610, 395);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UrediRadnjuForma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(groupBoxServis);
            Controls.Add(label2);
            Controls.Add(comboBoxTipRadnje);
            Controls.Add(textBoxJMBG);
            Controls.Add(label1);
            Name = "UrediRadnjuForma";
            Text = "UrediRadnjuForma";
            Load += UrediRadnjuForma_Load;
            groupBoxServis.ResumeLayout(false);
            groupBoxServis.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxJMBG;
        private ComboBox comboBoxTipRadnje;
        private Label label2;
        private GroupBox groupBoxServis;
        private ComboBox comboBoxStepenOpr;
        private CheckBox checkBoxFarbarske;
        private CheckBox checkBoxLimarske;
        private CheckBox checkBoxVulkanizerske;
        private CheckBox checkBoxMehanicarske;
        private Label label3;
        private TextBox textBoxServisVisegRanga;
        private Label label5;
        private Label label4;
        private Button button1;
    }
}