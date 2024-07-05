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
    public partial class Geometrikİslemler : Form
    {
        public Geometrikİslemler()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonKare_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(textBoxKareKenar.Text))
            {
                MessageBox.Show("Lütfen kenar uzunluğunu giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double kenarUzunlugu = Convert.ToDouble(textBoxKareKenar.Text);
                double alan = kenarUzunlugu * kenarUzunlugu;
                textBoxKareAlan.Text = alan.ToString();
            }
        }

        private void buttonDikdortgen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDikdortgenKenar1.Text) || string.IsNullOrWhiteSpace(textBoxDikdortgenKenar2.Text))
            {
                MessageBox.Show("Lütfen her iki kenar uzunluğunu da giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double kenarUzunlugu1 = Convert.ToDouble(textBoxDikdortgenKenar1.Text);
                double kenarUzunlugu2 = Convert.ToDouble(textBoxDikdortgenKenar2.Text);

                double alan = kenarUzunlugu1 * kenarUzunlugu2;

                textBoxDikdortgenAlan.Text = alan.ToString();
            }
        }

        private void buttonUcgen_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxUcgenTaban.Text) || string.IsNullOrWhiteSpace(textBoxUcgenYukseklik.Text))
            {
                MessageBox.Show("Lütfen Gerekli Yerleri Doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double kenarYukseklik = Convert.ToDouble(textBoxUcgenYukseklik.Text);
                double kenarTaban = Convert.ToDouble(textBoxUcgenTaban.Text);

                double alan = (kenarYukseklik / 2) * kenarTaban;

                textBoxUcgenAlan.Text = alan.ToString();
            }
        }

        private void buttonParalelkenar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxParalelKenarTaban.Text) || string.IsNullOrWhiteSpace(textBoxParalelKenarYukseklik.Text))
            {
                MessageBox.Show("Lütfen Gerekli Yerleri Doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double kenarYukseklik2 = Convert.ToDouble(textBoxParalelKenarYukseklik.Text);
                double kenarTaban2 = Convert.ToDouble(textBoxParalelKenarTaban.Text);

                double alan = kenarYukseklik2 * kenarTaban2;

                textBoxParalelkenarAlan.Text = alan.ToString();
            }
        }

        private void buttonDaire_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDaireYarıÇap.Text))
            {
                MessageBox.Show("Lütfen Yarıçap uzunluğunu giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double Yaricap = Convert.ToDouble(textBoxDaireYarıÇap.Text);

                double alan = Yaricap * 3.14;   //Yarı çap  X Pi sayısı ortalama

                textBoxDaireAlan.Text = alan.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //BU FORMU GİZLER
            MatematikseİslemlerProje frmAnaForm = new MatematikseİslemlerProje(); //form2 yi kullanabiliriz.
            frmAnaForm.Show(); // form2 yi gösterir
        }

        private void Geometrikİslemler_Load(object sender, EventArgs e)
        {

        }
    }
}
   