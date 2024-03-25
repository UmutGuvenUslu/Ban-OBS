using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanüOBS
{
    public partial class ogrenciListele : Form
    {
        SqlConnection ogrenciListeleBaglanti=null;
        public ogrenciListele()
        {
            
            InitializeComponent();
            try
            {
                
                ogrenciListeleBaglanti = new SqlConnection(@"Data Source=UMUTGšVEN;Initial Catalog=DbBanüOBSUygulaması;Integrated Security=True");
                ogrenciListeleBaglanti.Open();
                SqlCommand ListelemeKomut = new SqlCommand("SELECT ogrenciNo,ogrenciAd,ogrenciSoyad,ogrenciBolum,ogrenciSinif,ogrenciVize,ogrenciFinal,ogrenciOrt,geçtikaldi FROM TableOgrenciBilgileri", ogrenciListeleBaglanti);
                SqlDataReader KomutOkuyucu = ListelemeKomut.ExecuteReader();    
                while(KomutOkuyucu.Read())
                {
                    string ogrenciNo = KomutOkuyucu[0].ToString();
                    string ogrenciAdi = KomutOkuyucu[1].ToString();
                    string ogrenciSoyadi = KomutOkuyucu[2].ToString();
                    string ogrenciBolum = KomutOkuyucu[3].ToString();
                    string ogrenciSinif = KomutOkuyucu[4].ToString();
                    string ogrenciVize = KomutOkuyucu[5].ToString();
                    string ogrenciFinal = KomutOkuyucu[6].ToString();
                    string ogrenciOrt = KomutOkuyucu[7].ToString();
                    string gectikaldi = KomutOkuyucu[8].ToString();
                    richTextBox1.Text = richTextBox1.Text  + "Öğrenci No: " + ogrenciNo + "  " +"Öğrenci Adı-Soyadı: " + ogrenciAdi + "  " +ogrenciSoyadi + "  " + "Bölüm: "+ogrenciBolum + "  " + "Sınıf: "+ogrenciSinif + "  "  + "Vize Notu: "+ ogrenciVize + "  " + "Final Notu: "+ ogrenciFinal + "  " + "Ortalama: "+ogrenciOrt + "  " + "Durumu: "+ gectikaldi + "\n";
                }


            }
            catch ( Exception ex )
            {
                MessageBox.Show("SQL Baglantısı Sırasında Bir Hata Oluştu!" + ex.ToString());
            }
            finally
            {
                if(ogrenciListeleBaglanti!= null)
                {
                    ogrenciListeleBaglanti.Close();
                }
              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ogrenciNoArama noilearama = new ogrenciNoArama();
            noilearama.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciisimarama isimilearama = new ogrenciisimarama();
            isimilearama.Show();
        }
    }
}
