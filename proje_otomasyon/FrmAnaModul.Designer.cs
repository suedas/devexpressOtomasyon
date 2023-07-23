
namespace proje_otomasyon
{
    partial class FrmAnaModul
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaModul));
            this.ribbonControl2 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnAnaSayfa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnUrunler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnStoklar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMusteriler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnFirmalar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPersonel = new DevExpress.XtraBars.BarButtonItem();
            this.BtnGider = new DevExpress.XtraBars.BarButtonItem();
            this.BtnKasa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnNotlar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnBanka = new DevExpress.XtraBars.BarButtonItem();
            this.BtnRehber = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem24 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnFatura = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAyarlar = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Hareketler = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Raporlar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl2
            // 
            this.ribbonControl2.ExpandCollapseItem.Id = 0;
            this.ribbonControl2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl2.ExpandCollapseItem,
            this.ribbonControl2.SearchEditItem,
            this.BtnAnaSayfa,
            this.BtnUrunler,
            this.BtnStoklar,
            this.BtnMusteriler,
            this.BtnFirmalar,
            this.BtnPersonel,
            this.BtnGider,
            this.BtnKasa,
            this.BtnNotlar,
            this.BtnBanka,
            this.BtnRehber,
            this.barButtonItem24,
            this.BtnFatura,
            this.BtnAyarlar,
            this.Btn_Hareketler,
            this.Btn_Raporlar});
            this.ribbonControl2.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl2.MaxItemId = 17;
            this.ribbonControl2.Name = "ribbonControl2";
            this.ribbonControl2.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
            this.ribbonControl2.Size = new System.Drawing.Size(1370, 150);
            this.ribbonControl2.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // BtnAnaSayfa
            // 
            this.BtnAnaSayfa.Caption = "ANA SAYFA";
            this.BtnAnaSayfa.Id = 1;
            this.BtnAnaSayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnaSayfa.ImageOptions.Image")));
            this.BtnAnaSayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAnaSayfa.ImageOptions.LargeImage")));
            this.BtnAnaSayfa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAnaSayfa.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnAnaSayfa.Name = "BtnAnaSayfa";
            this.BtnAnaSayfa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAnaSayfa_ItemClick);
            // 
            // BtnUrunler
            // 
            this.BtnUrunler.Caption = "ÜRÜNLER";
            this.BtnUrunler.Id = 2;
            this.BtnUrunler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunler.ImageOptions.Image")));
            this.BtnUrunler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnUrunler.ImageOptions.LargeImage")));
            this.BtnUrunler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnUrunler.Name = "BtnUrunler";
            this.BtnUrunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnUrunler_ItemClick);
            // 
            // BtnStoklar
            // 
            this.BtnStoklar.Caption = "STOKLAR";
            this.BtnStoklar.Id = 3;
            this.BtnStoklar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnStoklar.ImageOptions.Image")));
            this.BtnStoklar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnStoklar.ImageOptions.LargeImage")));
            this.BtnStoklar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnStoklar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnStoklar.Name = "BtnStoklar";
            this.BtnStoklar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnStoklar_ItemClick);
            // 
            // BtnMusteriler
            // 
            this.BtnMusteriler.Caption = "MÜŞTERİLER";
            this.BtnMusteriler.Id = 4;
            this.BtnMusteriler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMusteriler.ImageOptions.Image")));
            this.BtnMusteriler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnMusteriler.ImageOptions.LargeImage")));
            this.BtnMusteriler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteriler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnMusteriler.Name = "BtnMusteriler";
            this.BtnMusteriler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMusteriler_ItemClick);
            // 
            // BtnFirmalar
            // 
            this.BtnFirmalar.Caption = "FİRMALAR";
            this.BtnFirmalar.Id = 5;
            this.BtnFirmalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnFirmalar.ImageOptions.Image")));
            this.BtnFirmalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnFirmalar.ImageOptions.LargeImage")));
            this.BtnFirmalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFirmalar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnFirmalar.Name = "BtnFirmalar";
            this.BtnFirmalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnFirmalar_ItemClick);
            // 
            // BtnPersonel
            // 
            this.BtnPersonel.Caption = "PERSONELLER";
            this.BtnPersonel.Id = 6;
            this.BtnPersonel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersonel.ImageOptions.Image")));
            this.BtnPersonel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnPersonel.ImageOptions.LargeImage")));
            this.BtnPersonel.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPersonel.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnPersonel.Name = "BtnPersonel";
            this.BtnPersonel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPersonel_ItemClick);
            // 
            // BtnGider
            // 
            this.BtnGider.Caption = "GİDERLER";
            this.BtnGider.Id = 7;
            this.BtnGider.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGider.ImageOptions.Image")));
            this.BtnGider.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnGider.ImageOptions.LargeImage")));
            this.BtnGider.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGider.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnGider.Name = "BtnGider";
            this.BtnGider.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGider_ItemClick);
            // 
            // BtnKasa
            // 
            this.BtnKasa.Caption = "KASA";
            this.BtnKasa.Id = 8;
            this.BtnKasa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKasa.ImageOptions.Image")));
            this.BtnKasa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnKasa.ImageOptions.LargeImage")));
            this.BtnKasa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKasa.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnKasa.Name = "BtnKasa";
            this.BtnKasa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnKasa_ItemClick);
            // 
            // BtnNotlar
            // 
            this.BtnNotlar.Caption = "NOTLAR";
            this.BtnNotlar.Id = 9;
            this.BtnNotlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNotlar.ImageOptions.Image")));
            this.BtnNotlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnNotlar.ImageOptions.LargeImage")));
            this.BtnNotlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnNotlar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnNotlar.Name = "BtnNotlar";
            this.BtnNotlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnNotlar_ItemClick);
            // 
            // BtnBanka
            // 
            this.BtnBanka.Caption = "BANKALAR";
            this.BtnBanka.Id = 10;
            this.BtnBanka.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnBanka.ImageOptions.Image")));
            this.BtnBanka.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnBanka.ImageOptions.LargeImage")));
            this.BtnBanka.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBanka.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnBanka.Name = "BtnBanka";
            this.BtnBanka.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnBanka_ItemClick);
            // 
            // BtnRehber
            // 
            this.BtnRehber.Caption = "REHBER";
            this.BtnRehber.Id = 11;
            this.BtnRehber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnRehber.ImageOptions.Image")));
            this.BtnRehber.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnRehber.ImageOptions.LargeImage")));
            this.BtnRehber.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRehber.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnRehber.Name = "BtnRehber";
            this.BtnRehber.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnRehber_ItemClick);
            // 
            // barButtonItem24
            // 
            this.barButtonItem24.Caption = "barButtonItem24";
            this.barButtonItem24.Id = 12;
            this.barButtonItem24.Name = "barButtonItem24";
            // 
            // BtnFatura
            // 
            this.BtnFatura.Caption = "FATURALAR";
            this.BtnFatura.Id = 13;
            this.BtnFatura.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnFatura.ImageOptions.Image")));
            this.BtnFatura.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnFatura.ImageOptions.LargeImage")));
            this.BtnFatura.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFatura.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnFatura.Name = "BtnFatura";
            this.BtnFatura.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnFatura_ItemClick);
            // 
            // BtnAyarlar
            // 
            this.BtnAyarlar.Caption = "AYARLAR";
            this.BtnAyarlar.Id = 14;
            this.BtnAyarlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAyarlar.ImageOptions.Image")));
            this.BtnAyarlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAyarlar.ImageOptions.LargeImage")));
            this.BtnAyarlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAyarlar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnAyarlar.Name = "BtnAyarlar";
            this.BtnAyarlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAyarlar_ItemClick);
            // 
            // Btn_Hareketler
            // 
            this.Btn_Hareketler.Caption = "HAREKETLER";
            this.Btn_Hareketler.Id = 15;
            this.Btn_Hareketler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Hareketler.ImageOptions.Image")));
            this.Btn_Hareketler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Hareketler.ImageOptions.LargeImage")));
            this.Btn_Hareketler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Hareketler.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_Hareketler.Name = "Btn_Hareketler";
            this.Btn_Hareketler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Hareketler_ItemClick);
            // 
            // Btn_Raporlar
            // 
            this.Btn_Raporlar.Caption = "RAPORLAR";
            this.Btn_Raporlar.Id = 16;
            this.Btn_Raporlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Raporlar.ImageOptions.Image")));
            this.Btn_Raporlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Raporlar.ImageOptions.LargeImage")));
            this.Btn_Raporlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Raporlar.ItemAppearance.Normal.Options.UseFont = true;
            this.Btn_Raporlar.Name = "Btn_Raporlar";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "SARIASLAN GARAGE";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnAnaSayfa);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnUrunler);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnMusteriler);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnFirmalar);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnPersonel);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnStoklar);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnGider);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnKasa);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnBanka);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnFatura);
            this.ribbonPageGroup2.ItemLinks.Add(this.Btn_Hareketler);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnNotlar);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnRehber);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnAyarlar);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmAnaModul
            // 
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.ribbonControl2);
            this.IsMdiContainer = true;
            this.Name = "FrmAnaModul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAnaModul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl2;
        private DevExpress.XtraBars.BarButtonItem BtnAnaSayfa;
        private DevExpress.XtraBars.BarButtonItem BtnUrunler;
        private DevExpress.XtraBars.BarButtonItem BtnStoklar;
        private DevExpress.XtraBars.BarButtonItem BtnMusteriler;
        private DevExpress.XtraBars.BarButtonItem BtnFirmalar;
        private DevExpress.XtraBars.BarButtonItem BtnPersonel;
        private DevExpress.XtraBars.BarButtonItem BtnGider;
        private DevExpress.XtraBars.BarButtonItem BtnKasa;
        private DevExpress.XtraBars.BarButtonItem BtnNotlar;
        private DevExpress.XtraBars.BarButtonItem BtnBanka;
        private DevExpress.XtraBars.BarButtonItem BtnRehber;
        private DevExpress.XtraBars.BarButtonItem barButtonItem24;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem BtnFatura;
        private DevExpress.XtraBars.BarButtonItem BtnAyarlar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem Btn_Hareketler;
        private DevExpress.XtraBars.BarButtonItem Btn_Raporlar;
    }
}

