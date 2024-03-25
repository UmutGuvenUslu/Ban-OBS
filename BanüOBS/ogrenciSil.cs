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
    public partial class ogrenciSil : Form
    {
        SqlConnection ogrenciSilmeBaglanti;
        public ogrenciSil()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            ogrenciSilmeBaglanti = new SqlConnection(@"Data Source=UMUTGšVEN;Initial Catalog=DbBanüOBSUygulaması;Integrated Security=True");
            ogrenciSilmeBaglanti.Open();
            SqlCommand SqlSilmeKomut = new SqlCommand("DELETE FROM TableOgrenciBilgileri WHERE ogrenciNo= " + textBox1.Text, ogrenciSilmeBaglanti);
            SqlSilmeKomut.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti");
            }catch(Exception ex)
            {
                MessageBox.Show(MessageBox.Show("Silme İşleminde Hata Oluştu!!")+ex.Message);
            }
            finally
            {
                if(ogrenciSilmeBaglanti != null)
                {
                    ogrenciSilmeBaglanti.Close();
                }
                textBox1.Clear();
                Hide();
            }
        }
    }
}
