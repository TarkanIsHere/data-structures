using System.Linq;
using System.Linq.Expressions;

namespace DataStructuresProje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UM_Alanları = "Divriği Ulu Camii ve Darüşşifası (Sivas) 1985" +
                "/İstanbul'un Tarihi Alanları (İstanbul) 1985" +
                "/Göreme Millî Parkı ve Kapadokya (Nevşehir) 1985 (Karma Miras Alanı) " +
                "/Hattuşa: Hitit Başkenti (Çorum) 1986 / Nemrut Dağı (Adıyaman) 1987 " +
                "/Hieropolis-Pamukkale (Denizli) 1988 (Karma Miras Alanı) " +
                "/Xanthos-Letoon (Antalya-Muğla) 1988 " +
                "/Safranbolu Şehri (Karabük) 1994 " +
                "/Truva Arkeolojik Alanı (Çanakkale) 1998 " +
                "/Edirne Selimiye Camii ve Külliyesi (Edirne) 2011 " +
                "/Çatalhöyük Neolitik Alanı (Konya) 2012 " +
                "/Bursa ve Cumalıkızık: Osmanlı İmparatorluğunun Doğuşu (Bursa) 2014 " +
                "/Bergama Çok Katmanlı Kültürel Peyzaj Alanı (İzmir) 2014 " +
                "/Diyarbakır Kalesi ve Hevsel Bahçeleri Kültürel Peyzajı (Diyarbakır) 2015 " +
                "/Efes (İzmir) 2015 " +
                "/Ani Arkeolojik Alanı (Kars) 2016 " +
                "/Aphrodisias (Aydın) 2017 " +
                "/Göbekli Tepe (Şanlıurfa) 2018 " +
                "/Arslantepe Höyüğü (Malatya) 2021 " +
                "/Gordion (Ankara) 2023 " +
                "/Anadolu’nun Ortaçağ Dönemi Ahşap Hipostil Camiileri (Konya-Eşrefoğlu Camii, Kastamonu-Mahmut Bey Camii, Eskişehir-Sivrihisar Camii, Afyon-Afyon Ulu Camii, Ankara-Arslanhane Camii) 2023";


            string[] Akdeniz = { "Antalya", "Burdur","Isparta", "Mersin","Adana", "Osmaniye", "Kahramanmaraş", "Hatay"};
            string[] DoguAnadolu = { "Ardahan", "Kars", "Erzurum", "Iğdır", "Ağrı", "Muş", "Bingöl", "Tunceli", "Erzincan", "Elazığ", "Malatya", "Bitlis", "Van", "Hakkari", "Şırnak" };
            string[] Ege = { "İzmir", "Aydın", "Muğla", "Denizli", "Uşak", "Manisa", "Afyon", "Kütahya" };
            string[] GuneyDoguAnadolu = { "Kilis", "Gaziantep","Adıyaman","Şanlıurfa","Diyarbakır", "Mardin","Batman","Siirt" };
            string[] İcAnadolu = { "Eskişehir", "Ankara", "Çankırı", "Kırıkkale", "Kırşehir", "Yozgat", "Sivas", "Nevşehir", "Aksaray", "Konya", "Karaman" };
            string[] Karadeniz = { "Düzce", "Bolu", "Zonguldak", "Karabük", "Kastamonu", "Sinop", "Çorum", "Samsun", "Amasya", "Tokat", "Ordu", "Giresun", "Gümüşhane", "Bayburt", "Rize", "Artvin" };
            string[] Marmara = { "Edirne", "Kırklareli", "Tekirdağ", "İstanbul", "Kocaeli", "Sakarya", "Bursa", "Balıkesir", "Çanakkale", "Bilecik" };
            

            string[] Um_AlanlarıListe = UM_Alanları.Split("/");
            int[] BölgeElemanSayıTutucu = { 0, 0, 0, 0, 0, 0, 0 };
            List<UM_Alanı> bosListe1 = new List<UM_Alanı>();
            List<UM_Alanı> bosListe2 = new List<UM_Alanı>();
            List<UM_Alanı> bosListe3 = new List<UM_Alanı>();
            List<UM_Alanı> bosListe4 = new List<UM_Alanı>();
            List<UM_Alanı> bosListe5 = new List<UM_Alanı>();
            List<UM_Alanı> bosListe6 = new List<UM_Alanı>();
            List<UM_Alanı> bosListe7 = new List<UM_Alanı>();


            List<List<UM_Alanı>> GenelListe = new List<List<UM_Alanı>> { bosListe1, bosListe2, bosListe3, bosListe4, bosListe5, bosListe6 , bosListe7};
            
            List<UM_Alanı> UM_AlanListesi = new List<UM_Alanı>();
            
            for(int i = 0; i < Um_AlanlarıListe.Length; i++)
            {
                List<String> İl_Adları = new List<string>();
                if (Um_AlanlarıListe[i].Contains("Anadolu")){
                    string[] Alanİsim_AlanYer_AlanYıl = Um_AlanlarıListe[i].Split("(");
                    string Alan_Adı = Alanİsim_AlanYer_AlanYıl[0].Trim();
                    string[] IlIsımleri_AlanYıl = Alanİsim_AlanYer_AlanYıl[1].Split(")");
                    string Ilan_Yılı = IlIsımleri_AlanYıl[1].Trim();
                    string[] Iller_Isımler = IlIsımleri_AlanYıl[0].Split(",");
                    for (int k = 0; k < Iller_Isımler.Length; k++)
                    {
                        string[] AyrılmısIller = Iller_Isımler[k].Split("-");
                        İl_Adları.Add(AyrılmısIller[0].Trim());
                    }
                    UM_AlanListesi.Add(new UM_Alanı(Alan_Adı, İl_Adları, Ilan_Yılı));
                }
                else
                {
                    string[] Alanİsim_AlanYer_AlanYıl = Um_AlanlarıListe[i].Split("(");
                    string[] AlanYer_AlanYıl = Alanİsim_AlanYer_AlanYıl[1].Split(")");


                    string Alan_Adı = Alanİsim_AlanYer_AlanYıl[0].Trim();
                    string İlan_Yılı = AlanYer_AlanYıl[1].Trim();
                    if (!AlanYer_AlanYıl[0].Contains("-"))
                    {
                        İl_Adları.Add(AlanYer_AlanYıl[0].Trim());

                    }
                    else
                    {
                        string[] İl1_İl2 = AlanYer_AlanYıl[0].Split("-");
                        İl_Adları.Add(İl1_İl2[0].Trim());
                        İl_Adları.Add(İl1_İl2[1].Trim());

                    }
                    UM_AlanListesi.Add(new UM_Alanı(Alan_Adı, İl_Adları, İlan_Yılı));
                }

            }

            for (int i = 0; i < UM_AlanListesi.Count(); i++)
            {

                List<string> il_ismi = UM_AlanListesi[i].İl_Adları;
                for (int k = 0; k < il_ismi.Count(); k++)
                {
                    if (Akdeniz.Contains(il_ismi[k]))
                    {
                        GenelListe.ElementAt(0).Add(UM_AlanListesi[i]);
                        BölgeElemanSayıTutucu[0] += 1;
                    }
                    else if (DoguAnadolu.Contains(il_ismi[k]))
                    {
                        GenelListe.ElementAt(1).Add(UM_AlanListesi[i]);
                        BölgeElemanSayıTutucu[1] += 1;
                    }
                    else if (Ege.Contains(il_ismi[k]))
                    {
                        GenelListe.ElementAt(2).Add(UM_AlanListesi[i]);
                        BölgeElemanSayıTutucu[2] += 1;
                    }
                    else if (GuneyDoguAnadolu.Contains(il_ismi[k]))
                    {
                        GenelListe.ElementAt(3).Add(UM_AlanListesi[i]);
                        BölgeElemanSayıTutucu[3] += 1;
                    }
                    else if (İcAnadolu.Contains(il_ismi[k]))
                    {
                        GenelListe.ElementAt(4).Add(UM_AlanListesi[i]);
                        BölgeElemanSayıTutucu[4] += 1;
                    }
                    else if (Karadeniz.Contains(il_ismi[k]))
                    {
                        GenelListe.ElementAt(5).Add(UM_AlanListesi[i]);
                        BölgeElemanSayıTutucu[5] += 1;
                    }
                    else if (Marmara.Contains(il_ismi[k]))
                    {
                        GenelListe.ElementAt(6).Add(UM_AlanListesi[i]);
                        BölgeElemanSayıTutucu[6] += 1;
                    }
                }
                
            }
            for(int i = 0; i < GenelListe.Count(); i++) {

                switch (i)
                {
                    case 0:
                        
                        Console.WriteLine("Akdeniz Bölgesinde Bulunan UNESCO Dünya Miras Sayısı: " + BölgeElemanSayıTutucu[i]);
                        Console.WriteLine("       ");
                        
                        break;
                    case 1:
                        
                        Console.WriteLine("Doğu Anadolu Bulunan UNESCO Dünya Miras Sayısı: " + BölgeElemanSayıTutucu[i]);
                        Console.WriteLine("       ");
                       
                        break;
                    case 2:
                        
                        Console.WriteLine("Ege Bölgesinde Bulunan UNESCO Dünya Miras Sayısı: " + BölgeElemanSayıTutucu[i]);
                        Console.WriteLine("       ");
                        
                        break;
                    case 3:
                        
                        Console.WriteLine("Güneydoğu Anadolu Bölgesinde Bulunan UNESCO Dünya Miras Sayısı: " + BölgeElemanSayıTutucu[i]);
                        Console.WriteLine("       ");
                       
                        break;
                    case 4:
                        
                        Console.WriteLine("İç Anadolu Bölgesinde Bulunan UNESCO Dünya Miras Sayısı: " + BölgeElemanSayıTutucu[i]);
                        Console.WriteLine("       ");
                        
                        break;
                    case 5:
                       
                        Console.WriteLine("Karadeniz BölgesindeBulunan UNESCO Dünya Miras Sayısı: " + BölgeElemanSayıTutucu[i]);
                        Console.WriteLine("       ");
                       
                        break;
                    case 6:
                        
                        Console.WriteLine("Marmara Bölgesinde Bulunan UNESCO Dünya Miras Sayısı: " + BölgeElemanSayıTutucu[i]);
                        Console.WriteLine("       ");
                        
                        break;
                    
                }
  
                for (int j = 0; j< GenelListe[i].Count(); j++)
                {


                    if (GenelListe[i][j].İl_Adları.Count() > 1)
                    {
                        Console.WriteLine($" {j + 1}. UNESCO Dünya Mirasının Adı: : " + GenelListe[i][j].Alan_Adı);
                        Console.Write($" {j + 1}. UNESCO Dünya Mirasının Bulunduğu il: ");
                        for (int k = 0; k< GenelListe[i][j].İl_Adları.Count(); k++)
                        {
                        Console.Write(GenelListe[i][j].İl_Adları[k]);
                        Console.WriteLine("       ");
                        }
                        
                        Console.WriteLine($" {j + 1}. UNESCO Dünya Mirasının İlan Edildiği Yıl: : " + GenelListe[i][j].İlan_Yılı);
                        Console.WriteLine("       ");
                    }
                    else
                    {
                        Console.WriteLine($" {j + 1}. UNESCO Dünya Mirasının Adı: : " + GenelListe[i][j].Alan_Adı);
                        Console.WriteLine($" {j + 1}. UNESCO Dünya Mirasının Bulunduğu il: : " + GenelListe[i][j].İl_Adları[0]);
                        Console.WriteLine($" {j + 1}. UNESCO Dünya Mirasının İlan Edildiği Yıl: : " + GenelListe[i][j].İlan_Yılı);
                        Console.WriteLine("       ");
                    }

                }
                Console.WriteLine("----------------------------------------------------------------------------");

            }

           
            Console.WriteLine("Stack İle Yazdırma");
            Console.WriteLine("");
            MyStack stack = new MyStack(21);
            for(int i = 0; i < Um_AlanlarıListe.Length; i++)
            {
                stack.Ekle(UM_AlanListesi[i]);
            }
            for (int i = 0; i < Um_AlanlarıListe.Length; i++)
            {
                UM_Alanı silinen = stack.Sil();
                Console.Write($"{i+1}. "+ silinen.Alan_Adı + " " + silinen.İlan_Yılı + " ");
               
               for (int j = 0; j < silinen.İl_Adları.Count; j++)
               {
                        Console.WriteLine(silinen.İl_Adları[j]);
               }
                
                
            }
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Queue İle Yazdırma");
            Console.WriteLine("");
            MyQueue MyQueue =  new MyQueue(21);

            for (int i = 0; i < Um_AlanlarıListe.Length; i++)
            {
                MyQueue.Ekle(UM_AlanListesi[i]);
            }


            for (int j = 0; j < Um_AlanlarıListe.Length; j++)
            {
                UM_Alanı silinen1 = MyQueue.Sil();
                Console.Write($"{j+1}. " + silinen1.Alan_Adı + " " + silinen1.İlan_Yılı + " ");

                for (int k = 0; k < silinen1.İl_Adları.Count; k++)
                {
                    Console.WriteLine(silinen1.İl_Adları[k]);
                }
            }


            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Öncelikli Kuyruk İle Yazdırma");
            Console.WriteLine("");
            ÖncelikliKuyruk öncelikliKuyruk = new ÖncelikliKuyruk(21);
            for (int i = 0; i < Um_AlanlarıListe.Length; i++)
            {
                öncelikliKuyruk.Ekle(UM_AlanListesi[i]);
            }

            

            for (int j = 0; j < Um_AlanlarıListe.Length; j++)
            {
                UM_Alanı silinen1 = öncelikliKuyruk.Sil();
                Console.Write($"{j+1}. " + silinen1.Alan_Adı + " " + silinen1.İlan_Yılı + " ");

                for (int k = 0; k < silinen1.İl_Adları.Count; k++)
                {
                    Console.WriteLine(silinen1.İl_Adları[k]);
                }
            }

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Queue ile Sıra Yazdırma");
            Console.WriteLine("");
            MyQueueTamSayi myQueueTamSayi = new MyQueueTamSayi(10);
            int[] urunlerSayiListesi = { 10, 4, 8, 6, 7, 1, 15, 9, 3, 2 };
            foreach(int urunSayisi in urunlerSayiListesi)
            {
                myQueueTamSayi.Ekle(urunSayisi);
            }
            int musteriSayisi = urunlerSayiListesi.Length;
            double toplamSure = 0;
            double oncekiSureler = 0;
            double islemSuresi = 2.5;
           
            for (int i = 0; i < musteriSayisi; i++)
            {
                
                // alternatif 1 : double musteriIslemSuresi = myQueueTamSayi.IndexAt(i) * islemSuresi;
                // alternatif 2 : 
                int kuyruktanAtilanSayi = myQueueTamSayi.Sil();
                double musteriIslemSuresi = kuyruktanAtilanSayi * islemSuresi;               
                oncekiSureler += musteriIslemSuresi;     
                Console.WriteLine($"{i + 1}. Müşterinin işlem tamamlanma süresi: {oncekiSureler}");
                toplamSure += oncekiSureler;
            }
            double ortalamaIslemSuresi = toplamSure / musteriSayisi;
            Console.WriteLine($"Müşterilerin Ortalama İşlem Tamamlanma Süresi : {ortalamaIslemSuresi}");



            Console.WriteLine("*****************************************************");
            Console.WriteLine("Modifiyeli öncelikli kuyruk İle Yazdırma");
            Console.WriteLine("");

            ÖncelikliKuyrukTamSayi öncelikliKuyrukTamSayi = new ÖncelikliKuyrukTamSayi(10);
            foreach (int urunSayisi in urunlerSayiListesi)
            {
                öncelikliKuyrukTamSayi.Ekle(urunSayisi);
            }
            double toplamSure1 = 0;
            double islemSuresi1 = 2.5;
            double oncekiSureler1 = 0;
            for (int i = 0; i < musteriSayisi; i++)
            {
                int kuyruktanAtilanSayi1 = öncelikliKuyrukTamSayi.Sil();
                double musteriIslemSuresi1 = kuyruktanAtilanSayi1 * islemSuresi1;
                oncekiSureler1 += musteriIslemSuresi1;
                Console.WriteLine($"{i + 1}. Müşterinin işlem tamamlanma süresi: {oncekiSureler1}");
                toplamSure1 += oncekiSureler1;
            }
            double ortalamaIslemSuresi1 = toplamSure1 / musteriSayisi;
            Console.WriteLine($"Müşterilerin Ortalama İşlem Tamamlanma Süresi : {ortalamaIslemSuresi1}");

        }
    }
}