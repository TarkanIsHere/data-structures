using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProje2
{
    internal class ÖncelikliKuyruk
    {
        int maxSize;
        public List<UM_Alanı> liste;
        int front;
        int back;
        int nItems;

        public ÖncelikliKuyruk(int maxSize) { 
        
            this.maxSize = maxSize;
            front = 0;
            back = -1;
            nItems = 0;
            liste = new List<UM_Alanı> (maxSize);
        
        }

        public void Ekle(UM_Alanı UM_Alanı)
        {
            liste.Add(UM_Alanı);
        }
        

        public UM_Alanı Sil() { 

            UM_Alanı GeciciAlfabetikÖncelikli = null;
            int silinenIndex = 0;
            for (int i = 0; i < liste.Count; i++)
            {
                
          
                if (i == 0 && liste[0] != null)
                {
                    GeciciAlfabetikÖncelikli = liste[i];
                }
                else
                {
                    
                    if (liste[i] != null)
                    {
                        string ilk = liste[i].Alan_Adı.Trim();
                        string iki = GeciciAlfabetikÖncelikli.Alan_Adı.Trim();
                        if(GeciciAlfabetikÖncelikli != null)
                        {
                            if (string.Compare(ilk, iki) < 0)
                            {
                                GeciciAlfabetikÖncelikli = liste[i];
                                silinenIndex = i;
                            }
                        }
                    }
                    
                }
                
            }
            liste.RemoveAt(silinenIndex);

            return GeciciAlfabetikÖncelikli;

        
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
