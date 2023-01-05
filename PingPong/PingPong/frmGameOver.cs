using System;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PingPong
{
    public partial class frmGameOver : Form
    {
        string filepath = @"C:\Users\Janick\Documents\SaveFile.txt";



        public frmGameOver(int score)
        {
            InitializeComponent();
            lblPunkte.Text = Convert.ToString(score);
            if (!System.IO.File.Exists(filepath))
            {
                File.WriteAllText(filepath, "");
            }
            lblErgebnisse.Text = File.ReadAllText(filepath);
        }



        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void btnEintragen_Click(object sender, EventArgs e)
        {

            lblErgebnisse.Text += lblPunkte.Text + "    " +
            txtName.Text + "    " +
            DateTime.Now.ToString("dd.MM.yyyy") +
            "\n";

            File.WriteAllText(filepath, lblErgebnisse.Text);



        }
        public void SetScore(int score)
        {
            lblPunkte.Text = score.ToString();
        }
        public void ClearName()
        {
            txtName.Text = "";
        }

    }
}
