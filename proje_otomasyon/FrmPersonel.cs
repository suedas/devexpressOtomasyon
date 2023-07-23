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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        private void MskTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void TxtVergiDaire_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        void personelListe()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select* From TBL_PERSONELLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

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


        void temizle()
        {
            TxtAd.Text = "";
            TxtId.Text = "";
            TxtSoyad.Text = "";
            TxtMail.Text = "";
            MskTC.Text = "";
            MskTel1.Text = "";
            Cmbil.Text = "";
            Cmbilce.Text = "";
            RchAdres.Text = "";
            TxtGorev.Text = "";

            TxtAd.Focus();


        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            personelListe();
            sehirListesi();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_PERSONELLER(AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE, ADRES,GOREV) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTel1.Text);
            komut.Parameters.AddWithValue("@p4", MskTC.Text);
            komut.Parameters.AddWithValue("@p5", TxtMail.Text);
            komut.Parameters.AddWithValue("@p6", Cmbil.Text);
            komut.Parameters.AddWithValue("@p7", Cmbilce.Text);
            komut.Parameters.AddWithValue("@p8", RchAdres.Text);
            komut.Parameters.AddWithValue("@p9", TxtGorev.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Bilgileri Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personelListe();
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
                TxtAd.Text = dr["AD"].ToString();
                TxtSoyad.Text = dr["SOYAD"].ToString();
                MskTel1.Text = dr["TELEFON"].ToString();
                MskTC.Text = dr["TC"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                Cmbil.Text = dr["IL"].ToString();
                Cmbilce.Text = dr["ILCE"].ToString();
                RchAdres.Text = dr["ADRES"].ToString();
                TxtGorev.Text = dr["GOREV"].ToString();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Personel kaydını silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (secenek == DialogResult.Yes)
            {
                //Veritabanına kayıt ekleyen kodlar
                SqlCommand komut = new SqlCommand("Delete From TBL_PERSONELLER where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtId.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
               personelListe();
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
            DialogResult secenek = MessageBox.Show("Personel bilgilerini güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (secenek == DialogResult.Yes)
            {
                //Veritabanına kayıt güncelleyen kodlar
                SqlCommand komut = new SqlCommand("Update TBL_PERSONELLER set AD=@p1,SOYAD=@p2,TELEFON=@p3, TC=@p4,MAIL=@p5, IL=@p6,ILCE=@p7,ADRES=@p8, GOREV=@p9 where ID=@p10", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", MskTel1.Text);
                komut.Parameters.AddWithValue("@p4", MskTC.Text);
                komut.Parameters.AddWithValue("@p5", TxtMail.Text);
                komut.Parameters.AddWithValue("@p6", Cmbil.Text);
                komut.Parameters.AddWithValue("@p7", Cmbilce.Text);
                komut.Parameters.AddWithValue("@p8", RchAdres.Text);
                komut.Parameters.AddWithValue("@p9", TxtGorev.Text);
                komut.Parameters.AddWithValue("@p10", TxtId.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Personel Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                personelListe();
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

        private void MskTel1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
