using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AuS_QuadTree.QuadTreeFolder
{
    public class QTNode<TKey> where TKey : IComparable<TKey>
    {
        private QTNode<TKey>[] children = new QTNode<TKey>[4];
        private List<TKey> records;
        private QTNode<TKey> parent;
        private bool isLeaf;
        int height;
        double lowerBoundX, lowerBoundY, upperBoundX, upperBoundY;

        public QTNode(double lowerX_, double lowerY_, double upperX_, double upperY_)
        {
            isLeaf = true;
            this.lowerBoundX = lowerX_;
            this.lowerBoundY = lowerY_;
            this.upperBoundX = upperX_;
            this.upperBoundY = upperY_;
        }

        
    }
}
