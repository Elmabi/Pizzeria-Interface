using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class MainForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAgrandir_Click(object sender, EventArgs e)
        {

            if (this.Height == 1000 && this.Width == 1920)
            {
                this.Height = 720;
                this.Width = 1081;
                pictureBox1.Image = global::Pizzeria.Properties.Resources.Thank;

            }
            else
            {
                this.Height = 1000;
                this.Width = 1920;
                pictureBox1.Image = global::Pizzeria.Properties.Resources.Thank1920;
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLivraison_Click(object sender, EventArgs e)
        {
           
            pnlChoisirPizza.Visible = false;
            pnlChoisirBoisson.Visible = false;
            pnlMilieuMain.SendToBack();
            formulaire1.Visible = !formulaire1.Visible;
            if (formulaire1.Visible == true)
            {
                btnLivraison.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
                btnPizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(137)))), ((int)(((byte)(87)))));
                btnBoisson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(137)))), ((int)(((byte)(87)))));

            }
            else
            {
                btnLivraison.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(137)))), ((int)(((byte)(87)))));
            }


        }

        private void btnMinimiser_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void btnBoisson_Click(object sender, EventArgs e)
        {
            pnlChoisirPizza.Visible = false;
            formulaire1.Visible = false;
            pnlMilieuMain.SendToBack();
            pnlChoisirBoisson.Visible = !pnlChoisirBoisson.Visible;
            if (pnlChoisirBoisson.Visible == true)
            {
                btnBoisson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
                btnLivraison.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(137)))), ((int)(((byte)(87)))));
                btnPizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(137)))), ((int)(((byte)(87)))));

            }
            else
            {
                btnBoisson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(137)))), ((int)(((byte)(87)))));
            }
        }

        private void pnlFenetreMain_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

  

        private void btnPizza_Click(object sender, EventArgs e)
        {
           
            formulaire1.Visible = false;
            pnlChoisirBoisson.Visible = false;
            pnlMilieuMain.SendToBack();
            pnlChoisirPizza.Visible = !pnlChoisirPizza.Visible;
            if (pnlChoisirPizza.Visible == true)
            {
                btnPizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
                btnLivraison.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(137)))), ((int)(((byte)(87)))));
                btnBoisson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(137)))), ((int)(((byte)(87)))));

            }
            else {
                btnPizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(137)))), ((int)(((byte)(87)))));
            }



        }

    }
}
