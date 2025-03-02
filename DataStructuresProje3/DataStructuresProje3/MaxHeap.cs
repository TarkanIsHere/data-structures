using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProje3
{
    internal class MaxHeap
    {
        private Node[] heapArray;

        private int maxHeapSize;

        private int currentHeapSize;

        public MaxHeap(int maxHeapSize1)
        {
            maxHeapSize = maxHeapSize1;
            currentHeapSize = 0;
            heapArray = new Node[maxHeapSize];
        }

        public bool isEmpty()
        {
            return currentHeapSize == 0;
        }


        public bool insert(UM_Alanı UM_Alanı)
        {
            if (currentHeapSize == 0)
            {
                return false;
            }
            Node newNode = new Node(UM_Alanı);
            heapArray[currentHeapSize] = newNode;
            trickleUp(currentHeapSize++);
            return true;
        }


        public void trickleUp(int index)
        {
            int parent = (index - 1) / 2;
            Node bottom = heapArray[index];
            while (index > 0 && string.Compare(heapArray[parent].value.Alan_Adı, bottom.value.Alan_Adı) == -1)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;

        }

        public Node remove(Node node)
        {
            Node root = heapArray[0];
            heapArray[0] = heapArray[--currentHeapSize];
            trickleDown(0);
            return root;

        }

        public void trickleDown(int index)
        {
            int largerChild;
            Node top = heapArray[index];
            while (index < currentHeapSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;

                if (rightChild < currentHeapSize && string.Compare(heapArray[leftChild].value.Alan_Adı, heapArray[rightChild].value.Alan_Adı) == -1)
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (string.Compare(top.value.Alan_Adı, heapArray[largerChild].value.Alan_Adı) == 1 && string.Compare(top.value.Alan_Adı, heapArray[largerChild].value.Alan_Adı) == 0)
                    break;
                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;

        }


        public bool change(int index, UM_Alanı newValue)
        {
            if (index < 0 || index >= currentHeapSize)
                return false;
            UM_Alanı oldValue = heapArray[index].value; 
            heapArray[index].value = newValue;
            if (string.Compare(oldValue.Alan_Adı, newValue.Alan_Adı ) == -1) 
                trickleUp(index); 
            else 
                trickleDown(index); 
            return true;
        }
    }
}
