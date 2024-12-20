namespace AnadoluTat1071RestoranOtomasyonu
{
    partial class UrunEkrani
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flpIcecekler;
        private System.Windows.Forms.FlowLayoutPanel flpYemekler;
        private System.Windows.Forms.Button btnSiparisTamamla;
        private System.Windows.Forms.ListBox lstSiparisListesi;

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
            flpIcecekler = new FlowLayoutPanel();
            flpYemekler = new FlowLayoutPanel();
            btnSiparisTamamla = new Button();
            lstSiparisListesi = new ListBox();
            SuspendLayout();
            // 
            // flpIcecekler
            // 
            flpIcecekler.AutoScroll = true;
            flpIcecekler.Location = new Point(12, 15);
            flpIcecekler.Margin = new Padding(3, 4, 3, 4);
            flpIcecekler.Name = "flpIcecekler";
            flpIcecekler.Size = new Size(380, 750);
            flpIcecekler.TabIndex = 0;
            // 
            // flpYemekler
            // 
            flpYemekler.AutoScroll = true;
            flpYemekler.Location = new Point(400, 15);
            flpYemekler.Margin = new Padding(3, 4, 3, 4);
            flpYemekler.Name = "flpYemekler";
            flpYemekler.Size = new Size(380, 750);
            flpYemekler.TabIndex = 1;
            // 
            // btnSiparisTamamla
            // 
            btnSiparisTamamla.Location = new Point(12, 775);
            btnSiparisTamamla.Margin = new Padding(3, 4, 3, 4);
            btnSiparisTamamla.Name = "btnSiparisTamamla";
            btnSiparisTamamla.Size = new Size(768, 62);
            btnSiparisTamamla.TabIndex = 2;
            btnSiparisTamamla.Text = "Siparişi Tamamla";
            btnSiparisTamamla.UseVisualStyleBackColor = true;
            btnSiparisTamamla.Click += BtnSiparisTamamla_Click;
            // 
            // lstSiparisListesi
            // 
            lstSiparisListesi.FormattingEnabled = true;
            lstSiparisListesi.Location = new Point(12, 850);
            lstSiparisListesi.Margin = new Padding(3, 4, 3, 4);
            lstSiparisListesi.Name = "lstSiparisListesi";
            lstSiparisListesi.Size = new Size(768, 204);
            lstSiparisListesi.TabIndex = 3;
            // 
            // UrunEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 1055);
            Controls.Add(lstSiparisListesi);
            Controls.Add(btnSiparisTamamla);
            Controls.Add(flpYemekler);
            Controls.Add(flpIcecekler);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UrunEkrani";
            Text = "Ürün Ekranı";
            WindowState = FormWindowState.Maximized;
            Load += UrunEkrani_Load;
            ResumeLayout(false);
        }
    }
}
