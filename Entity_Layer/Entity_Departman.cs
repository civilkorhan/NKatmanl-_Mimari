using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    internal class Entity_Departman
    {
        private int id;
        private string ad;
        private string aciklama;

        public int Id { get => id; set => id = value; }     // kapsülleme yapıldı
        public string Ad { get => ad; set => ad = value; }
        public string Aciklama { get => aciklama; set => aciklama = value; }
    }
}
