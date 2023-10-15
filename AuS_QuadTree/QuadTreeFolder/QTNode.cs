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
        List<TKey> records, doesntFitInSon;
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
            this.parent = null;
        }

        public bool AllocateSons()
        {
            if (!HasSons())
            {
                children[0] = new QTNode<TKey>(lowerBoundX, lowerBoundY, upperBoundX/2d, upperBoundY/2d, height++);
                children[0].parent = this;
                children[1] = new QTNode<TKey>(upperBoundX/2d, upperBoundY, upperBoundX, upperBoundY/2d, height++);
                children[1].parent = this;
                children[2] = new QTNode<TKey>(upperBoundX/2d, upperBoundY/2d, upperBoundX, upperBoundY, height++);
                children[2].parent = this;
                children[3] = new QTNode<TKey>(lowerBoundX, upperBoundY/2d, upperBoundX/2d, upperBoundY, height++);
                children[3].parent = this;
                isLeaf = false;
                return true;
            } else
            {
                return false;
            }
        }

        public bool DeallocateSons()
        {
            if (HasSons())
            {
                for(int i = 0; i < children.Length; i++)
                {
                    if (!children[i].isLeaf || children[i].records.Count > 0 || children[i].doesntFitInSon.Count > 0)
                    {
                        return false;
                    }
                }
                for (int i = 0; i < children.Length; i++)
                {
                    children[i] = null;
                }
                isLeaf = true;
                return true;
            }
            else
            {
                return true;
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
