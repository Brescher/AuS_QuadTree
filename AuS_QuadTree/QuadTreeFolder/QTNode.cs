using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AuS_QuadTree.QuadTreeFolder
{
    internal class QTNode<TKey> where TKey : IComparable<TKey>
    {
        private QTNode<TKey>[] children = new QTNode<TKey>[4];
        private List<TKey> records;
        private QTNode<TKey> parent;
        private bool isLeaf;
        int height;
        //suradnice ktore node ohranicuje????

        public QTNode()
        {
            isLeaf = true;
        }
    }
}
