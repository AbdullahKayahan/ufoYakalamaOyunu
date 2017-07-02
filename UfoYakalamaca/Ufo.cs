using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;


namespace UfoYakalamaca
{
    class Ufo:PictureBox
    {
        static Random r = new Random();
        Form1 f;
        bool eceliylemiOldu = true;
        static int yakalanan = 0;
        static int kacan = 0;
        int ufo_deger;
        string[] resim = { "1.gif", "2.gif", "3.gif", "4.png", "5.png", "6.png", "7.png" };
        ///dizi biçiminde içinde resimlerimizin isimleri var
        public Ufo(Form1 f)//yapıcı method
       {
            this.f = f;
            this.BackColor = f.oyuncu.BackColor;//saydam görünmesi için
            this.Top = 0 - this.Height;//formun tepesinde oluştur
            this.Left = r.Next(f.panel1.ClientSize.Width - this.Width);//ufoların oyunun alanının içinde çıkmasını sağlar
            this.Width = 58;
            this.Height = 58;
            
           Random ufo_resim = new Random();
            ufo_deger = ufo_resim.Next(0, f.ufolar.Images.Count);
            //ufolar adlı imagelist içinden bi random deger atansın
                    
           
            this.Image = System.Drawing.Image.FromFile(resim[ufo_deger]);
            //olusan 
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Disposed += new EventHandler(Ufo_Disposed); 
       
         Timer t = new Timer();
            t.Tick += new EventHandler(t_Tick);
            t.Interval = r.Next(1, 100);
                 
            t.Enabled = true;
       
        }

        void Ufo_Disposed(object sender, EventArgs e)
        {
           
            if (eceliylemiOldu)
            {
                (new SoundPlayer("pop.wav")).Play();
            }
            else
            {
                if (f.yildirim_atisi == false)
                { 
                (new SoundPlayer("clank.wav")).Play();
                }
               
                
            }

        }

        void t_Tick(object sender, EventArgs e)
        {
            if (!this.IsDisposed)

            {
                this.Top += r.Next(1, 5);
                if (this.Bottom >= (this.Parent.ClientSize.Height - 100))
                {
                    eceliylemiOldu = true;
                    kacan++;
                    f.yakalanamayan++;
                    f.lKacan.Text = kacan.ToString();
                    this.Dispose();
                }


                if (f.ates1.Bounds.IntersectsWith(this.Bounds))
                    // eğer mermi benim sınırlarım içindeyse ben yok et diyor
                    //bu işlem oluşan nesneyi yok ediyor ramdan o nesneye ait ne varsa siliyor
                {
                    eceliylemiOldu = false;
                    yakalanan++;//vurulan ufoyu 1 arttır
                    f.para+=10;//parayı 10 arttır
                    f.label_para.Text = f.para.ToString() + " $";
                    f.lYakalanan.Text = yakalanan.ToString();
                    this.Dispose();//ve nesneyi yok et
                }
                 if (f.ates2.Bounds.IntersectsWith(this.Bounds))
                {
                    // eğer mermi benim sınırlarım içindeyse ben yok et diyor
                    //bu işlem oluşan nesneyi yok ediyor ramdan o nesneye ait ne varsa siliyor
                    eceliylemiOldu = false;
                    yakalanan++;//vurulan ufoyu 1 arttır
                    f.para += 10;//parayı 10 arttır
                    f.label_para.Text = f.para.ToString() + " $";
                    f.lYakalanan.Text = yakalanan.ToString();
                    this.Dispose();//ve nesneyi yok et
                }
               if (f.ates3.Bounds.IntersectsWith(this.Bounds))
                {
                    // eğer mermi benim sınırlarım içindeyse ben yok et diyor
                    //bu işlem oluşan nesneyi yok ediyor ramdan o nesneye ait ne varsa siliyor
                    eceliylemiOldu = false;
                    yakalanan++;//vurulan ufoyu 1 arttır
                    f.para += 10;//parayı 10 arttır
                    f.label_para.Text = f.para.ToString() + " $";
                    f.lYakalanan.Text = yakalanan.ToString();
                    this.Dispose();//ve nesneyi yok et
                }
               if (f.ates4.Bounds.IntersectsWith(this.Bounds))
                {
                    // eğer mermi benim sınırlarım içindeyse ben yok et diyor
                    //bu işlem oluşan nesneyi yok ediyor ramdan o nesneye ait ne varsa siliyor
                    eceliylemiOldu = false;
                    yakalanan++;//vurulan ufoyu 1 arttır
                    f.para += 10;//parayı 10 arttır
                    f.label_para.Text = f.para.ToString() + " $";
                    f.lYakalanan.Text = yakalanan.ToString();
                    this.Dispose();//ve nesneyi yok et
                }
           
            if (f.pb_yildirim.Bounds.IntersectsWith(this.Bounds))
            {
                // eğer yıldırım benim sınırlarım içindeyse ben yok et diyor
                //bu işlem oluşan nesneyi yok ediyor ramdan o nesneye ait ne varsa siliyor
                eceliylemiOldu = false;
                yakalanan++;//vurulan ufoyu 1 arttır
                f.para += 5;//parayı 10 arttır
                f.label_para.Text = f.para.ToString() + " $";
                f.lYakalanan.Text = yakalanan.ToString();
                this.Dispose();//ve nesneyi yok et
            }
        }
        
     }
    }
}
