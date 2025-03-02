using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProje2
{
    internal class MyQueueTamSayi
    {

        int[] queArray;
        int maxSize;
        int front;
        int back;
        int nItems;

        public MyQueueTamSayi(int maxSize)
        {
            this.maxSize = maxSize;
            this.front = 0;
            this.back = -1;
            this.nItems = 0;
            queArray = new int[maxSize];
        }


        public void Ekle(int urunSayisi)
        {
            if (back == maxSize - 1)
            {
                back = -1;
            }
            queArray[++back] = urunSayisi;
            nItems++;
        }

        public int Sil()
        {
            int tempUrunSayisi = queArray[front++];
            if(front == maxSize)
            {
                front = 0;
            }
            nItems--;
            return tempUrunSayisi;
        }
        

        public int Gözlemle()
        {
            return queArray[front];
        }

        public bool BosMu()
        {
            return (nItems == 0);
        }

        public bool DoluMu()
        {
            return (nItems == maxSize);
        }

        public int Size()
        {
            return nItems;
        }

        public int IndexAt(int index)
        {
            return queArray[index];
        }







    }
}
