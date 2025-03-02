using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProje2
{
    internal class MyStack
    {
        int maxSize;
        UM_Alanı[] stackArray;
        int topOfStack;

        public MyStack(int maxSize)
        {
            this.maxSize = maxSize;
            stackArray  = new UM_Alanı[maxSize];
            topOfStack = -1;
        }


        public void Ekle(UM_Alanı UM_Alanı)
        { 
            stackArray[++topOfStack] = UM_Alanı;
        }

        public UM_Alanı Sil()
        {
            
            return stackArray[topOfStack--];
            
        }

        public UM_Alanı Gözlemle()
        {
            return stackArray[topOfStack];
        }

        public bool BosMu()
        {
            return topOfStack == -1;
        }

        public bool DoluMu()
        {
            return topOfStack == maxSize -1;
        }



    }
}
