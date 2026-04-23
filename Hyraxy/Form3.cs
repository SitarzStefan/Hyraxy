using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hyraxy
{
    public partial class Form3 : Form
    {
        private Button[,] pola;
        private System.Windows.Forms.Timer timer;
        private Random rnd = new Random();

        private int punkty = 0;
        private int hyraxyDoZlapania;

        private Image imgHyraxa = Image.FromFile("hyrax2.png");
        private Image imgKoszyk = Image.FromFile("koszyk.png");
        private Image imgSzop = Image.FromFile("szop.png");
        private Image imgKrokodyl = Image.FromFile("kroks.png");

        public Form3()
        {
            InitializeComponent();
            StartGra();
        }

        private void StartGra()
        {
            int x = Ustawienia.X;
            int y = Ustawienia.Y;

            punkty = 0;
            hyraxyDoZlapania = Ustawienia.Hyraxy;

            pola = new Button[x, y];

            Width = x * 70;
            Height = y * 70;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Button b = new Button();
                    b.Width = 60;
                    b.Height = 60;
                    b.Left = i * 60;
                    b.Top = j * 60;
                    b.BackgroundImageLayout = ImageLayout.Stretch;
                    b.BackgroundImage = imgKoszyk;
                    b.Tag = "empty";

                    b.Click += Klik;

                    pola[i, j] = b;
                    Controls.Add(b);
                }
            }

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += Tick;
            timer.Start();
        }

        private void Tick(object sender, EventArgs e)
        {
            foreach (var b in pola)
            {
                b.BackgroundImage = imgKoszyk;
                b.Tag = "empty";
            }

            int x = rnd.Next(Ustawienia.X);
            int y = rnd.Next(Ustawienia.Y);

            int type = rnd.Next(4);

            if (type == 0 && hyraxyDoZlapania > 0)
            {
                pola[x, y].BackgroundImage = imgHyraxa;
                pola[x, y].Tag = "hyraxa";
            }
            else if (type == 1)
            {
                pola[x, y].BackgroundImage = imgSzop;
                pola[x, y].Tag = "szop";
            }
            else if (type == 2 && Ustawienia.Krokodyle == 1)
            {
                pola[x, y].BackgroundImage = imgKrokodyl;
                pola[x, y].Tag = "krokodyl";
            }
        }

        private void Klik(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if ((string)b.Tag == "hyraxa")
            {
                punkty++;
                hyraxyDoZlapania--;

                if (hyraxyDoZlapania == 0)
                    Koniec(true);
            }
            else if ((string)b.Tag == "szop")
            {
                punkty--;
            }
            else if ((string)b.Tag == "krokodyl")
            {
                Koniec(false);
            }

            b.BackgroundImage = imgKoszyk;
            b.Tag = "empty";
        }

        private void Koniec(bool win)
        {
            timer.Stop();

            MessageBox.Show(
                (win ? "WYGRAŁEŚ" : "PRZEGRAŁEŚ") + "\nTwój wynik: " + punkty,
                "Koniec gry",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            Close();
        }
    }
}