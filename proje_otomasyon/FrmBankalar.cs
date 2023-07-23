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
    public partial class FrmBankalar : Form
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE BankaBilgileri", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            TxtBankaAd.Text = "";
            TxtId.Text = "";
            lookUpEdit1.Text = "";
            TxtHesapNo.Text = "";
            TxtHesapTuru.Text = "";
            TxtSube.Text = "";
            TxtYetkili.Text = "";
            MskIban.Text = "";
            MskTarih.Text = "";
            MskTel.Text = "";
            Cmbil.Text = "";
            Cmbilce.Text = "";
           
            TxtBankaAd.Focus();


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
        void firmaListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID , AD From TBL_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.NullText = "Bir Firma Seçiniz";
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = dt;
        }

        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
            sehirListesi();
            firmaListesi();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_BANKALAR(BANKAADI,IL,ILCE,SUBE,IBAN,HESAPNO,YETKILI,TELEFON,TARIH,HESAPTURU,FIRMAID) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtBankaAd.Text);
            komut.Parameters.AddWithValue("@p2", Cmbil.Text);
            komut.Parameters.AddWithValue("@p3", Cmbilce.Text);
            komut.Parameters.AddWithValue("@p4", TxtSube.Text);
            komut.Parameters.AddWithValue("@p5", MskIban.Text);
            komut.Parameters.AddWithValue("@p6", TxtHesapNo.Text);
            komut.Parameters.AddWithValue("@p7", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@p8", MskTel.Text);
            komut.Parameters.AddWithValue("@p9", MskTarih.Text);
            komut.Parameters.AddWithValue("@p10", TxtHesapTuru.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
           
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Sisteme Kaydedildi. ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void Cmbil_SelectedIndexChanged(object sender, EventArgs e)
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //imlec satırı değiştiği zaman ne olsun
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle); //focus row handle fareyle imlecin seçtiği satır.
            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtBankaAd.Text = dr["BANKAADI"].ToString();
                Cmbil.Text = dr["IL"].ToString();
                Cmbilce.Text = dr["ILCE"].ToString();
                TxtSube.Text = dr["SUBE"].ToString();
                MskIban.Text = dr["IBAN"].ToString();
                TxtHesapNo.Text = dr["HESAPNO"].ToString();
                TxtYetkili.Text = dr["YETKILI"].ToString();
                MskTel.Text = dr["TELEFON"].ToString();
                MskTarih.Text = dr["TARIH"].ToString();
                TxtHesapTuru.Text = dr["HESAPTURU"].ToString();
               // lookUpEdit1.Text = dr["FIRMAID"].ToString();

            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Bankayı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (secenek == DialogResult.Yes)
            {
                //Veritabanına kayıt ekleyen kodlar
                SqlCommand komut = new SqlCommand("Delete From TBL_BANKALAR where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtId.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
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

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Banka bilgilerini güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (secenek == DialogResult.Yes)
            {
                //Veritabanına kayıt güncelleyen kodlar
                SqlCommand komut = new SqlCommand("Update TBL_BANKALAR set BANKAADI=@p1,IL=@p2,ILCE=@p3,SUBE=@p4, IBAN=@p5,HESAPNO=@p6, YETKILI=@p7,TELEFON=@p8, TARIH=@p9,HESAPTURU=@p10,FIRMAID=@p11 where ID=@p12", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtBankaAd.Text);
                komut.Parameters.AddWithValue("@p2", Cmbil.Text);
                komut.Parameters.AddWithValue("@p3", Cmbilce.Text);
                komut.Parameters.AddWithValue("@p4", TxtSube.Text);
                komut.Parameters.AddWithValue("@p5", MskIban.Text);
                komut.Parameters.AddWithValue("@p6", TxtHesapNo.Text);
                komut.Parameters.AddWithValue("@p7", TxtYetkili.Text);
                komut.Parameters.AddWithValue("@p8", MskTel.Text);
                komut.Parameters.AddWithValue("@p9", MskTarih.Text);
                komut.Parameters.AddWithValue("@p10", TxtHesapTuru.Text);
                komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
                komut.Parameters.AddWithValue("@p12", TxtId.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Banka Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
