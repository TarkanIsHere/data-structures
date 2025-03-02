using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProje3
{
    internal class BubbleSort
    {

        private long[] dizi;
        private int sonElemanIndex;

        public BubbleSort(int maksimumElemanSayisi)
        {
            dizi = new long[maksimumElemanSayisi];
            sonElemanIndex = 0;
        }

        public void insert(long value)
        {
            dizi[sonElemanIndex] = value;
            sonElemanIndex++;
        }

        public void display()
        {
            for(int i = 0; i < sonElemanIndex; i++)
            {
                Console.WriteLine(dizi[i]);
            }
        }

        public void BubbleSortYap()
        {
            int distakiLoop;
            int ictekiLoop;

            for(distakiLoop = sonElemanIndex -1; distakiLoop > 1 ; distakiLoop--)
            {
                for(ictekiLoop = 0; ictekiLoop < distakiLoop; ictekiLoop++)
                {
                    if (dizi[ictekiLoop] > dizi[ictekiLoop + 1])
                    {
                        swap(ictekiLoop, ictekiLoop + 1);
                    }
                }
            }
        }

        public void swap(int birinci, int ikinci)
        {
            long temp = dizi[birinci];
            dizi[birinci] = dizi[ikinci];
            dizi[ikinci] = temp;
        }


        
    }
}
