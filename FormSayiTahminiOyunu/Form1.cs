using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSayiTahminiOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sayi;
        int skor;
        private void btnbasla_Click(object sender, EventArgs e)
        {
            skor=100;
            lblskor.Text = "Skor : " + skor.ToString();
            btntahminet.Enabled = true;
            Random rnd = new Random();
            sayi = rnd.Next(1,30);
            MessageBox.Show("Haydi Sayıyı Tahmin Et!");
        }

        private void btntahminet_Click(object sender, EventArgs e)
        {
            int tahmin = Convert.ToInt32(txttahmin.Text);

            if (tahmin > sayi)
            {
                MessageBox.Show("Tahminin fazla aşağıya inmelisin!");
                skor -= 10;
            }
            else if (tahmin < sayi)
            {
                MessageBox.Show("Tahminin az biraz yukarı çıkmalısın!");
                skor -= 10;
            }
            else
            {
                MessageBox.Show("Tebrikler!! Doğru Tahmin ;) ");
            }

            if (skor==0)
            {
                MessageBox.Show("Oyun Bitti!! Sayıyı bulamadınız :(");
                btntahminet.Enabled = false;
            }
            lblskor.Text = "Skor : " + skor.ToString();
            txttahmin.Clear();


        }
    }
}
