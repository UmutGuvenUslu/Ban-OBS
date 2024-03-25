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
    public partial class ogrenciEkle : Form
    {
        SqlConnection ogrenciEkleBaglanti;


        public ogrenciEkle()
        {
            ogrenciEkleBaglanti = new SqlConnection(@"Data Source=UMUTGšVEN;Initial Catalog=DbBanüOBSUygulaması;Integrated Security=True");
            InitializeComponent();
        }

        private void ogrenciEkleButton_Click(object sender, EventArgs e)
        {

            try
            {
                float a = 0.4f; float b = 0.6f;
                string gectikaldi = null;
                long convertogrenciNo = long.Parse(ogrenciNumarasıTextBox.Text);
                int ConvertVize = int.Parse(ogrenciVizeNotTextBox.Text);
                int ConvertFinal = int.Parse(ogrenciFinalNotTextBox.Text);
                double ogrenciOrt = Convert.ToDouble(ConvertVize * a + ConvertFinal * b);
                string formatliOrt = ogrenciOrt.ToString("F2");

                
                


                if (ogrenciOrt < 50)
                {
                    gectikaldi = "Kaldı";
                }
                else
                {
                    gectikaldi = "Gecti";
                }

                ogrenciEkleBaglanti.Open();
                string sqlcumlesi = "INSERT INTO TableOgrenciBilgileri VALUES ('" + convertogrenciNo + "', '" +
                                                                                 ogrenciAdTextBox.Text + "', '" +
                                                                                 ogrenciSoyadTextBox.Text + "', '" +
                                                                                 ogrenciOkuduguBolumList.Text + "', '" +
                                                                                 ogrenciOkuduguSinifList.Text + "', '" +
                                                                                 ConvertVize.ToString().Replace(',', '.') + "', '" +
                                                                                 ConvertFinal.ToString().Replace(',', '.') + "', '" +
                                                                                 formatliOrt.ToString().Replace(',', '.') + "', '" +
                                                                                 gectikaldi + "')";



                SqlCommand SqlKomut = new SqlCommand(sqlcumlesi, ogrenciEkleBaglanti);
                SqlKomut.ExecuteNonQuery();
                MessageBox.Show("Öğrenci Bilgileri Kaydedilmiştir.");
                ogrenciNumarasıTextBox.Clear();
                ogrenciAdTextBox.Clear();
                ogrenciSoyadTextBox.Clear();
                ogrenciOkuduguBolumList.SelectedIndex = -1;
                ogrenciOkuduguSinifList.SelectedIndex = -1;
                ogrenciVizeNotTextBox.Clear();
                ogrenciFinalNotTextBox.Clear();




            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Serverinde Hata Gerçekleşti" + ex.Message);
            }
            finally
            {
                if (ogrenciEkleBaglanti != null)
                {
                    ogrenciEkleBaglanti.Close();
                }
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciNumarasıTextBox.Clear();
            ogrenciAdTextBox.Clear();
            ogrenciSoyadTextBox.Clear();
            ogrenciOkuduguBolumList.SelectedIndex = -1;
            ogrenciOkuduguSinifList.SelectedIndex = -1;
            ogrenciVizeNotTextBox.Clear();
            ogrenciFinalNotTextBox.Clear();
            Hide();
        }
    }
}
