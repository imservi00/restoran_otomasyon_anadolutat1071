using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AnadoluTat1071RestoranOtomasyonu
{
    public partial class MasaEkrani : Form
    {
        private int masaNo;
        private SqlConnection connection;

        public MasaEkrani(int masaNo)
        {
            InitializeComponent();
            this.masaNo = masaNo;
            string connectionString = "Server=DESKTOP-TVLOELV;Database=RestoranDB;Trusted_Connection=True;";
            connection = new SqlConnection(connectionString);
            SiparisleriYukle();
        }

        private void SiparisleriYukle()
        {
            try
            {
                connection.Open();
                string query = "SELECT u.ÜrünAdı, s.SiparişZamanı, s.Miktar FROM Siparişler s JOIN Ürünler u ON s.ÜrünID = u.ÜrünID WHERE s.MasaID = @MasaID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MasaID", masaNo);
                SqlDataReader reader = command.ExecuteReader();

                lvAlinanSiparisler.Columns.Clear();
                lvAlinanSiparisler.Items.Clear();
                lvAlinanSiparisler.Columns.Add("Ürün Adı", 150);
                lvAlinanSiparisler.Columns.Add("Sipariş Zamanı", 150);
                lvAlinanSiparisler.Columns.Add("Miktar", 100);

                while (reader.Read())
                {
                    string urunAdi = reader.GetString(0);
                    DateTime siparisZamani = reader.GetDateTime(1);
                    int miktar = reader.GetInt32(2);

                    ListViewItem item = new ListViewItem(urunAdi);
                    item.SubItems.Add(siparisZamani.ToString());
                    item.SubItems.Add(miktar.ToString());
                    lvAlinanSiparisler.Items.Add(item);
                }

                reader.Close();
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

        private void BtnSiparisEkle_Click(object sender, EventArgs e)
        {
            UrunEkrani urunEkrani = new UrunEkrani(masaNo);
            urunEkrani.ShowDialog();
            SiparisleriYukle(); // Siparişler eklendikten sonra güncelle
            MasaDurumunuGuncelle();
        }

        private void MasaDurumunuGuncelle()
        {
            try
            {
                connection.Open();
                string query = "UPDATE Masalar SET Durum = 'Dolu' WHERE MasaID = @MasaID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MasaID", masaNo);
                command.ExecuteNonQuery();
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

        private void BtnNakit_Click(object sender, EventArgs e)
        {
            OdemeYap(masaNo, "Nakit");
        }

        private void BtnKart_Click(object sender, EventArgs e)
        {
            OdemeYap(masaNo, "Kart");
        }

        private void OdemeYap(int masaNo, string odemeTuru)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection("Server=DESKTOP-TVLOELV;Database=RestoranDB;Trusted_Connection=True;"))
                {
                    connection.Open();

                    // Masanın durumu 'Boş
                    string query = "UPDATE Masalar SET Durum = 'Boş' WHERE MasaID = @MasaNo";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MasaNo", masaNo);
                    command.ExecuteNonQuery();


                    MasaDurumunuYeşilYap(masaNo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void MasaDurumunuYeşilYap(int masaNo)
        {
            try
            {
                connection.Open();
                // Masanın durumu 'Boş' ise masa rengini yeşil yaparız
                string query = "UPDATE Masalar SET Durum = 'Boş' WHERE MasaID = @MasaID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MasaID", masaNo);
                command.ExecuteNonQuery();

                // Masa butonunun rengini yeşil yapmak için
                Button masaButonu = this.Controls.Find("btnMasa" + masaNo, true)[0] as Button;
                if (masaButonu != null)
                {
                    masaButonu.BackColor = System.Drawing.Color.Green;
                }
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

        private void MasaEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
