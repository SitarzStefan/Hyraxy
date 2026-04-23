using System;
using System.Windows.Forms;

namespace Hyraxy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Form3 gra = new Form3();
            gra.Show();
        }

        private void buttonUstawienia_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void buttonKoniec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}