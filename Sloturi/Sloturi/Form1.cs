using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sloturi
{
    public partial class Form1 : Form
    {
        Image[] imagini;
        Random rnd = new Random();

        int totalCycles = 0;
        int currentCycle = 0;
        public Form1()
        {
            InitializeComponent();
            imagini = new Image[]
            {
                Properties.Resources.img1,
                Properties.Resources.img2,
                Properties.Resources.img3,
                Properties.Resources.img4
            };

            lblRezultat.Text = "";

        }
        private void btnTrage_Click(object sender, EventArgs e)
        {
            totalCycles = (int)numCycles.Value;
            currentCycle = 0;
            lblRezultat.Text = "";

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Rulează un nou ciclu
            pb1.Image = imagini[rnd.Next(imagini.Length)];
            pb2.Image = imagini[rnd.Next(imagini.Length)];
            pb3.Image = imagini[rnd.Next(imagini.Length)];

            currentCycle++;

            // S-au terminat ciclurile → oprire + evaluare
            if (currentCycle >= totalCycles)
            {
                timer1.Stop();
                VerificaRezultat();
            }
        }

        private void VerificaRezultat()
        {
            // Se câștigă dacă toate cele 3 imagini sunt identice
            if (pb1.Image == pb2.Image && pb2.Image == pb3.Image)
            {
                lblRezultat.Text = "🎉 Ai câștigat!";
                lblRezultat.ForeColor = Color.Green;
            }
            else
            {
                lblRezultat.Text = "❌ Ai pierdut!";
                lblRezultat.ForeColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }
    }
}
