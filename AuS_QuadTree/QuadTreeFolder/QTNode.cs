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
        private int x1, y1, x2, y2;
        private bool isLeaf;

        public QTNode()
        {
            isLeaf = true;
        }
    }
}
