using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Layer;
using System.Data.SqlClient;
using System.Data;

namespace Data_Acces_Layer
{
    public class DAL_Personel
    {
        public static List<Entity_Personel> personel_Listesi()
        {
            List<Entity_Personel>degerler=new List<Entity_Personel>(); // baglantı sınıfından yeni nesne türetmedik
            SqlCommand cmd = new SqlCommand("Select * from TBL_BILGI",Baglanti.conn); //class ve metotu yazdık çünkü static tanımlandı
            if(cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader oku = cmd.ExecuteReader();
            while(oku.Read())
            {
                Entity_Personel ent= new Entity_Personel();
                ent.Id = int.Parse(oku["ID"].ToString());
                ent.Ad = oku["AD"].ToString();
                ent.Soyad = oku["SOYAD"].ToString();
                ent.Sehir = oku["SEHİR"].ToString();
                ent.Maas = short.Parse(oku["MAAS"].ToString());
                ent.Gorev = oku["GOREV"].ToString() ;
                degerler.Add(ent);



            }
            oku.Close();
            return degerler;
            
            
        }
       
        public static int personel_ekle(Entity_Personel n)
        {
            SqlCommand add = new SqlCommand("insert into TBL_BILGI (AD,SOYAD,SEHİR,MAAS,GOREV) values (@p1, @p2, @p3, @p4, @p5) ", Baglanti.conn);
            if(add.Connection.State != ConnectionState.Open)
            {
                
                add.Connection.Open(); 
            
            }
            add.Parameters.AddWithValue("@p1",n.Ad);
            add.Parameters.AddWithValue("@p2",n.Soyad);
            add.Parameters.AddWithValue("@p3",n.Sehir);
            add.Parameters.AddWithValue("@p4",n.Maas);
            add.Parameters.AddWithValue("@p5",n.Gorev);
            return add.ExecuteNonQuery();
            

            
            
        }
         
        public static bool personel_sil(int d)
        {
            SqlCommand dlt=new SqlCommand("delete from tbl_BILGI where ID=@p1",Baglanti.conn);
            if(dlt.Connection.State != ConnectionState.Open)
            {
                dlt.Connection.Open();
            }
            dlt.Parameters.AddWithValue("@p1",d);
            return dlt.ExecuteNonQuery() > 0;
        }
        public static bool personel_güncelle(Entity_Personel ent)
        {
            SqlCommand updte = new SqlCommand("update tbl_BILGI set AD=@p2,SOYAD=@p3,SEHİR=@p4,MAAS=@p5,GOREV=@p6 where ID=@p1", Baglanti.conn);
            if(updte.Connection.State != ConnectionState.Open)
            {
                updte.Connection.Open(); 
            }
            updte.Parameters.AddWithValue("@p1",ent.Id);
            updte.Parameters.AddWithValue("@p2",ent.Ad);
            updte.Parameters.AddWithValue("@p3",ent.Soyad);
            updte.Parameters.AddWithValue("@p4",ent.Sehir);
            updte.Parameters.AddWithValue("@p5",ent.Maas);
            updte.Parameters.AddWithValue("@p6",ent.Gorev);
            
          
            return updte.ExecuteNonQuery() > 0;
        }
    }
}
