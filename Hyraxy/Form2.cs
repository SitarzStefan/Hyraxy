using System;
using System.Windows.Forms;

namespace Hyraxy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 3;
            numericUpDown1.Maximum = 10;

            numericUpDown2.Minimum = 3;
            numericUpDown2.Maximum = 10;

            numericUpDown3.Minimum = 1;
            numericUpDown3.Maximum = 6;

            numericUpDown4.Minimum = 2;
            numericUpDown4.Maximum = 8;

            numericUpDown5.Minimum = 0;
            numericUpDown5.Maximum = 1;

            numericUpDown1.Value = Ustawienia.X;
            numericUpDown2.Value = Ustawienia.Y;
            numericUpDown3.Value = Ustawienia.Hyraxy;
            numericUpDown4.Value = Ustawienia.Szopy;
            numericUpDown5.Value = Ustawienia.Krokodyle;
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            Ustawienia.X = (int)numericUpDown1.Value;
            Ustawienia.Y = (int)numericUpDown2.Value;
            Ustawienia.Hyraxy = (int)numericUpDown3.Value;
            Ustawienia.Szopy = (int)numericUpDown4.Value;
            Ustawienia.Krokodyle = (int)numericUpDown5.Value;

            Close();
        }
    }
}