using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanüOBS
{
    public partial class ogrenciisimarama : Form
    {
        public ogrenciisimarama()
        {
            InitializeComponent();
            label1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
