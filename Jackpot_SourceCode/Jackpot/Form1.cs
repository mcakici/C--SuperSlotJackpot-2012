using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Jackpot
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    int sayac = 4;
    decimal bahis = 2,jeton = 200, bildi=0;
    string[] cikandeger = new string[3];
    private void button1_Click(object sender, EventArgs e)
    {
      if (jeton < bahis)
      {
        MessageBox.Show("Bahisiniz için Yeterli Jetonunuz Bulunmuyor.");
        return;
      }
      SesCal(1);

      jeton -= bahis;
      label_jeton.Text = jeton.ToString();
      bildi = 0;
      label_sonuc.Text = "Bekleyiniz..";
      SesCal(0);


      button1.Enabled = false;
      button1.BackColor = Color.Brown;
      timer1.Interval = 15;
      timer1.Start();


      sayac = rnd.Next(4, 8);

      timer2.Interval = rnd.Next(1000, 3000);
      timer2.Start();

    }
    string[] pozisyon = new string[] { "-576,-640", "-640,-704", "-704,-768", "-768,-832", "-832,-896", "-896,-960", "-960,-1024", "-1024,-1088", "-1088,-1152" };
    string[] nevar = new string[] { "Altın", "Kiwi", "Karpuz", "Çikita Muz", "Altın x6", "Twit", "Süpriz", "Altın x4", "Kafatası" };
    Random rnd = new Random();

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (resim1.Top <= -1152){ resim1.Top = -576;  }
      if (resim2.Top <= -1152) { resim2.Top = -576; }
      if (resim3.Top <= -1152) { resim3.Top = -576; }

      resim1.Top -= 18;
      resim2.Top -= 30;
      resim3.Top -= 15;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      label_jeton.Text = jeton.ToString();
    }



    private void timer2_Tick(object sender, EventArgs e)
    {
      sayac--;

      if (sayac == 3)
      {
        timer1.Interval = 20;
      }
      else if (sayac == 2)
      {
        timer1.Interval = 25;
      }
      else if (sayac == 1)
      {
        timer1.Interval = 30;
      }
      else if (sayac <= 0)
      {
        timer1.Stop();
        timer2.Stop();
        button1.Enabled = true;
        button1.BackColor = Color.Olive;
        int restop1,restop2,restop3;

        for (int i = 0; i < pozisyon.Length; i++)
        {
          string[] Kordinati = pozisyon[i].Split(',');
          if (resim1.Top - 50 >= -1152)
          {
            restop1 = resim1.Top - 50; 
          }
          else
          {
            restop1 = -576 - 50;
          }

          if (resim2.Top - 50 >= -1152)
          {
            restop2 = resim2.Top - 50;
          }
          else
          {
            restop2 = -576 - 50;
          }

          if (resim3.Top - 50 >= -1152)
          {
            restop3 = resim3.Top - 50;
          }
          else
          {
            restop3 = -576 - 50;
          }




          if (restop1 <= int.Parse(Kordinati[0]) && restop1 > int.Parse(Kordinati[1]))
          { label_1.Text = nevar[i]; cikandeger[0] = nevar[i]; }
          if (restop2 <= int.Parse(Kordinati[0]) && restop2 > int.Parse(Kordinati[1]))
          { label_2.Text = nevar[i]; cikandeger[1] = nevar[i]; }
          if (restop3 <= int.Parse(Kordinati[0]) && restop3 > int.Parse(Kordinati[1]))
          { label_3.Text = nevar[i]; cikandeger[2] = nevar[i]; }
        }


        if (cikandeger[0] == cikandeger[1] && cikandeger[0] == cikandeger[2])
        {
          bildi += 3;
        }else if (cikandeger[0] == cikandeger[1])
        {
          bildi += 2;
        }else if(cikandeger[1] == cikandeger[2])
        {
          bildi += 2;
        }else if (cikandeger[0] == cikandeger[2])
        {
          bildi += 2;
        }


        if (bildi == 0)
        {
          label_sonuc.Text = "Hiç Birşey Tutmadı!";
          SesCal(3);
        }
        else
        {
          SesCal(2);
        }



        if (bildi == 3 && cikandeger[0] == nevar[4]) //x6 altın gelirse
        {
          jeton = jeton + (bahis * 6);
          label_jeton.Text = jeton.ToString();
          label_sonuc.Text = "Bahsinizin tam 6 katını kazandınız!";
        }
        else if (bildi == 3 && cikandeger[0] == nevar[7]) //x4 altın gelirse
        {
          jeton = jeton + (bahis * 4);
          label_jeton.Text = jeton.ToString();
          label_sonuc.Text = "Bahsinizin tam 4 katını kazandınız!";
        }
        else if (bildi == 3 && cikandeger[0] == nevar[0]) //altın gelirse
        {
          jeton = jeton + (bahis * 3);
          label_jeton.Text = jeton.ToString();
          label_sonuc.Text = "Bahsinizin tam 3 katını kazandınız!";
        }
        else if (bildi == 3) //herhangi bir üçlü gelirse
        {
          jeton = jeton + (bahis * 2);
          label_jeton.Text = jeton.ToString();
          label_sonuc.Text = "Bahsinizin tam 2 katını kazandınız!";
        }
        else if (bildi == 2 && bahis > 1) //eğer iki bilirse ve bahsi büyük ise
        {
          jeton = jeton + Math.Round(bahis/2);
          label_jeton.Text = jeton.ToString();
          label_sonuc.Text = "İkili tutturarak " + Math.Floor(bahis / 2) + " adet jeton kazandınız!";
        }

        
      }

      
      
    }


    private void label_cevir_Click(object sender, EventArgs e)
    {
      button1.PerformClick();
    }

    private void numericUpDown_bahis_ValueChanged(object sender, EventArgs e)
    {
      bahis = numericUpDown_bahis.Value;
    }


    private void SesCal(int sesid)
    {

      string path = "JackPot_Data/slot.wav";
        switch (sesid)
        {
          case 0: path = "JackPot_Data/slot.wav"; SoundPlayer player = new SoundPlayer(); player.SoundLocation = path; player.Play(); break;
          case 1: path = "JackPot_Data/jetonat.wav"; SoundPlayer player2 = new SoundPlayer(); player2.SoundLocation = path; player2.Play(); break;
          case 2: path = "JackPot_Data/son.wav"; SoundPlayer player3 = new SoundPlayer(); player3.SoundLocation = path; player3.Play(); break;
          case 3: path = "JackPot_Data/talihsiz.wav"; SoundPlayer player4 = new SoundPlayer(); player4.SoundLocation = path; player4.Play(); break;
        }

        
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      MessageBox.Show("Super Slot Jackpot oyunumuzda bahsiniz kadar kazanabilmeniz için 3 resminde aynı hizada bulunması gerekmektedir.\n\nAyrıca yüksek bahislerde ikili tutma durumunda jetonların bir kısmını geri alabilirsiniz.", "Super Slots Jackpot");
    }


  }
}
