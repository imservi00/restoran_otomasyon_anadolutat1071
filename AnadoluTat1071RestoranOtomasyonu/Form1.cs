using AnadoluTat1071RestoranOtomasyonu;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestoranOtomasyonu
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            string connectionString = "Server=DESKTOP-GE9UJQI;Database=RestoranDB;Trusted_Connection=True;";
            connection = new SqlConnection(connectionString);
            MasaDurumlarýnýYukle();
        }

        private void MasaDurumlarýnýYukle()
        {
            try
            {
                connection.Open();
                string query = "SELECT MasaID, Durum FROM Masalar";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int masaNo = reader.GetInt32(0);
                    string durum = reader.GetString(1);

                    // Button'ý bulup duruma göre renk ayarla
                    Button btn = this.Controls.Find("btnMasa" + masaNo, true)[0] as Button;
                    if (durum == "Dolu")
                    {
                        btn.BackColor = System.Drawing.Color.Red;  // Dolu ise kýrmýzý
                    }
                    else
                    {
                        btn.BackColor = System.Drawing.Color.Green;  // Boþ ise yeþil
                    }
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

        private void MasaButonu_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int masaNo = int.Parse(clickedButton.Text.Replace("Masa ", ""));
            MasaEkrani masaEkrani = new MasaEkrani(masaNo);
            masaEkrani.ShowDialog();
            MasaDurumlarýnýYukle();  // Masa durumlarýný güncelle
        }

        // Gün sonu raporu butonu
        private void BtnGunSonu_Click(object sender, EventArgs e)
        {
            // Gün sonu iþlemleri burada yapýlabilir.
            MessageBox.Show("Gün Sonu Raporu");
        }
    }
}
