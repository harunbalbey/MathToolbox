namespace mat2_projee
{
    public partial class MatematikseÝslemlerProje : Form
    {
        public MatematikseÝslemlerProje()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); //BU FORMU GÝZLER
            AðýrlýkHesaplama frmAnaForm = new AðýrlýkHesaplama(); //form2 yi kullanabiliriz.
            frmAnaForm.Show(); // form2 yi gösterir
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //BU FORMU GÝZLER
            HesapMakinesi frmAnaForm = new HesapMakinesi(); //form2 yi kullanabiliriz.
            frmAnaForm.Show(); // form2 yi gösterir
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); //BU FORMU GÝZLER
            GeometrikÝslemler frmAnaForm = new GeometrikÝslemler(); //form2 yi kullanabiliriz.
            frmAnaForm.Show(); // form2 yi gösterir
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide(); //BU FORMU GÝZLER
            FonksiyonHesaplama frmAnaForm = new FonksiyonHesaplama(); //form2 yi kullanabiliriz.
            frmAnaForm.Show(); // form2 yi gösterir
        }

        private void MatematikseÝslemlerProje_Load(object sender, EventArgs e)
        {

        }
    }
}
