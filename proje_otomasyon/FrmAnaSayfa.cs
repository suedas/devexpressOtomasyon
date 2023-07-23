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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        void stoklar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select URUNAD, sum(ADET) as 'Adet' From TBL_URUNLER group by URUNAD " +
                "having sum(ADET)<=20 order by sum(ADET)", bgl.baglanti());
            da.Fill(dt);
            GrdControlStoklar.DataSource = dt;
        }

        void ajanda()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select TOP 10 TARIH,SAAT, BASLIK From TBL_NOTLAR order by ID desc", bgl.baglanti());
            da.Fill(dt);
            GrdControlAjanda.DataSource = dt;
        }
        void Hareketler()
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Exec FirmaHareket2", bgl.baglanti());
            da.Fill(dt);
            GrdControlHareket.DataSource = dt;
        }
        void hizliErisim()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select AD,TELEFON1 FROM TBL_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            GrdControlErisim.DataSource = dt;

        }


        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            stoklar();
            ajanda();
            Hareketler();
            hizliErisim();
        }

       
    }
}
