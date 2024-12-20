namespace RestoranOtomasyonu
{
    partial class GunSonuRaporuEkrani
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView lvRapor;
        private System.Windows.Forms.Label lblCiro;

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
            this.lvRapor = new System.Windows.Forms.ListView();
            this.lblCiro = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lvRapor
            // 
            this.lvRapor.Location = new System.Drawing.Point(12, 12);
            this.lvRapor.Name = "lvRapor";
            this.lvRapor.Size = new System.Drawing.Size(600, 400);
            this.lvRapor.TabIndex = 0;
            this.lvRapor.UseCompatibleStateImageBehavior = false;
            this.lvRapor.View = System.Windows.Forms.View.Details;

            // 
            // lblCiro
            // 
            this.lblCiro.AutoSize = true;
            this.lblCiro.Location = new System.Drawing.Point(12, 420);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Size = new System.Drawing.Size(0, 17);
            this.lblCiro.TabIndex = 1;

            // 
            // GunSonuRaporuEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.lblCiro);
            this.Controls.Add(this.lvRapor);
            this.Name = "GunSonuRaporuEkrani";
            this.Text = "GunSonuRaporuEkrani";
            this.Load += new System.EventHandler(this.GunSonuRaporuEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
