using System.Data.SqlClient;

namespace KutuphaneYonetimSistemi
{
    public partial class FormGiris : Form
    {
        FormKitaplar formKitaplar;
        public FormGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LENOVOLEGION5\SQLEXPRESS;Initial Catalog=DbYTAKutuphane;Integrated Security=True");
        private void buttonGiris_Click(object sender, EventArgs e)
        {
            string sifre = "";
            try
            {
                baglanti.Open();
                SqlCommand sqlKomut = new SqlCommand("SELECT Sifre FROM TableKutuphaneYoneticileri WHERE KullaniciAdi = @p1", baglanti);
                sqlKomut.Parameters.AddWithValue("@p1", textBoxKullaniciAdi.Text);
                SqlDataReader sqlDataReader = sqlKomut.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    sifre = sqlDataReader[0].ToString();
                }
                //label3.Text = sifre;
                if (sifre == textBoxSifre.Text)
                {              
                    formKitaplar = new FormKitaplar();
                    this.Hide();
                    formKitaplar.Show();

                        }
             else
                {
                    MessageBox.Show("Kullanici Adi veya Sifre Hatali ! ");
                    textBoxKullaniciAdi.Text = "";
                    textBoxSifre.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Baglanti hatasi! " + ex.Message);
            }
            finally
            { 
                baglanti.Close();
            }
        }
    }
}
