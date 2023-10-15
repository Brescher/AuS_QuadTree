using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuS_QuadTree.QuadTreeFolder
{
    public class QuadTree<TKey> where TKey : IQTData<TKey>
    {
        QTNode<TKey> root;
        double maxX, maxY;
        int maxHeight;

        public QuadTree(double maxX_, double maxY_)
        {
            maxX = maxX_;
            maxY = maxY_;
            root = new QTNode<TKey>(0, 0, maxX, maxY, 1);
        }

        public bool Insert(TKey key)
        {
            QTNode<TKey> node = root;
            int result = key.CompareTo(node);
            return true;
        }


        private bool SonExists(QTNode<TKey> node, TKey key)
        {
            bool allocatedSons = false;
            if(node.IsLeaf)
            {
                node.AllocateSons();
                allocatedSons = true;
            }
            foreach (QTNode<TKey> son in node.Children)
            {
                if (key.CompareTo(son) == 1)
                {
                    return true;
                }
            }
            if(allocatedSons)
            {
                node.DeallocateSons();
            }
            return false;

        }
        private QTNode<TKey> FindSonNode(QTNode<TKey> node, TKey key)
        {
            foreach (QTNode<TKey> son in node.Children)
            {
                if (key.CompareTo(son) == 1)
                {
                    return son;
                }
            }
            return null;
        }
    }
}
