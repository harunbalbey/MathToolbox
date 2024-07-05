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
    public partial class FonksiyonHesaplama : Form
    {
        public FonksiyonHesaplama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                double ilkKatsayi = Convert.ToDouble(txtİlkKatsayi.Text);
                double ilkUs = Convert.ToDouble(txtİlkUs.Text);
                double ikinciKatsayi = Convert.ToDouble(txtİkinciKatsayi.Text);
                double ikinciUs = Convert.ToDouble(txtİkincius.Text);
                double sabitSayi = Convert.ToDouble(txtSabitSayi.Text);
                double xDegeri = Convert.ToDouble(txtX.Text);


                double sonuc = ilkKatsayi * Math.Pow(xDegeri, ilkUs) + ikinciKatsayi * Math.Pow(xDegeri, ikinciUs) + sabitSayi;


                lblSonuc.Text = " " + sonuc.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen tüm alanları doğru bir şekilde doldurduğunuzdan emin olun.", "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            txtİlkKatsayi.Text = "";
            txtİlkUs.Text = "";
            txtİkinciKatsayi.Text = "";
            txtİkincius.Text = "";
            txtSabitSayi.Text = "";
            txtX.Text = "";
            lblSonuc.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); //BU FORMU GİZLER
            MatematikseİslemlerProje frmAnaForm = new MatematikseİslemlerProje(); //form2 yi kullanabiliriz.
            frmAnaForm.Show(); // form2 yi gösterir
        }

        private void FonksiyonHesaplama_Load(object sender, EventArgs e)
        {

        }
    }
}

