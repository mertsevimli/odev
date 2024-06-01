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
            MessageBox.Show("Kullan�c� Ad� : " + txtKullaniciGirisi.Text + " - �ifre : " + txtSifre.Text);

            if (!string.IsNullOrWhiteSpace(txtKullaniciGirisi.Text))
            {
                MessageBox.Show("Merhaba " + txtKullaniciGirisi.Text);
            }
            else
            {
                MessageBox.Show("Hatal� Kullan�c� Ad� veya �ifre ");
            };

                      
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("��kmak �stiyor musunuz ?", "Uyar�!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) // MessageBoxIcon.Question : ac�lan pencereye ikon eklemizi sa�lar.
            {
                Close(); // formu kapat
            }
        }
 }}
