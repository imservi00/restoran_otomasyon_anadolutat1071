using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestoranOtomasyonu
{
    public partial class GunSonuRaporuEkrani : Form
    {
        private SqlConnection connection;

        public GunSonuRaporuEkrani()
        {
            InitializeComponent();
            string connectionString = "Server=DESKTOP-TVLOELVDatabase=RestoranDB;Trusted_Connection=True;";
            connection = new SqlConnection(connectionString);
        }

        private void GunSonuRaporuEkrani_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT MasaID, BaşlangıçZamanı, BitişZamanı, ToplamTutar, ToplamSiparişler FROM GünSonuRaporları";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                lvRapor.Columns.Clear();
                lvRapor.Items.Clear();
                lvRapor.Columns.Add("Masa ID", 100);
                lvRapor.Columns.Add("Başlangıç Zamanı", 150);
                lvRapor.Columns.Add("Bitiş Zamanı", 150);
                lvRapor.Columns.Add("Toplam Tutar", 100);
                lvRapor.Columns.Add("Toplam Siparişler", 300);

                decimal toplamCiro = 0;

                while (reader.Read())
                {
                    int masaID = reader.GetInt32(0);
                    DateTime başlangıçZamanı = reader.GetDateTime(1);
                    DateTime bitişZamanı = reader.GetDateTime(2);
                    decimal toplamTutar = reader.GetDecimal(3);
                    string toplamSiparişler = reader.GetString(4);

                    ListViewItem item = new ListViewItem(masaID.ToString());
                    item.SubItems.Add(başlangıçZamanı.ToString());
                    item.SubItems.Add(bitişZamanı.ToString());
                    item.SubItems.Add(toplamTutar.ToString());
                    item.SubItems.Add(toplamSiparişler);
                    lvRapor.Items.Add(item);

                    toplamCiro += toplamTutar;
                }

                reader.Close();
                lblCiro.Text = "Toplam Ciro: " + toplamCiro.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
