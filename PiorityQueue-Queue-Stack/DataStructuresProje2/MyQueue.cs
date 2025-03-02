using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProje2
{
    internal class MyQueue
    {

        int maxSize;
        UM_Alanı[] queArray;
        int front;
        int back;
        int nItems;
        
        public MyQueue(int maxSize)
        {
            this.maxSize = maxSize;
            queArray =  new UM_Alanı[maxSize];
            front = 0;  
            back = -1;
            nItems = 0;
        }

        public void Ekle(UM_Alanı UM_Alanı)
        {

            if(back == maxSize - 1)
            {
                back = -1;
            }
            queArray[++back] = UM_Alanı;
            nItems++;

        }


        public UM_Alanı Sil()
        {
            UM_Alanı tempUmAlanı = queArray[front++];

            if(front == maxSize)
            {
                front = 0;
            }

            nItems--;
            return tempUmAlanı;

        }

        public UM_Alanı Gözlemle()
        {
            return queArray[front];
        }

        public bool BosMu()
        {
            return (nItems == 0);
        }

        public bool DoluMu()
        {
            return(nItems == maxSize);
        }

        public int Size()
        {
            return nItems;
        }

    }
}
