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
    public partial class ogrenciDuzenle : Form
    {
        SqlConnection ogrenciDuzenleBaglanti;
        public ogrenciDuzenle()
        {
            ogrenciDuzenleBaglanti = new SqlConnection(@"Data Source=UMUTGšVEN;Initial Catalog=DbBanüOBSUygulaması;Integrated Security=True");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ogrenciOkuduguBolumList.SelectedIndex = -1;
            NumaraSorgulayıcıTextBox.Clear();
            BilgiDegistirTextBox.Clear();
            Hide();
        }

        private void ogrenciEkleButton_Click(object sender, EventArgs e)
        {
            try
            {
                ogrenciDuzenleBaglanti.Open();
                float ortalama;
                if (ogrenciOkuduguBolumList.Text == "Öğrenci Adı")
                {
                    SqlCommand SqlKomutu = new SqlCommand("UPDATE TableOgrenciBilgileri SET " + "ogrenciAd= '" + BilgiDegistirTextBox.Text + "'" + "WHERE ogrenciNo= " + NumaraSorgulayıcıTextBox.Text, ogrenciDuzenleBaglanti);
                    SqlKomutu.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarıyla Günellendi!");
                }
                else if (ogrenciOkuduguBolumList.Text == "Öğrenci Soyadı")
                {
                    SqlCommand SqlKomutu = new SqlCommand("UPDATE TableOgrenciBilgileri SET " + "ogrenciSoyad= '" + BilgiDegistirTextBox.Text + "'" + "WHERE ogrenciNo= " + NumaraSorgulayıcıTextBox.Text, ogrenciDuzenleBaglanti);
                    SqlKomutu.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarıyla Günellendi!");
                }
                else if (ogrenciOkuduguBolumList.Text == "Öğrenci Vize Notu")
                {
                    SqlCommand SqlKomutu = new SqlCommand("UPDATE TableOgrenciBilgileri SET " + "ogrenciVize= '" + int.Parse(BilgiDegistirTextBox.Text) + "'" + "WHERE ogrenciNo= " + NumaraSorgulayıcıTextBox.Text, ogrenciDuzenleBaglanti);
                    SqlKomutu.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarıyla Günellendi!");
                }
                else if (ogrenciOkuduguBolumList.Text == "Öğrenci Final Notu")
                {
                    SqlCommand SqlKomutu = new SqlCommand("UPDATE TableOgrenciBilgileri SET " + "ogrenciFinal= '" + int.Parse(BilgiDegistirTextBox.Text) + "'" + "WHERE ogrenciNo= " + NumaraSorgulayıcıTextBox.Text, ogrenciDuzenleBaglanti);
                    SqlKomutu.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarıyla Günellendi!");
                }
                else
                {
                    MessageBox.Show("Hatalı İşlem Yaptınız!!!");
                    ogrenciOkuduguBolumList.SelectedIndex = -1;
                    NumaraSorgulayıcıTextBox.Clear();
                    BilgiDegistirTextBox.Clear();

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir SQL Hatası Meydana Geldi "+ ex.Message);
            }
            finally
            {
                if (ogrenciDuzenleBaglanti != null)
                {
                    ogrenciDuzenleBaglanti.Close();
                }
            }
            ogrenciOkuduguBolumList.SelectedIndex = -1;
            NumaraSorgulayıcıTextBox.Clear();
            BilgiDegistirTextBox.Clear();
        }
    }
}
