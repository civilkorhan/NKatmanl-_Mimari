using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity_Layer;
using Data_Acces_Layer;
using Logic_Layer;


namespace NKatmanlı_Mimari
{
    public partial class FRM_BILGI_PNL : Form
    {
        public FRM_BILGI_PNL()
        {
            InitializeComponent();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            List<Entity_Personel> Per_Listle = Logic_Personel.LL_Personel_Listesi();
            dataGridView1.DataSource= Per_Listle;   // 3farklı katmana gidildi

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Entity_Personel ent=new Entity_Personel();
            ent.Ad=txtbox_ad.Text;
            ent.Soyad=txtbox_syad.Text;
            ent.Sehir=txtbox_sehir.Text;
            ent.Maas = short.Parse(txtbox_maas.Text);
            ent.Gorev = txtbox_gorev.Text;
            Logic_Personel.LL_Per_Add(ent);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Entity_Personel per=new Entity_Personel();
            per.Id = int.Parse(txt_box_id.Text);
            Logic_Personel.LL_Per_Dlt(per.Id);
            MessageBox.Show("Silme İşlemi Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_gnclle_Click(object sender, EventArgs e)
        {
            Entity_Personel per=new Entity_Personel();
            per.Id = Convert.ToInt32(txt_box_id.Text);
            per.Ad=txtbox_ad.Text;  
            per.Soyad = txtbox_syad.Text;
            per.Sehir= txtbox_sehir.Text;  
            per.Maas=short.Parse(txtbox_maas.Text);
            per.Gorev= txtbox_gorev.Text;   
            Logic_Personel.LL_Per_Updt(per);
            MessageBox.Show("Güncelleme İşlemi Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor=Color.DarkRed;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }
    }
}
