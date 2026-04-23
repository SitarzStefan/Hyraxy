namespace Hyraxy
{
    partial class Form2
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
            Button buttonZapisz;
            label1 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown5 = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            buttonZapisz = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            SuspendLayout();
            // 
            // buttonZapisz
            // 
            buttonZapisz.Location = new Point(120, 208);
            buttonZapisz.Name = "buttonZapisz";
            buttonZapisz.Size = new Size(94, 29);
            buttonZapisz.TabIndex = 11;
            buttonZapisz.Text = "Zapisz";
            buttonZapisz.UseVisualStyleBackColor = true;
            buttonZapisz.Click += buttonZapisz_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 0;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 1;
            label2.Text = "Y";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(68, 47);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(64, 27);
            numericUpDown1.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(68, 85);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(64, 27);
            numericUpDown2.TabIndex = 3;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(232, 24);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(49, 27);
            numericUpDown3.TabIndex = 4;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(232, 77);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(49, 27);
            numericUpDown4.TabIndex = 5;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(232, 127);
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(49, 27);
            numericUpDown5.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 1);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 8;
            label4.Text = "Hyraxy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(232, 54);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 9;
            label5.Text = "Szopy";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 16);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 10;
            label6.Text = "Plansza";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(227, 107);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 12;
            label7.Text = "Krokusie";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 249);
            Controls.Add(label7);
            Controls.Add(buttonZapisz);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numericUpDown5);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}