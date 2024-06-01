using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace odev
{
    public partial class Form1 : Form
    {
        private DialogResult sonuc;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kullanýcý Adý : " + txtKullaniciGirisi.Text + " - Þifre : " + txtSifre.Text);

            if (!string.IsNullOrWhiteSpace(txtKullaniciGirisi.Text))
            {
                MessageBox.Show("Merhaba " + txtKullaniciGirisi.Text);
            }
            else
            {
                MessageBox.Show("Hatalý Kullanýcý Adý veya Þifre ");
            };

                      
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çýkmak Ýstiyor musunuz ?", "Uyarý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) // MessageBoxIcon.Question : acýlan pencereye ikon eklemizi saðlar.
            {
                Close(); // formu kapat
            }
        }
 }}
