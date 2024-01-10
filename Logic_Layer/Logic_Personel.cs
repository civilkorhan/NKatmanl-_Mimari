using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Layer;
using Data_Acces_Layer;

namespace Logic_Layer
{
    public class Logic_Personel
    {
        public static List<Entity_Personel>LL_Personel_Listesi()
        {
            return DAL_Personel.personel_Listesi();
        }
        public static int LL_Per_Add(Entity_Personel n)
        {
            if(n.Ad!= null && n.Soyad!= null && n.Maas>=17002 && n.Ad.Length>=3)
            {
                return DAL_Personel.personel_ekle(n);
            }
            else
            {
                return -1;
            }
        }
        
        public static bool LL_Per_Dlt(int per)
        { 
            if(per>=1 && per!=null )
            {
                return DAL_Personel.personel_sil(per);
            }
            else 
            {
                return false; 
            
            }
        
        }
        public static bool LL_Per_Updt(Entity_Personel u)
        {
            // şartımızı yazıyoruz
            if(u.Ad.Length>=3 && u != null)  // ! eşit değildir demek
            {
                return DAL_Personel.personel_güncelle(u);   
            }
            else
            {
                return false;   
            }
        }


    }
}
