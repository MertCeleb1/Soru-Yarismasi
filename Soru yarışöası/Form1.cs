using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_yarışöası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0,dogru = 0,yanlıs = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            sonraki.Enabled = true;
            
            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                btnB.BackColor = Color.Green;
            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
                btnB.BackColor = Color.Red;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            sonraki.Enabled = true;
            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                btnC.BackColor = Color.Green;
            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
                btnC.BackColor= Color.Red;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            sonraki.Enabled = true;
            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                btnD.BackColor = Color.Green;
            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
                btnD.BackColor = Color.Red;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            sonraki.Enabled = true;
            label5.Text = btnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text= dogru.ToString();
                pictureBox1.Visible = true;
                btnA.BackColor = Color.Green;
            }
            else
            {
                yanlıs++;
                lblyanlıs.Text= yanlıs.ToString();
                pictureBox2.Visible = true;
                btnA.BackColor = Color.Red;
            }
        }

        private void sonraki_Click(object sender, EventArgs e)
        {
            btnA.BackColor = Color.White;
            btnB.BackColor = Color.White;
            btnC.BackColor = Color.White;
            btnD.BackColor = Color.White;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            sonraki.Enabled = false;
            pictureBox1 .Visible = false;
            pictureBox2 .Visible = false;
            soruno++;   
            lblsoruno.Text = soruno.ToString();
            
            if(soruno==1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir ?";
                btnA.Text = "1923";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1920";
                label4.Text = "1923";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi marmara bölgesinden değildir ?";
                btnA.Text = "İstanbul";
                btnB.Text = "Zonguldak";
                btnC.Text = "Bilecik";
                btnD.Text = "Tekirdağ";
                label4.Text = "Zonguldak";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "İstanbul kaç yılında fethedilmiştir ?";
                btnA.Text = "1453";
                btnB.Text = "1452";
                btnC.Text = "1420";
                btnD.Text = "1520";
                label4.Text = "1453";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Albert Einstein hangi alanda Nobel ödülü almıştır ?";
                btnA.Text = "Matematik";
                btnB.Text = "Kimya";
                btnC.Text = "Fizik";
                btnD.Text = "Geometri";
                label4.Text = "Fizik";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Kırmızı ve sarı renklerinin karışımından hangi renk elde edilir ?";
                btnA.Text = "Turuncu";
                btnB.Text = "Mor";
                btnC.Text = "Kırmızı";
                btnD.Text = "Bordo";
                label4.Text = "Turuncu";
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Yunan mitolojisinde bilgelik ve sanat tanrısının adı nedir ?";
                btnA.Text = "Zeus";
                btnB.Text = "Athena";
                btnC.Text = "Ares";
                btnD.Text = "Hermes";
                label4.Text = "Athena";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Yüz ölçümü bakımından en büyük ülke hangisidir ?";
                btnA.Text = "Mısır";
                btnB.Text = "İngiltere";
                btnC.Text = "Türkiye";
                btnD.Text = "Rusya";
                label4.Text = "Rusya";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Geldim Gördüm Yendim anlamına gelen Veni Vidi Vici sözünü hangi hükümdar söylemiştir";
                btnA.Text = "Büyük İskender";
                btnB.Text = "Hannibal Barca";
                btnC.Text = "Julius Sezar";
                btnD.Text = "Napolyon Bonapart";
                label4.Text = "Julius Sezar";
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Nüfusu sadece 825 olan, en küçük Avrupa ülkesi hangisidir ?";
                btnA.Text = "Belçika";
                btnB.Text = "Çekya";
                btnC.Text = "Belarus";
                btnD.Text = "Vatikan";
                label4.Text = "Vatikan";
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi William Shakespeare in 4 büyük trajedisnden biri değildir ?";
                btnA.Text = "Tempes";
                btnB.Text = "Macbeth";
                btnC.Text = "King Lear";
                btnD.Text = "Hamlet";
                label4.Text = "Tempes";
            }
            if (soruno == 11)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                sonraki.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlıs);
            }
        }
    }
}
