namespace Hyraxy
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            buttonStart = new Button();
            buttonUstawienia = new Button();
            buttonKoniec = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 9);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Złap Hyraxy";
           
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(54, 74);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 29);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonUstawienia
            // 
            buttonUstawienia.Location = new Point(54, 122);
            buttonUstawienia.Name = "buttonUstawienia";
            buttonUstawienia.Size = new Size(94, 29);
            buttonUstawienia.TabIndex = 2;
            buttonUstawienia.Text = "Ustawienia";
            buttonUstawienia.UseVisualStyleBackColor = true;
            buttonUstawienia.Click += buttonUstawienia_Click; // ✅ DODANE
            // 
            // buttonKoniec
            // 
            buttonKoniec.Location = new Point(54, 168);
            buttonKoniec.Name = "buttonKoniec";
            buttonKoniec.Size = new Size(94, 29);
            buttonKoniec.TabIndex = 3;
            buttonKoniec.Text = "Koniec";
            buttonKoniec.UseVisualStyleBackColor = true;
            buttonKoniec.Click += buttonKoniec_Click; // ✅ DODANE
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(221, 272);
            Controls.Add(buttonKoniec);
            Controls.Add(buttonUstawienia);
            Controls.Add(buttonStart);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonStart;
        private Button buttonUstawienia;
        private Button buttonKoniec;
    }
}