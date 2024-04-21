using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace NDP_GAME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int sure = 0;
        public int seviye = 1;
        public int can = 3;
        public int puan = 0;

    private void Form1_Load(object sender, EventArgs e)
        {
            // string kullaniciAdı = Microsoft.VisualBasic.Interaction.InputBox("Lütfen Kullanıcı Adınızı Girin:", "NDP_GAME", "");

            // oyuncu_label.Text = "Oyuncu: " + kullaniciAdı;
            Seviye_label.Text = "Seviye: 1";
            gecen_sure_label.Text = "Geçen Süre (sn): 0";
            kalan_can_label.Text = "Kalan Can: 3";
            Puan_label.Text = "Puan: 0";

            timer1.Enabled = true;

            TuzakDoldur(10, 10);
        }

        void TuzakDoldur(int mayin, int boyut)
        {
            flowLayoutPanel1.Width = boyut * 50;
            flowLayoutPanel1.Height = 3 * 50;
            flowLayoutPanel1.Controls.Clear();
            int[] mayinlar = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                int secilen = rnd.Next(0, boyut * 3);
                if (mayinlar.Contains(secilen))
                {
                    i--;
                    continue;
                }
                mayinlar[i] = secilen;
            }

            for (int i = 0; i < boyut * 3; i++)
            {
                Button btn = new Button();
                btn.Width = 50;
                btn.Height = 50;
                btn.Margin = new Padding(0);
                btn.Tag = mayinlar.Contains(i);
                btn.Click += btn_click;
                btn.Image = Properties.Resources.taş;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            bool durum = (bool)tiklanan.Tag;
            if (durum == true)
            {
                Random random = new Random();
                int rnd = random.Next(1,4);
                if(rnd == 1)
                {
                    tiklanan.Image = Properties.Resources.tuzak_1;
                }
                else if(rnd == 2)
                {
                    tiklanan.Image = Properties.Resources.tuzak_2;
                }
                else if (rnd == 3)
                {
                    tiklanan.Image = Properties.Resources.tuzak_2;
                }
               
                tiklanan.BackgroundImageLayout = ImageLayout.Stretch;
                OyunBitir();
            }
            else
            {
                tiklanan.BackColor = Color.Green;
                tiklanan.Image = null;

            }
        }

        void OyunBitir()
        {
            foreach (Button item in flowLayoutPanel1.Controls)
            {
                bool durum = (bool)item.Tag;
                if (durum)
                {
                    item.BackColor = Color.Red;
                    
                }
                else
                {
                    item.BackColor = Color.Green;
                }
            }
            DialogResult sonuc = MessageBox.Show("Oyun Bitti Yeniden Oynamak İstermisiniz?", "Devam Etmek İstermisiniz?", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                TuzakDoldur(10, 10);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;
            gecen_sure_label.Text = "Geçen Süre (sn): " + sure;
            Puan_label.Text = "Puan: " + (can * 500 + (1000 - sure));
        }
    }
}
