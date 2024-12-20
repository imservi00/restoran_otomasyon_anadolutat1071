namespace AnadoluTat1071RestoranOtomasyonu
{
    partial class MasaEkrani
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView lvAlinanSiparisler;
        private System.Windows.Forms.GroupBox gbOdemeYontemleri;
        private System.Windows.Forms.Button btnNakit;
        private System.Windows.Forms.Button btnKart;
        private System.Windows.Forms.Button btnSiparisEkle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lvAlinanSiparisler = new ListView();
            gbOdemeYontemleri = new GroupBox();
            btnNakit = new Button();
            btnKart = new Button();
            btnSiparisEkle = new Button();
            gbOdemeYontemleri.SuspendLayout();
            SuspendLayout();
            // 
            // lvAlinanSiparisler
            // 
            lvAlinanSiparisler.Location = new Point(12, 15);
            lvAlinanSiparisler.Margin = new Padding(3, 4, 3, 4);
            lvAlinanSiparisler.Name = "lvAlinanSiparisler";
            lvAlinanSiparisler.Size = new Size(400, 532);
            lvAlinanSiparisler.TabIndex = 0;
            lvAlinanSiparisler.UseCompatibleStateImageBehavior = false;
            lvAlinanSiparisler.View = View.Details;
            // 
            // gbOdemeYontemleri
            // 
            gbOdemeYontemleri.Controls.Add(btnNakit);
            gbOdemeYontemleri.Controls.Add(btnKart);
            gbOdemeYontemleri.Location = new Point(420, 360);
            gbOdemeYontemleri.Margin = new Padding(3, 4, 3, 4);
            gbOdemeYontemleri.Name = "gbOdemeYontemleri";
            gbOdemeYontemleri.Padding = new Padding(3, 4, 3, 4);
            gbOdemeYontemleri.Size = new Size(200, 188);
            gbOdemeYontemleri.TabIndex = 1;
            gbOdemeYontemleri.TabStop = false;
            gbOdemeYontemleri.Text = "Ödeme Yöntemleri";
            // 
            // btnNakit
            // 
            btnNakit.Location = new Point(6, 38);
            btnNakit.Margin = new Padding(3, 4, 3, 4);
            btnNakit.Name = "btnNakit";
            btnNakit.Size = new Size(188, 62);
            btnNakit.TabIndex = 0;
            btnNakit.Text = "Nakit";
            btnNakit.UseVisualStyleBackColor = true;
            btnNakit.Click += BtnNakit_Click;
            // 
            // btnKart
            // 
            btnKart.Location = new Point(6, 108);
            btnKart.Margin = new Padding(3, 4, 3, 4);
            btnKart.Name = "btnKart";
            btnKart.Size = new Size(188, 62);
            btnKart.TabIndex = 1;
            btnKart.Text = "Kart";
            btnKart.UseVisualStyleBackColor = true;
            btnKart.Click += BtnKart_Click;
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.Location = new Point(420, 15);
            btnSiparisEkle.Margin = new Padding(3, 4, 3, 4);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(200, 62);
            btnSiparisEkle.TabIndex = 2;
            btnSiparisEkle.Text = "Sipariş Ekle";
            btnSiparisEkle.UseVisualStyleBackColor = true;
            btnSiparisEkle.Click += BtnSiparisEkle_Click;
            // 
            // MasaEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 562);
            Controls.Add(btnSiparisEkle);
            Controls.Add(gbOdemeYontemleri);
            Controls.Add(lvAlinanSiparisler);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MasaEkrani";
            Text = "MasaEkrani";
            Load += MasaEkrani_Load;
            gbOdemeYontemleri.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}