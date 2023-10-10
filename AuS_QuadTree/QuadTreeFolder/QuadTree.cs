using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuS_QuadTree.QuadTreeFolder
{
    internal class QuadTree<TKey> where TKey : IComparable<TKey>
    {
        QTNode<TKey> root;
        double maxX, maxY;
        int maxHeight;

        public QuadTree(double maxX_, double maxY_)
        {
            maxX = maxX_;
            maxY = maxY_;
            root = new QTNode<TKey>();
        }
    }
}
