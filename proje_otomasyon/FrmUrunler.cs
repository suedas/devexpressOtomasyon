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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        private void textEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_URUNLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
    
        }

        void temizle()
        {
            TxtAd.Text = "";
            TxtId.Text = "";
            TxtMarka.Text = "";
            TxtMiktar.Text = "";
            TxtAlis.Text = "";
            TxtSatis.Text = "";
            NudAdet.Value = 0;
            RchDetay.Text = "";
            
            TxtAd.Focus();


        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            // Verileri kaydetme
            SqlCommand komut = new SqlCommand("insert into TBL_URUNLER(URUNAD,MARKA,MIKTAR,ADET,ALISFIYAT,SATISFIYAT,DETAY)values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
            komut.Parameters.AddWithValue("@p3", (TxtMiktar.Text));
            
            komut.Parameters.AddWithValue("@p4", int.Parse((NudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p5",decimal.Parse((TxtAlis.Text)));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtSatis.Text));
            komut.Parameters.AddWithValue("@p7", RchDetay.Text);
            komut.ExecuteNonQuery();//dml komutlarını gerçekleştirir. Yani sorguyu çalıştırır.
            bgl.baglanti().Close();// bağlantıyı kapat
            MessageBox.Show("Ürün sisteme eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            temizle();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //SqlCommand komutSil = new SqlCommand("Delete From TBL_URUNLER where ID=@p1", bgl.baglanti());
            //komutSil.Parameters.AddWithValue("@p1", TxtId.Text);
            //komutSil.ExecuteNonQuery();
            //bgl.baglanti().Close();
            //MessageBox.Show("Ürün silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //listele();


            DialogResult secenek = MessageBox.Show("Ürünü silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (secenek == DialogResult.Yes)
            {
                //Veritabanına kayıt ekleyen kodlar
                SqlCommand komutSil = new SqlCommand("Delete From TBL_URUNLER where ID=@p1", bgl.baglanti());
                komutSil.Parameters.AddWithValue("@p1", TxtId.Text);
                komutSil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ürün silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //imlec satırı değiştiği zaman ne olsun
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtId.Text = dr["ID"].ToString();
            TxtAd.Text = dr["URUNAD"].ToString();
            TxtMarka.Text = dr["MARKA"].ToString();
            TxtMiktar.Text = dr["MIKTAR"].ToString();
            
            NudAdet.Value = decimal.Parse(dr["ADET"].ToString());
            TxtAlis.Text = dr["ALISFIYAT"].ToString();
            TxtSatis.Text = dr["SATISFIYAT"].ToString();
            RchDetay.Text = dr["DETAY"].ToString();




        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
       

            DialogResult secenek = MessageBox.Show("Ürün bilgilerini güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (secenek == DialogResult.Yes)
            {
                //Veritabanına kayıt güncelleyen kodlar
                SqlCommand komut = new SqlCommand("Update TBL_URUNLER set URUNAD=@p1,MARKA=@p2,MIKTAR=@p3, ADET=@p4,ALISFIYAT=@p5, SATISFIYAT=@p6, DETAY=@p7 where ID=@p8", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
                komut.Parameters.AddWithValue("@p3", TxtMiktar.Text);
               
                komut.Parameters.AddWithValue("@p4", int.Parse((NudAdet.Value).ToString()));
                komut.Parameters.AddWithValue("@p5", decimal.Parse((TxtAlis.Text)));
                komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtSatis.Text));
                komut.Parameters.AddWithValue("@p7", RchDetay.Text);
                komut.Parameters.Add("@p8", TxtId.Text);
                komut.ExecuteNonQuery();//dml komutlarını gerçekleştirir. Yani sorguyu çalıştırır.
                bgl.baglanti().Close();// bağlantıyı kapat
                MessageBox.Show("Ürün bilgisi güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

      
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
