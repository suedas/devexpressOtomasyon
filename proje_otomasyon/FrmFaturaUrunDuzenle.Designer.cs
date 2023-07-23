
namespace proje_otomasyon
{
    partial class FrmFaturaUrunDuzenle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaUrunDuzenle));
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.TxtMiktar = new DevExpress.XtraEditors.TextEdit();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtUrunId = new DevExpress.XtraEditors.TextEdit();
            this.TxtUrunAd = new DevExpress.XtraEditors.TextEdit();
            this.TxtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.TxtTutar = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTutar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(55, 70);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(58, 18);
            this.labelControl7.TabIndex = 43;
            this.labelControl7.Text = "Ürün Ad:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(55, 100);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(44, 18);
            this.labelControl10.TabIndex = 44;
            this.labelControl10.Text = "Miktar:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(55, 40);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(65, 18);
            this.labelControl6.TabIndex = 42;
            this.labelControl6.Text = "URUN ID:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(55, 130);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(36, 18);
            this.labelControl11.TabIndex = 45;
            this.labelControl11.Text = "Fiyat:";
            // 
            // TxtMiktar
            // 
            this.TxtMiktar.Location = new System.Drawing.Point(134, 97);
            this.TxtMiktar.Name = "TxtMiktar";
            this.TxtMiktar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMiktar.Properties.Appearance.Options.UseFont = true;
            this.TxtMiktar.Size = new System.Drawing.Size(173, 24);
            this.TxtMiktar.TabIndex = 46;
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(134, 251);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(144, 40);
            this.BtnSil.TabIndex = 48;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(134, 205);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(144, 40);
            this.BtnGuncelle.TabIndex = 49;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(55, 160);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 18);
            this.labelControl1.TabIndex = 51;
            this.labelControl1.Text = "Tutar:";
            // 
            // TxtUrunId
            // 
            this.TxtUrunId.Location = new System.Drawing.Point(134, 37);
            this.TxtUrunId.Name = "TxtUrunId";
            this.TxtUrunId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUrunId.Properties.Appearance.Options.UseFont = true;
            this.TxtUrunId.Size = new System.Drawing.Size(173, 24);
            this.TxtUrunId.TabIndex = 53;
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.Location = new System.Drawing.Point(134, 67);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUrunAd.Properties.Appearance.Options.UseFont = true;
            this.TxtUrunAd.Size = new System.Drawing.Size(173, 24);
            this.TxtUrunAd.TabIndex = 54;
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Location = new System.Drawing.Point(134, 127);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtFiyat.Properties.Appearance.Options.UseFont = true;
            this.TxtFiyat.Size = new System.Drawing.Size(173, 24);
            this.TxtFiyat.TabIndex = 55;
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(134, 157);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTutar.Properties.Appearance.Options.UseFont = true;
            this.TxtTutar.Size = new System.Drawing.Size(173, 24);
            this.TxtTutar.TabIndex = 56;
            // 
            // FrmFaturaUrunDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 334);
            this.Controls.Add(this.TxtTutar);
            this.Controls.Add(this.TxtFiyat);
            this.Controls.Add(this.TxtUrunAd);
            this.Controls.Add(this.TxtUrunId);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.TxtMiktar);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl7);
            this.Name = "FrmFaturaUrunDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FATURA ÜRÜN DÜZENLEME";
            this.Load += new System.EventHandler(this.FrmFaturaUrunDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTutar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit TxtMiktar;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtUrunId;
        private DevExpress.XtraEditors.TextEdit TxtUrunAd;
        private DevExpress.XtraEditors.TextEdit TxtFiyat;
        private DevExpress.XtraEditors.TextEdit TxtTutar;
    }
}