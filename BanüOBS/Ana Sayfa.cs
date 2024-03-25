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
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void cikisYap_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ogrenciEkle_Click(object sender, EventArgs e)
        {
            ogrenciEkle ogrenciEkleSayfasi = new ogrenciEkle();
            ogrenciEkleSayfasi.Show();
        }

        private void ogrenciListele_Click(object sender, EventArgs e)
        {
            ogrenciListele ogrenciListelemeSayfasi = new ogrenciListele();
            ogrenciListelemeSayfasi.Show();
            
        }

        private void ogrenciDuzenle_Click(object sender, EventArgs e)
        {
            ogrenciDuzenle ogrenciDuzenlemeSayfasi = new ogrenciDuzenle();
            ogrenciDuzenlemeSayfasi.Show();
        }

        private void ogrenciSil_Click(object sender, EventArgs e)
        {
            ogrenciSil ogrenciSilmeSayfasi = new ogrenciSil();
            ogrenciSilmeSayfasi.Show();
        }

       
    }
}
