using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProje2
{
    internal class ÖncelikliKuyrukTamSayi {

        int maxSize;
        public List<int> liste;
        int front;
        int back;
        int nItems;

        public ÖncelikliKuyrukTamSayi(int maxSize)
        {

            this.maxSize = maxSize;
            front = 0;
            back = -1;
            nItems = 0;
            liste = new List<int>(maxSize);

        }

        public void Ekle(int urunAdeti)
        {
            liste.Add(urunAdeti);
        }


        public int Sil()
        {
            int EnKucukUrunAdeti = 1000000000;
            int silinenIndex = 0;
            for(int i = 0; i < liste.Count(); i++)
            {
                if(EnKucukUrunAdeti > liste[i])
                {
                    EnKucukUrunAdeti = liste[i];
                    silinenIndex = i;
                }
                
            }
            liste.RemoveAt(silinenIndex);
            return EnKucukUrunAdeti;
        }

        public bool BosMu()
        {
            return (liste.Count < 0);
        }

        public bool DoluMu()
        {
            return (liste.Count > 0);
        }

}












    
}
