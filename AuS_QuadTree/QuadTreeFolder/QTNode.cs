using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AuS_QuadTree.QuadTreeFolder
{
    public class QTNode<TKey>
    {
        QTNode<TKey>[] children = new QTNode<TKey>[4];
        List<TKey> records;
        QTNode<TKey> parent;
        bool isLeaf;
        int height;
        double lowerBoundX, lowerBoundY, upperBoundX, upperBoundY;

        public QTNode(double lowerX_, double lowerY_, double upperX_, double upperY_, int height_)
        {
            isLeaf = true;
            this.lowerBoundX = lowerX_;
            this.lowerBoundY = lowerY_;
            this.upperBoundX = upperX_;
            this.upperBoundY = upperY_;
            this.height = height_;
        }

        public bool AllocateSons()
        {
            if (!HasSons())
            {
                children[0] = new QTNode<TKey>(lowerBoundX, lowerBoundY, upperBoundX/2d, upperBoundY/2d, height++);
                children[1] = new QTNode<TKey>(upperBoundX/2d, upperBoundY, upperBoundX, upperBoundY/2d, height++);
                children[2] = new QTNode<TKey>(upperBoundX/2d, upperBoundY/2d, upperBoundX, upperBoundY, height++);
                children[3] = new QTNode<TKey>(lowerBoundX, upperBoundY/2d, upperBoundX/2d, upperBoundY, height++);
                isLeaf = false;
                return true;
            } else
            {
                return false;
            }
        }

        public bool HasSons()
        {
            for(int i = 0; i < children.Length; i++)
            {
                if (children[i] == null)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
