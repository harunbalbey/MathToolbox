namespace mat2_projee
{
    public partial class Matematikse�slemlerProje : Form
    {
        public Matematikse�slemlerProje()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); //BU FORMU G�ZLER
            A��rl�kHesaplama frmAnaForm = new A��rl�kHesaplama(); //form2 yi kullanabiliriz.
            frmAnaForm.Show(); // form2 yi g�sterir
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //BU FORMU G�ZLER
            HesapMakinesi frmAnaForm = new HesapMakinesi(); //form2 yi kullanabiliriz.
            frmAnaForm.Show(); // form2 yi g�sterir
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); //BU FORMU G�ZLER
            Geometrik�slemler frmAnaForm = new Geometrik�slemler(); //form2 yi kullanabiliriz.
            frmAnaForm.Show(); // form2 yi g�sterir
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide(); //BU FORMU G�ZLER
            FonksiyonHesaplama frmAnaForm = new FonksiyonHesaplama(); //form2 yi kullanabiliriz.
            frmAnaForm.Show(); // form2 yi g�sterir
        }

        private void Matematikse�slemlerProje_Load(object sender, EventArgs e)
        {

        }
    }
}
