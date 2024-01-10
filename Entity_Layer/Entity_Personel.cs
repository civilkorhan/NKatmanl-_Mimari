using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
   public   class Entity_Personel
    {
        private int id;
        private string ad;
        private string soyad;
        private string sehir;
        private string gorev;
        private short maas;  // smallint in karşılıgı short tur c# da 

        public int Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Sehir { get => sehir; set => sehir = value; }
        public string Gorev { get => gorev; set => gorev = value; }
        public short Maas { get => maas; set => maas = value; }
    }
}
