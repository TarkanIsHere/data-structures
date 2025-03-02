using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProje3
{
    internal class Node
    {
        public UM_Alanı value;
        public Node leftNode;
        public Node rightNode;
        
        public Node(UM_Alanı UM_Alanı)
        {
            this.value = UM_Alanı;
            leftNode = null;
            rightNode = null;
        }
    }
}
