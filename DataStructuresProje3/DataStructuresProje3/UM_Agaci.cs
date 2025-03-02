using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProje3
{
    internal class UM_Agaci
    {

        private Node root;

        public int nodeCounter = 0;
        public int counter = 0;



        public UM_Agaci()
        {
            root = null;
        }

        public Node getRoot()
        {
            return root;
        }

        public void AgacDerinlikHesaplaYazdirDügümSayisiHesapla(Node root)
        {
            Console.WriteLine("Ağaçtaki düğüm sayısı: " + nodeCounter);
            Console.WriteLine("Ağacın derinliği: " + AgacinDerinliginiHesapla(root));
            Console.WriteLine("Ağaç dengeli ağaç olsaydı derinliği: " + DengeliAgacDerinlikHesaplama(nodeCounter));
            Console.WriteLine("Ağaçtaki Tüm Elemanlar Hakkında Bilgiler: ");
            InOrderSeklindeAgaciYazdir(root);
        }

        public void AgacaElemanEkle(UM_Alanı UM_Alanı)
        {
            Node newNode = new Node(UM_Alanı);
            nodeCounter++;

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node suanki = root;
                Node önceki;
                while (true)
                {
                    önceki = suanki;
                    if (string.Compare(UM_Alanı.Alan_Adı, suanki.value.Alan_Adı) == -1) // sola gitme durumu
                    {
                        suanki = suanki.leftNode;
                        if (suanki == null)
                        {
                            önceki.leftNode = newNode;
                            break;

                        }
                    }
                    else // sağa gitme durumu
                    {
                        suanki = suanki.rightNode;
                        if (suanki == null)
                        {
                            önceki.rightNode = newNode;
                            break;
                        }
                    }
                }
            }



        }

        public double DengeliAgacDerinlikHesaplama(int toplamNode)
        {
            double dengeliAgacinDerinlikDouble = (Math.Log(toplamNode + 1) / Math.Log(2)) - 1;
            int dengeliAgacDerinlik = (int)Math.Ceiling(dengeliAgacinDerinlikDouble);
            return dengeliAgacDerinlik;
        }



        public void InOrderSeklindeAgaciYazdir(Node root)
        {
            if (root != null)
            {
                InOrderSeklindeAgaciYazdir(root.leftNode);
                Console.WriteLine();
                Console.WriteLine("Alan Adı: " + root.value.Alan_Adı);
                Console.WriteLine("İlan Yılı: " + root.value.İlan_Yılı.ToString());
                Console.Write("İl Adları: ");
                for (int i = 0; i < root.value.İl_Adları.Count(); i++)
                {
                    Console.Write(root.value.İl_Adları[i] + " ");
                }
                Console.WriteLine(" ");
                foreach (String kelime in root.value.kelimelerListesi)
                {
                    Console.Write(kelime + " ");
                }
                Console.WriteLine();
                InOrderSeklindeAgaciYazdir(root.rightNode);
            }
        }

        public void PreOrderYazdir(Node root)
        {
            if(root != null)
            {
                Console.WriteLine(root.value.Alan_Adı);
                PreOrderYazdir(root.leftNode);
                PreOrderYazdir(root.rightNode);
                
            }
        }

        public void InOrderSeklindeGez(Node root, List<UM_Alanı> siraliUMAlanListesi)
        {
            if(root != null)
            {
                InOrderSeklindeGez(root.leftNode, siraliUMAlanListesi);
                siraliUMAlanListesi.Add(root.value);
                InOrderSeklindeGez(root.rightNode, siraliUMAlanListesi);
            }   
        }

        public UM_Alanı[] SıralıDiziOlustur()
        {
            List<UM_Alanı> siraliUMAlanListesi = new List<UM_Alanı>();
            InOrderSeklindeGez(root,siraliUMAlanListesi);
            UM_Alanı[] siraliUMAlanDizisi = siraliUMAlanListesi.ToArray();
            return siraliUMAlanDizisi;
        }





        public int AgacinDerinliginiHesapla(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                int depthOfLeft = AgacinDerinliginiHesapla(root.leftNode);
                int depthOfRight = AgacinDerinliginiHesapla(root.rightNode);
                if(depthOfLeft > depthOfRight)
                {
                    return depthOfLeft + 1;
                }
                else
                {
                    return depthOfRight + 1;
                }
            }
        }

        public void GirilenHarfeGöreSırala(String birinciHarf, String ikinciHarf, Node root)
        {

            List<UM_Alanı> umalanlistesi = new List<UM_Alanı>();

            if (root != null)
            {               
                GirilenHarfeGöreSırala(birinciHarf, ikinciHarf, root.leftNode);               
                if (string.Compare(birinciHarf, root.value.Alan_Adı) == -1 && string.Compare(ikinciHarf, root.value.Alan_Adı) == 1)
                {
                    umalanlistesi.Add(root.value);                   
                }

                else if (string.Compare(birinciHarf, root.value.Alan_Adı[0].ToString()) == 0)
                {
                    umalanlistesi.Add(root.value);
                }

                else if(string.Compare(ikinciHarf, root.value.Alan_Adı[0].ToString()) == 0)
                {
                    umalanlistesi.Add(root.value);
                }               
                for (int i = 0; i <= umalanlistesi.Count() - 1; i++)
                {
                    Console.WriteLine(umalanlistesi[i].Alan_Adı);
                }
                GirilenHarfeGöreSırala(birinciHarf, ikinciHarf, root.rightNode); 
            }
            
        }

        public Node DengeliAgacOlustur(UM_Alanı[] sıralıUMAlanıListesi, int start, int end)
        {

            if(start > end)
            {
                return null;
            }

            int mid = (start + end) / 2;
            Node newNode = new Node(sıralıUMAlanıListesi[mid]);
            newNode.leftNode = DengeliAgacOlustur(sıralıUMAlanıListesi, start, mid-1);
            newNode.rightNode = DengeliAgacOlustur(sıralıUMAlanıListesi, mid + 1, end);
            return newNode;
        }

        public void DengeliAgacNesnesiniAktar(Node rootDisari)
        {
            root = rootDisari;
            
        }

    }

    
}
