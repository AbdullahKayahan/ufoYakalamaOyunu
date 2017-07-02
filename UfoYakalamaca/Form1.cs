using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UfoYakalamaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         #region Global değişkenler
       public int puan, para=500 ,yakalanamayan=0 ,seviye = 1;//global değişkenler
       public bool yildirim_atisi = false;//global değişkenler
#endregion
         #region yerel değişkenler
       int zaman = 0;
        int cephane = 50;
        int ates_deger1, ates_deger2, ates_deger3, ates_deger4,  pb_yildirim1;
        int y_atis_hakki=2;
        int a = 0, b = 0, c = 0, d = 0;
       #endregion
         #region enumlarım
        enum hizdegerleri
         { 
        hizli=25 ,
        orta=15, 
        yavas=10, 
        }
       hizdegerleri hiz = hizdegerleri.hizli;
       hizdegerleri hiz1 = hizdegerleri.orta;
       hizdegerleri hiz2 = hizdegerleri.yavas;
        #endregion
         #region bu kısımda windowsun önceliklerini elinden alıyooruz yön tuşları için
       protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left: return false;
                case Keys.Right: return false;
                case Keys.Up: return false;
                case Keys.Down: return false;
                case Keys.Space: return false;
                default:return base.ProcessDialogKey(keyData);
            }
            
        }
        #endregion
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            Ufo b1 = new Ufo(this);//ufo classından yeni bir ufo üretiyo
            this.panel1.Controls.Add(b1);//ufoyu oyun alanına ekliyo
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int hareket = 20;
            switch (e.KeyData)
            {
                case Keys.Left: oyuncu.Left -= hareket; break;
                case Keys.Right: oyuncu.Left += hareket; break;
               // case Keys.Up: oyuncu.Top -= hareket; break;
                //case Keys.Down: oyuncu.Top += hareket; break;
                case Keys.Space: oyuncu.PerformLayout(); break;
                    // bu kısımda yön tuşları ile kontrol yapıyoyoruz oyuncuyu hareket ettiriyoruz
            }
        }



        #region mermileri hareket için kullanılan kodlar

        private void mermi1_Tick(object sender, EventArgs e)
        {
            if (ates1.Visible == false)
            {
                ates1.Location = new Point((oyuncu.Location.X + oyuncu.Width / 2), (oyuncu.Location.Y + 10));
                //merminin başlangıç pozisyonunu belirliyor
            }

            ates1.Visible = true;//1. merminin görünürlüğünü aktif yapıyor
            ates_deger1 = Convert.ToInt32(hiz);// merminin gidiş hızını ayarlıyor
            ates1.Location = new Point(ates1.Location.X, ates1.Location.Y - ates_deger1);
            //mermiyi yukarı doğru hareket ettiriyor.
            if (ates1.Bottom <= panel1.Top)//mermi oyun alanın dışına çıkmışmı kontrol ediyor
            { 
                ates1.Location = new Point((oyuncu.Location.X + oyuncu.Width / 2), (oyuncu.Location.Y + 10));
                ates1.Visible = false;
                mermi1.Enabled = false;
                a = 0;
                //eger dışına çımışsa pozisyonunu ayarlıyor ve görünürlüğünü pasif yapıyor mermi1 in timerini pasif yapıyor


            }
        }

        private void mermi2_Tick(object sender, EventArgs e)
        {
            if (ates2.Visible == false)
            {
                ates2.Location = new Point((oyuncu.Location.X + oyuncu.Width / 2), (oyuncu.Location.Y + 10));

            }

            ates2.Visible = true;
            ates_deger2 = Convert.ToInt32(hiz);
            ates2.Location = new Point(ates2.Location.X, ates2.Location.Y - ates_deger2);
            if (ates2.Bottom <= panel1.Top)
            {
                ates2.Location = new Point((oyuncu.Location.X + oyuncu.Width / 2), (oyuncu.Location.Y + 10));
                ates2.Visible = false;
                mermi2.Enabled = false;
                b = 0;

            }
        }

        private void mermi3_Tick(object sender, EventArgs e)
        {

            if (ates3.Visible == false)
            {
                ates3.Location = new Point((oyuncu.Location.X + oyuncu.Width / 2), (oyuncu.Location.Y + 10));

            }

            ates3.Visible = true;
            ates_deger3 = Convert.ToInt32(hiz);
            ates3.Location = new Point(ates3.Location.X, ates3.Location.Y - ates_deger3);
            if (ates3.Bottom <= panel1.Top)
            {
                ates3.Location = new Point((oyuncu.Location.X + oyuncu.Width / 2), (oyuncu.Location.Y + 10));
                ates3.Visible = false;
                mermi3.Enabled = false;
                c= 0;

            }
        }

        private void mermi4_Tick(object sender, EventArgs e)
        {
            if (ates4.Visible == false)
            {
                ates4.Location = new Point((oyuncu.Location.X + oyuncu.Width / 2), (oyuncu.Location.Y + 10));

            }

            ates4.Visible = true;
            ates_deger4 = Convert.ToInt32(hiz);
            ates4.Location = new Point(ates4.Location.X, ates4.Location.Y - ates_deger4);
            if (ates4.Bottom <= panel1.Top)
            {
                ates4.Location = new Point((oyuncu.Location.X + oyuncu.Width / 2), (oyuncu.Location.Y + 10));
                ates4.Visible = false;
                mermi4.Enabled = false;
                d = 0;

            }
        }
        #endregion
    
        private void button2_Click(object sender, EventArgs e)
        {///mermi satın alma işlemi 
         ///eğer para 50 den büyükse buton aktif oluyor
         ///ve tıklanınca 50 $ azalıp 50 mermi artıyor

            if (para >= 50)
            {
                para -= 50;
                cephane += 50;
                label_para.Text = para.ToString() + " $";
                 label_cephane.Text = cephane.ToString(); m_hakki.Text = cephane.ToString();
                oyuncu.Select();
            }
            if (para < 50)
            {
                button2.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {///bu kısımda başlangıc yani varsayılan değerlerimiz belirliyoruz
            Mermi_hakki.Checked = true;
            label_para.Text = para.ToString() + " $";
             label_cephane.Text = cephane.ToString();
            m_hakki.Text = cephane.ToString();
            y_hakki.Text = y_atis_hakki.ToString();
            panel1.Width = this.Width - panel2.Width;
           
        }

        private void mermi_kontrol_Tick(object sender, EventArgs e)
        {///bu kısım form üzerinde sürekli çalışarak paramıza göre boton aktivasyonunu yapan bölüm
            zaman++;
            if (zaman == 10)
            {
                timer1.Interval -= 100;
                zaman = 0;
                if (timer1.Interval <= 1000)
                {
                    timer1.Interval = 2000;
                }
            }
            if (para >= 50)
            {
                button2.Enabled = true;
            }
            else button2.Enabled = false;
            if (para >= 500)
            {
                button3.Enabled = true;
            }
          if (yakalanamayan==25)
          {
          timer1.Enabled=false;
          oyuncu.Enabled = false;
          MessageBox.Show("Ufo Saldırısını Kaybettiniz :(");
             
              
          }
        }

        private void button3_Click(object sender, EventArgs e)
        {///yıldırım satın alma işini yapıyor 
         ///eper para 500$ den büyük ve eşitse buton aktif oluyor
         ///ve yıldırım alınca paramız 500$ eksiliyor
            if (para >= 500)
            {
                para -= 500;

                label_para.Text = para.ToString() + " $";

                oyuncu.Select();

             
                y_atis_hakki++;
                y_hakki.Text = y_atis_hakki.ToString();
                Yildirim_at.Enabled = true;
                //yildirim_atisi = true;
            }
            if (para < 500)
            {
                button3.Enabled = false;
            }
        }

        private void yildirim_Tick(object sender, EventArgs e)
        {
            //yıldırım harektetmesi sağlıyor
            pb_yildirim.Visible = true;
            pb_yildirim1 = Convert.ToInt32(hiz);
            pb_yildirim.Location = new Point(pb_yildirim.Location.X, pb_yildirim.Location.Y - pb_yildirim1);
            if (pb_yildirim.Bottom <= panel1.Top)
            {
                pb_yildirim.Location = new Point(-1, 482);
                pb_yildirim.Visible = false;
                yildirim.Enabled = false;
                yildirim_atisi = false;
            } 
        }

       

        private void Form1_Resize(object sender, EventArgs e)
        {//formun bopyu büyüyünce panelin whidth ini formun whidthinin yarısına eşitliyor
            panel1.Width = this.Width - panel2.Width;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {//oyunu başlatma butonnu oyunu başla dediği zaman
            ///mermi kontrol timerini aktif yapıyor 
            ///ufoları yollaması için timer 1 i aktif yapıyor
            mermi_kontrol.Enabled = true;
            timer1.Enabled = true;
            oyuncu.Select();
            progressBar1.Value = cephane;///progresbar ın valuesini merminin valuesine eşitliyo
        }

        private void oyuncu_Click(object sender, EventArgs e)
        {///bu kısım oyuncuya tıklandığında yani bizim spaceye basmamız
         ///eğer o anda yıldırım atmasını istiyorsak yıldırım atacak 
         ///yok eğer normal atış yapacaksak mermi yollayacak
         /// ikisidnede  cephane 0 a inince atış yapmayacak
            if (yildirim_atisi == true)
            {
                y_atis_hakki--;
                y_hakki.Text = y_atis_hakki.ToString();
                yildirim.Enabled = true;
                (new System.Media.SoundPlayer("yildirim_ses.wav")).Play();
                Yildirim_at.Checked = false;
                if (y_atis_hakki == 0)
                {
                    //Mermi_hakki.Checked = true;
                    Yildirim_at.Enabled = false;
                }


            }
            #region mermileri bir düzen içinde atmamızı sağlayan kodlar
            else
            {
                if (a == 0)
                {
                    if (cephane == 0)
                    {
                        MessageBox.Show("Atış Hakkınız Yok ... Cephane Alınız...");
                    }
                    else
                    {
                        mermi1.Enabled = true;
                        a = 1;
                        cephane -= 1;

                         label_cephane.Text = cephane.ToString(); m_hakki.Text = cephane.ToString();
                        //(new System.Media.SoundPlayer("ates_ses.wav")).Play();
                    }
                }
                else if (b == 0)
                {
                    if (cephane == 0)
                    {
                        MessageBox.Show("Atış Hakkınız Yok ... Cephane Alınız...");
                    }
                    else
                    {
                        mermi2.Enabled = true;
                        b = 1;
                        cephane -= 1;
                        progressBar1.Value = cephane;
                         label_cephane.Text = cephane.ToString(); m_hakki.Text = cephane.ToString();
                        //(new System.Media.SoundPlayer("ates_ses.wav")).Play();
                    }
                }
                else if (c == 0)
                {
                    if (cephane == 0)
                    {
                        MessageBox.Show("Atış Hakkınız Yok ... Cephane Alınız...");
                    }
                    else
                    {
                        mermi3.Enabled = true;
                        c = 1;
                        cephane -= 1;
                        progressBar1.Value = cephane;
                         label_cephane.Text = cephane.ToString(); m_hakki.Text = cephane.ToString();
                        //(new System.Media.SoundPlayer("ates_ses.wav")).Play();
                    }
                }
                else if (d == 0)
                {
                    if (cephane == 0)
                    {
                        MessageBox.Show("Atış Hakkınız Yok ... Cephane Alınız...");

                    }
                    else
                    {
                        mermi4.Enabled = true;
                        d = 1;
                        cephane -= 1;
                        progressBar1.Value = cephane;
                         label_cephane.Text = cephane.ToString(); m_hakki.Text = cephane.ToString();
                        //(new System.Media.SoundPlayer("ates_ses.wav")).Play();
                    }
                }
            }
            #endregion
        }

        private void Yildirim_hakki_CheckedChanged(object sender, EventArgs e)
        {//bu kısım eğer yıldırım atmak istediğimizi belirtiyoruz
            if (y_atis_hakki >= 1)
                yildirim_atisi = true;
            else if (y_atis_hakki == 0)
                
            {
                Mermi_hakki.Checked = true; 
                Yildirim_at.Enabled = false;
                
            }

            oyuncu.Select();
        }

        private void Mermi_hakki_CheckedChanged(object sender, EventArgs e)
        {
            //mermi atmak istediğimizi belirtiyoruz
            yildirim_atisi = false;
            oyuncu.Select();
        }

      

    }
}
