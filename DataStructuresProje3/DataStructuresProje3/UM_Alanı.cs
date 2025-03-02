using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProje3
{
    internal class UM_Alanı
    {

        public String Alan_Adı;
        public List<String> İl_Adları;
        public String İlan_Yılı;
        public List<String> kelimelerListesi;


        public UM_Alanı(String Alan_Adı, List<String> İl_Adları, String İlan_Yılı, List<String> kelimelerListesi)
        {
            this.Alan_Adı = Alan_Adı;
            this.İl_Adları = İl_Adları;
            this.İlan_Yılı = İlan_Yılı;
            this.kelimelerListesi = kelimelerListesi;
        }

    }
}
