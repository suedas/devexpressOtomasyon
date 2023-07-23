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
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }

        private void Cmbil_Properties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FATURABILGI", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            TxtAlici.Text = "";
            TxtId.Text = "";
            TxtFaturaId.Text = "";
            TxtFiyat.Text = "";
            TxtMiktar.Text = "";
            TxtSeri.Text = "";
            TxtSıraNo.Text = "";
            TxtTeslimalan.Text = "";
            TxtTeslimeden.Text = "";
            TxtTutar.Text = "";
            TxtUrunAd.Text = "";
            TxtUrunId.Text = "";
            TxtVergiDaire.Text = "";
            MskSaat.Text = "";
            MskTarih.Text = "";
            TxtId.Focus();


        }
        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtFaturaId.Text == "")
            {
                SqlCommand komut = new SqlCommand("insert into TBL_FATURABILGI(SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtSeri.Text);
                komut.Parameters.AddWithValue("@p2", TxtSıraNo.Text);
                komut.Parameters.AddWithValue("@p3", MskTarih.Text);
                komut.Parameters.AddWithValue("@p4", MskSaat.Text);
                komut.Parameters.AddWithValue("@p5", TxtVergiDaire.Text);
                komut.Parameters.AddWithValue("@p6", TxtAlici.Text);
                komut.Parameters.AddWithValue("@p7", TxtTeslimeden.Text);
                komut.Parameters.AddWithValue("@p8", TxtTeslimalan.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Bilgisi Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            // Firma carisi
            if (TxtFaturaId.Text != " " && comboBox1.Text == "Firma")
            {
                double miktar, fiyat, tutar;
                fiyat = Convert.ToDouble(TxtFiyat.Text);
                miktar = Convert.ToDouble(TxtMiktar.Text);
                tutar = miktar * fiyat;
                TxtTutar.Text = tutar.ToString();

                SqlCommand komut2 = new SqlCommand("insert into TBL_FATURADETAY(URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", TxtUrunAd.Text);
                komut2.Parameters.AddWithValue("@p2", TxtMiktar.Text);
                komut2.Parameters.AddWithValue("@p3", decimal.Parse(TxtFiyat.Text));
                komut2.Parameters.AddWithValue("@p4", decimal.Parse(TxtTutar.Text));
                komut2.Parameters.AddWithValue("@p5", TxtFaturaId.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();

                // Hareket tablosuna veri girişi
                SqlCommand komut3 = new SqlCommand("insert into TBL_FIRMAHAREKETLER (URUNID,ADET,PERSONEL,FIRMA,FIYAT,TOPLAM,FATURAID,TARIH) values (@h1,@h2,@h3,@h4,@h5,@h6,@h7,@h8)", bgl.baglanti());
                komut3.Parameters.AddWithValue("@h1", TxtUrunId.Text);
                komut3.Parameters.AddWithValue("@h2", TxtMiktar.Text);
                komut3.Parameters.AddWithValue("@h3", TxtPersonel.Text);
                komut3.Parameters.AddWithValue("@h4", TxtFirma.Text);
                komut3.Parameters.AddWithValue("@h5", decimal.Parse(TxtFiyat.Text));
                komut3.Parameters.AddWithValue("@h6", decimal.Parse(TxtTutar.Text));
                komut3.Parameters.AddWithValue("@h7", TxtFaturaId.Text);
                komut3.Parameters.AddWithValue("@h8", MskTarih.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();

                //stok syaısını azaltma
                SqlCommand komut4 = new SqlCommand("update TBL_URUNLER set ADET=ADET-@s1 where ID=@s2", bgl.baglanti());
                komut4.Parameters.AddWithValue("@s1", TxtMiktar.Text);
                komut4.Parameters.AddWithValue("@s2", TxtUrunId.Text);
                komut4.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Faturaya Ait Ürün Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }


            // Müşteri carisi
            if (TxtFaturaId.Text != " " && comboBox1.Text == "Müşteri")
            {
                double miktar, fiyat, tutar;
                fiyat = Convert.ToDouble(TxtFiyat.Text);
                miktar = Convert.ToDouble(TxtMiktar.Text);
                tutar = miktar * fiyat;
                TxtTutar.Text = tutar.ToString();

                SqlCommand komut2 = new SqlCommand("insert into TBL_FATURADETAY(URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", TxtUrunAd.Text);
                komut2.Parameters.AddWithValue("@p2", TxtMiktar.Text);
                komut2.Parameters.AddWithValue("@p3", decimal.Parse(TxtFiyat.Text));
                komut2.Parameters.AddWithValue("@p4", decimal.Parse(TxtTutar.Text));
                komut2.Parameters.AddWithValue("@p5", TxtFaturaId.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();

                // Hareket tablosuna veri girişi
                SqlCommand komut3 = new SqlCommand("insert into TBL_MUSTERIHAREKET(URUNID,ADET,PERSONEL,FIRMA,FIYAT,TOPLAM,FATURAID,TARIH) values (@h1,@h2,@h3,@h4,@h5,@h6,@h7,@h8)", bgl.baglanti());
                komut3.Parameters.AddWithValue("@h1", TxtUrunId.Text);
                komut3.Parameters.AddWithValue("@h2", TxtMiktar.Text);
                komut3.Parameters.AddWithValue("@h3", TxtPersonel.Text);
                komut3.Parameters.AddWithValue("@h4", TxtFirma.Text);
                komut3.Parameters.AddWithValue("@h5", decimal.Parse(TxtFiyat.Text));
                komut3.Parameters.AddWithValue("@h6", decimal.Parse(TxtTutar.Text));
                komut3.Parameters.AddWithValue("@h7", TxtFaturaId.Text);
                komut3.Parameters.AddWithValue("@h8", MskTarih.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();

                //stok sayısını azaltma
                SqlCommand komut4 = new SqlCommand("update TBL_URUNLER set ADET=ADET-@s1 where ID=@s2", bgl.baglanti());
                komut4.Parameters.AddWithValue("@s1", TxtMiktar.Text);
                komut4.Parameters.AddWithValue("@s2", TxtUrunId.Text);
                komut4.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Faturaya Ait Ürün Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //imlec satırı değiştiği zaman ne olsun
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle); //focus row handle fareyle imlecin seçtiği satır.
            if (dr != null)
            {
                TxtId.Text = dr["FATURABILGIID"].ToString();
                TxtSıraNo.Text = dr["SIRANO"].ToString();
                TxtSeri.Text = dr["SERI"].ToString();
                MskTarih.Text = dr["TARIH"].ToString();
                MskSaat.Text = dr["SAAT"].ToString();
                TxtAlici.Text = dr["ALICI"].ToString();
                TxtTeslimeden.Text = dr["TESLIMEDEN"].ToString();
                TxtTeslimalan.Text = dr["TESLIMALAN"].ToString();
                TxtVergiDaire.Text = dr["VERGIDAIRE"].ToString();

            }
        }

       
                

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunler fr = new FrmFaturaUrunler();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);//grideviewde seçmiş olduğumuz satırın verisini al.

            if (dr != null)
            {
                fr.id = dr["FATURABILGIID"].ToString();

            }
            fr.Show();
        }

         
        

        private void BtnBul_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select URUNAD,SATISFIYAT FROM TBL_URUNLER where ıd=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtUrunId.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtUrunAd.Text = dr[0].ToString();
                TxtFiyat.Text = dr[1].ToString();

            }
            bgl.baglanti().Close();

        }

        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Fatura bilgilerini güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (secenek == DialogResult.Yes)
            {
                //Veritabanına kayıt güncelleyen kodlar
                SqlCommand komut = new SqlCommand("Update TBL_FATURABILGI set SERI=@p1, SIRANO=@p2,TARIH=@p3,SAAT=@p4, VERGIDAIRE=@p5,ALICI=@p6, TESLIMEDEN=@p7,TESLIMALAN=@p8 where FATURABILGIID=@p9", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtSeri.Text);
                komut.Parameters.AddWithValue("@p2", TxtSıraNo.Text);
                komut.Parameters.AddWithValue("@p3", MskTarih.Text);
                komut.Parameters.AddWithValue("@p4", MskSaat.Text);
                komut.Parameters.AddWithValue("@p5", TxtVergiDaire.Text);
                komut.Parameters.AddWithValue("@p6", TxtAlici.Text);
                komut.Parameters.AddWithValue("@p7", TxtTeslimeden.Text);
                komut.Parameters.AddWithValue("@p8", TxtTeslimalan.Text);
                komut.Parameters.AddWithValue("@p9", TxtId.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
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

        private void BtnTemizle_Click_1(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnSil_Click_1(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Faturayı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (secenek == DialogResult.Yes)
            {
                //Veritabanına kayıt ekleyen kodlar
                SqlCommand komut = new SqlCommand("Delete From TBL_FATURABILGI where FATURABILGIID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtId.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
                listele();
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
    }
}
