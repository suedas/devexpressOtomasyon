using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proje_otomasyon
{
    public partial class FrmKasa : Form
    {
        public FrmKasa()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        void musteriHareketleri()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute MusteriHareketler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }


        void firmaHareketleri()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("execute FirmaHareketler", bgl.baglanti());
            da2.Fill(dt2);
            gridControl3.DataSource = dt2;
        }
        void giderler()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT AY,YIL,ELEKTRIK, SU,DOGALGAZ,INTERNET, MAASLAR,EKSTRA,NOTLAR FROM TBL_GIDERLER", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }

        private void FrmKasa_Load(object sender, EventArgs e)
        {
            musteriHareketleri();
            firmaHareketleri();
            giderler();

            //toplam tutar hesaplama
            SqlCommand komut1 = new SqlCommand("select Sum(Tutar) from TBL_FATURADETAY", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblKasaToplam.Text = dr1[0].ToString() + "₺";
            }
            bgl.baglanti().Close();

            //son ayın faturaları
            SqlCommand komut2 = new SqlCommand("select (ELEKTRIK+SU+DOGALGAZ+INTERNET+EKSTRA) from TBL_GIDERLER ORDER BY ID ASC", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblOdemeler.Text = dr2[0].ToString() + "₺";
            }
            bgl.baglanti().Close();

            //son ayın personel maaşları
            SqlCommand komut3 = new SqlCommand("select MAASLAR from TBL_GIDERLER order by ID asc", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblMaas.Text = dr3[0].ToString() + "₺";
            }
            bgl.baglanti().Close();

            //toplam müşteri sayısı

            SqlCommand komut4 = new SqlCommand("select count(*) from TBL_MUSTERILER", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblMusteriSayisi.Text = dr4[0].ToString();
            }
            bgl.baglanti().Close();

            //toplam firma sayısı

            SqlCommand komut5 = new SqlCommand("select count(*) from TBL_FIRMALAR", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblFirmaSayisi.Text = dr5[0].ToString();
            }
            bgl.baglanti().Close();

            //toplam personel sayısı
            SqlCommand komut6 = new SqlCommand("select count(*) from TBL_PERSONELLER", bgl.baglanti());
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                LblPerSayisi.Text = dr6[0].ToString();
            }
            bgl.baglanti().Close();

            //toplam ürün sayısı
            SqlCommand komut7 = new SqlCommand("select sum(adet) from TBL_URUNLER", bgl.baglanti());
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                LblStok.Text = dr7[0].ToString();
            }
            bgl.baglanti().Close();

        }


        int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;

            //elektrik
            if (sayac > 0 && sayac <= 5)
            {
                //1.charta son 4 ay elektrik faturası gönderme
                groupControl8.Text = "Elektrik";
                SqlCommand komut8 = new SqlCommand("select top 4 AY,ELEKTRIK from TBL_GIDERLER order by ID desc", bgl.baglanti());
                SqlDataReader dr8 = komut8.ExecuteReader();
                while (dr8.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr8[0], dr8[1]));
                }
                bgl.baglanti().Close();
            }

            //su
            if (sayac > 5 && sayac <= 10)
            {
                groupControl8.Text = "Su";
                chartControl1.Series["Aylar"].Points.Clear();
                //charta son 4 ay su faturası gönderme
                SqlCommand komut9 = new SqlCommand("select top 4 AY,SU from TBL_GIDERLER order by ID desc", bgl.baglanti());
                SqlDataReader dr9 = komut9.ExecuteReader();
                while (dr9.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr9[0], dr9[1]));
                }
                bgl.baglanti().Close();
            }
            //doğalgaz
            if (sayac > 10 && sayac <= 15)
            {
                groupControl8.Text = "Doğalgaz";
                chartControl1.Series["Aylar"].Points.Clear();
                //charta son 4 ay su faturası gönderme
                SqlCommand komut9 = new SqlCommand("select top 4 AY,DOGALGAZ from TBL_GIDERLER order by ID desc", bgl.baglanti());
                SqlDataReader dr9 = komut9.ExecuteReader();
                while (dr9.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr9[0], dr9[1]));
                }
                bgl.baglanti().Close();
            }
            //internet
            if (sayac > 15 && sayac <= 20)
            {
                groupControl8.Text = "İnternet";
                chartControl1.Series["Aylar"].Points.Clear();
                //charta son 4 ay su faturası gönderme
                SqlCommand komut9 = new SqlCommand("select top 4 AY,INTERNET from TBL_GIDERLER order by ID desc", bgl.baglanti());
                SqlDataReader dr9 = komut9.ExecuteReader();
                while (dr9.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr9[0], dr9[1]));
                }
                bgl.baglanti().Close();
            }
            //ekstra
            if (sayac > 20 && sayac <= 25)
            {
                groupControl8.Text = "Ekstra";
                chartControl1.Series["Aylar"].Points.Clear();
                //charta son 4 ay su faturası gönderme
                SqlCommand komut9 = new SqlCommand("select top 4 AY,EKSTRA from TBL_GIDERLER order by ID desc", bgl.baglanti());
                SqlDataReader dr9 = komut9.ExecuteReader();
                while (dr9.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr9[0], dr9[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac == 26)
            {
                sayac = 0;
            }
        }

    
        
    }
}
