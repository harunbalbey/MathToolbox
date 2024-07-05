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





    public partial class HesapMakinesi : Form
    {
        public HesapMakinesi()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        double sonuc = 0;
        string islem = "";
        bool islemYapildi = false;

        private void btnSayi_Click(object sender, EventArgs e)
        {
            if ((textBoxSonuc.Text == "0") || (islemYapildi))
                textBoxSonuc.Clear();

            islemYapildi = false;
            Button button = (Button)sender;
            textBoxSonuc.Text = textBoxSonuc.Text + button.Text;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            textBoxSonuc.Text = "0";
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            switch (islem)
            {
                case "+":
                    textBoxSonuc.Text = (sonuc + Double.Parse(textBoxSonuc.Text)).ToString();
                    break;
                case "-":
                    textBoxSonuc.Text = (sonuc - Double.Parse(textBoxSonuc.Text)).ToString();
                    break;
                case "X":
                    textBoxSonuc.Text = (sonuc * Double.Parse(textBoxSonuc.Text)).ToString();
                    break;
                case "/":
                    textBoxSonuc.Text = (sonuc / Double.Parse(textBoxSonuc.Text)).ToString();
                    break;
                default:
                    break;
            }
            sonuc = Double.Parse(textBoxSonuc.Text);
            islem = "";
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            islem = button.Text;
            sonuc = Double.Parse(textBoxSonuc.Text);
            islemYapildi = true;
        }
        private void btnCikar_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            islem = button.Text;
            sonuc = Double.Parse(textBoxSonuc.Text);
            islemYapildi = true;
        }
        private void btnCarp_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            islem = button.Text;
            sonuc = Double.Parse(textBoxSonuc.Text);
            islemYapildi = true;
        }
        private void btnBol_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            islem = button.Text;
            sonuc = Double.Parse(textBoxSonuc.Text);
            islemYapildi = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); //BU FORMU GİZLER
            MatematikseİslemlerProje frmAnaForm = new MatematikseİslemlerProje(); //form2 yi kullanabiliriz.
            frmAnaForm.Show(); // form2 yi gösterir
        }
    }
}