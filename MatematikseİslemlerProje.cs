namespace mat2_projee
{
    public partial class MatematikseİslemlerProje : Form
    {
        public MatematikseİslemlerProje()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); //BU FORMU GİZLER
            AğırlıkHesaplama frmAnaForm = new AğırlıkHesaplama(); //form2 yi kullanabiliriz.
            frmAnaForm.Show(); // form2 yi gösterir
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //BU FORMU GİZLER
            HesapMakinesi frmAnaForm = new HesapMakinesi(); //form2 yi kullanabiliriz.
            frmAnaForm.Show(); // form2 yi gösterir
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); //BU FORMU GİZLER
            Geometrikİslemler frmAnaForm = new Geometrikİslemler(); //form2 yi kullanabiliriz.
            frmAnaForm.Show(); // form2 yi gösterir
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide(); //BU FORMU GİZLER
            FonksiyonHesaplama frmAnaForm = new FonksiyonHesaplama(); //form2 yi kullanabiliriz.
            frmAnaForm.Show(); // form2 yi gösterir
        }

        private void MatematikseİslemlerProje_Load(object sender, EventArgs e)
        {

        }
    }
}
