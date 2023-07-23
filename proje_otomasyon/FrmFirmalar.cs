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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        void FirmaListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        void temizle()
        {
            TxtAd.Text = "";
            TxtId.Text = "";
            TxtMail.Text = "";
            TxtSektor.Text = "";
            TxtVergiDaire.Text = "";
            TxtYetkili.Text = "";
            TxtYetkiliGorev.Text = "";
            Cmbil.Text = "";
            Cmbilce.Text = "";
            MskFax.Text = "";
            MskTel1.Text = "";
            MskTel2.Text = "";
            MskTel3.Text = "";
            MskTC.Text = "";
            RchAdres.Text = "";
            TxtAd.Focus();
            
               
        }

        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select Sehır From TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();// dataları okuyacağız
            while (dr.Read())
            {
                Cmbil.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        //void CariKodAciklamalar()
        //{
        //    SqlCommand komut = new SqlCommand("Select FIRMAKOD1 From TBL_KODLAR", bgl.baglanti());
        //    SqlDataReader dr = komut.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        RchKod1.Text = dr[0].ToString();
        //    }
        //    bgl.baglanti().Close();

        //}
        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            FirmaListesi();
            temizle();
            sehirListesi();
            //CariKodAciklamalar();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //imlec satırı değiştiği zaman ne olsun
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle); //focus row handle fareyle imlecin seçtiği satır.
            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtAd.Text = dr["AD"].ToString();
                TxtYetkiliGorev.Text = dr["YETKILISTATU"].ToString();
                TxtYetkili.Text = dr["YETKILIADSOYAD"].ToString();
                MskTC.Text = dr["YETKILITC"].ToString();
                TxtSektor.Text = dr["SEKTOR"].ToString();
                MskTel1.Text = dr["TELEFON1"].ToString();
                MskTel2.Text = dr["TELEFON2"].ToString();
                MskTel3.Text = dr["TELEFON3"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                MskFax.Text = dr["FAX"].ToString();
                Cmbil.Text = dr["IL"].ToString();
                Cmbilce.Text = dr["ILCE"].ToString();
                TxtVergiDaire.Text = dr["VERGIDAIRE"].ToString();
                RchAdres.Text = dr["ADRES"].ToString();
                
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_FIRMALAR(AD,YETKILISTATU,YETKILIADSOYAD,YETKILITC,SEKTOR,TELEFON1,TELEFON2," +
             "TELEFON3,MAIL,FAX,IL,ILCE,VERGIDAIRE,ADRES) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtYetkiliGorev.Text);
            komut.Parameters.AddWithValue("@p3", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@p4", MskTC.Text);
            komut.Parameters.AddWithValue("@p5", TxtSektor.Text);
            komut.Parameters.AddWithValue("@p6", MskTel1.Text);
            komut.Parameters.AddWithValue("@p7", MskTel2.Text);
            komut.Parameters.AddWithValue("@p8", MskTel3.Text);
            komut.Parameters.AddWithValue("@p9", TxtMail.Text); 
            komut.Parameters.AddWithValue("@p10", MskFax.Text);
            komut.Parameters.AddWithValue("@p11", Cmbil.Text);
            komut.Parameters.AddWithValue("@p12", Cmbilce.Text);
            komut.Parameters.AddWithValue("@p13", TxtVergiDaire.Text);
            komut.Parameters.AddWithValue("@p14", RchAdres.Text);
           
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Sisteme Kaydedildi. ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FirmaListesi();
            temizle();
            
        }

        private void Cmbil_Properties_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmbilce.Properties.Items.Clear();//temizlemesi için 
            SqlCommand komut = new SqlCommand("Select Ilce From TBL_ILCELER where Sehır=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Cmbil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbilce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Firmayı silmek istediğinize emin misiniz?", "Uyarı", 
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (secenek == DialogResult.Yes)
            {
                //Veritabanına kayıt ekleyen kodlar
                SqlCommand komut = new SqlCommand("Delete From TBL_FIRMALAR where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtId.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                FirmaListesi();
                MessageBox.Show("Firma listeden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                temizle();

            }
            else if (secenek == DialogResult.No)
            {
            }
            else if (secenek == DialogResult.Cancel)
            {
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
           

            DialogResult secenek = MessageBox.Show("Firma bilgilerini güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (secenek == DialogResult.Yes)
            {
                //Veritabanına kayıt güncelleyen kodlar
                SqlCommand komut = new SqlCommand("Update TBL_FIRMALAR set AD=@p1,YETKILISTATU=@p2,YETKILIADSOYAD=@p3,YETKILITC=@p4,SEKTOR=@p5,TELEFON1=@p6,TELEFON2=@p7,TELEFON3=@p8,MAIL=@p9,FAX=@p10,IL=@p11,ILCE=@p12,VERGIDAIRE=@p13,ADRES=@p14 where ID=@p15", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtYetkiliGorev.Text);
                komut.Parameters.AddWithValue("@p3", TxtYetkili.Text);
                komut.Parameters.AddWithValue("@p4", MskTC.Text);
                komut.Parameters.AddWithValue("@p5", TxtSektor.Text);
                komut.Parameters.AddWithValue("@p6", MskTel1.Text);
                komut.Parameters.AddWithValue("@p7", MskTel2.Text);
                komut.Parameters.AddWithValue("@p8", MskTel3.Text);
                komut.Parameters.AddWithValue("@p9", TxtMail.Text);
                komut.Parameters.AddWithValue("@p10", MskFax.Text);
                komut.Parameters.AddWithValue("@p11", Cmbil.Text);
                komut.Parameters.AddWithValue("@p12", Cmbilce.Text);
                komut.Parameters.AddWithValue("@p13", TxtVergiDaire.Text);
                komut.Parameters.AddWithValue("@p14", RchAdres.Text);
               
                komut.Parameters.AddWithValue("@p15", TxtId.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Firma Bilgileri Güncellendi. ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FirmaListesi();
                temizle();

            }
            else if (secenek == DialogResult.No)
            {
                //Hayır seçeneğine tıklandığında çalıştırılacak kodlar



            }
            else if (secenek == DialogResult.Cancel)
            {
                //code for Cancel
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void MskTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
