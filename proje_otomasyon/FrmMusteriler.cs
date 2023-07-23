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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }



        sqlBaglantisi bgl = new sqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select* From TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }


         void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select Sehır From TBL_ILLER",bgl.baglanti());
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
          //  TxtVergiDaire.Text = "";
            MskTC.Text = "";
            MskTel1.Text = "";
            MskTel2.Text = "";
            Cmbil.Text = "";
            Cmbilce.Text = "";
            RchAdres.Text = "";
           
            TxtAd.Focus();


        }
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            listele();
            sehirListesi();
            temizle();
        }

        private void Cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmbilce.Properties.Items.Clear();//temizlemesi için 
            SqlCommand komut = new SqlCommand("Select Ilce From TBL_ILCELER where Sehır=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Cmbil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbilce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_MUSTERILER(AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,ADRES) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTel1.Text);
            komut.Parameters.AddWithValue("@p4", MskTel2.Text);
            komut.Parameters.AddWithValue("@p5", MskTC.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text);
            komut.Parameters.AddWithValue("@p7", Cmbil.Text);
            komut.Parameters.AddWithValue("@p8", Cmbilce.Text);
            komut.Parameters.AddWithValue("@p9", RchAdres.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();

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
                MskTel2.Text = dr["TELEFON2"].ToString();
                MskTC.Text = dr["TC"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                Cmbil.Text = dr["IL"].ToString();
                Cmbilce.Text = dr["ILCE"].ToString();
                RchAdres.Text = dr["ADRES"].ToString();
            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
           
            DialogResult secenek = MessageBox.Show("Müşteriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (secenek == DialogResult.Yes)
            {
                //Veritabanına kayıt ekleyen kodlar
                SqlCommand komut = new SqlCommand("Delete From TBL_MUSTERILER where ID=@p1", bgl.baglanti());
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
           


            DialogResult secenek = MessageBox.Show("Müşteri bilgilerini güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (secenek == DialogResult.Yes)
            {
                //Veritabanına kayıt güncelleyen kodlar
                SqlCommand komut = new SqlCommand("Update TBL_MUSTERILER set AD=@p1,SOYAD=@p2,TELEFON=@p3,TELEFON2=@p4, TC=@p5,MAIL=@p6, IL=@p7,ILCE=@p8,ADRES=@p9 where ID=@p10", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", MskTel1.Text);
                komut.Parameters.AddWithValue("@p4", MskTel2.Text);
                komut.Parameters.AddWithValue("@p5", MskTC.Text);
                komut.Parameters.AddWithValue("@p6", TxtMail.Text);
                komut.Parameters.AddWithValue("@p7", Cmbil.Text);
                komut.Parameters.AddWithValue("@p8", Cmbilce.Text);
                komut.Parameters.AddWithValue("@p9", RchAdres.Text);
                komut.Parameters.AddWithValue("@p10", TxtId.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Müşteri Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
