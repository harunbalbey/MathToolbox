using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mat2_projee
{
    public partial class AğırlıkHesaplama : Form
    {
        public AğırlıkHesaplama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Ton = Convert.ToDouble(txtTon.Text);
            txtTT.Text = " " + Ton.ToString();
            txtTK.Text = " " + (Ton * 1000).ToString();
            txtTG.Text = " " + (Ton * 1000 * 1000).ToString();
            txtTM.Text = " " + (Ton * 1000 * 1000 * 1000).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Kilo = Convert.ToDouble(txtKilogram.Text);
            txtKK.Text = " " + Kilo.ToString();
            txtKT.Text = " " + (Kilo / 1000).ToString();
            txtKG.Text = " " + (Kilo * 1000).ToString();
            txtKM.Text = " " + (Kilo * 1000 * 1000).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Gram = Convert.ToDouble(txtGram.Text);
            txtGG.Text = " " + Gram.ToString();
            txtGT.Text = " " + (Gram / 1000 / 1000).ToString();
            txtGK.Text = " " + (Gram / 1000).ToString();
            txtGM.Text = " " + (Gram * 1000).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double Miligram = Convert.ToDouble(txtGram.Text);
            txtMM.Text = " " + Miligram.ToString();
            txtMT.Text = " " + (Miligram / 1000 / 1000 / 1000).ToString();
            txtMK.Text = " " + (Miligram / 1000 / 1000).ToString();
            txtMG.Text = " " + (Miligram / 1000).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtGG.Text = "";
            txtGK.Text = "";
            txtGM.Text = "";
            txtGram.Text = "";
            txtGT.Text = "";
            txtKG.Text = "";
            txtKilogram.Text = "";
            txtKK.Text = "";
            txtKM.Text = "";
            txtKT.Text = "";
            txtMG.Text = "";
            txtMiligram.Text = "";
            txtMK.Text = "";
            txtMM.Text = "";
            txtMT.Text = "";
            txtTG.Text = "";
            txtTK.Text = "";
            txtTM.Text = "";
            txtTon.Text = "";
            txtTT.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide(); //BU FORMU GİZLER
            MatematikseİslemlerProje frmAnaForm = new MatematikseİslemlerProje(); //form2 yi kullanabiliriz.
            frmAnaForm.Show(); // form2 yi gösterir
        }

        private void AğırlıkHesaplama_Load(object sender, EventArgs e)
        {

        }
    }
}
