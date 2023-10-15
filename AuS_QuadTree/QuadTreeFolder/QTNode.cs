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

        #region properties
        public QTNode<TKey>[] Children { get => children; set => children = value; }
        public List<TKey> Records { get => records; set => records = value; }
        public List<TKey> DoesntFitInSon { get => doesntFitInSon; set => doesntFitInSon = value; }
        public QTNode<TKey> Parent { get => parent; set => parent = value; }
        public bool IsLeaf { get => isLeaf; set => isLeaf = value; }
        public int Height { get => height; set => height = value; }
        public double LowerBoundX { get => lowerBoundX; set => lowerBoundX = value; }
        public double LowerBoundY { get => lowerBoundY; set => lowerBoundY = value; }
        public double UpperBoundX { get => upperBoundX; set => upperBoundX = value; }
        public double UpperBoundY { get => upperBoundY; set => upperBoundY = value; }
        #endregion

        public QTNode(double lowerX_, double lowerY_, double upperX_, double upperY_, int height_)
        {
            IsLeaf = true;
            this.LowerBoundX = lowerX_;
            this.LowerBoundY = lowerY_;
            this.UpperBoundX = upperX_;
            this.UpperBoundY = upperY_;
            this.Height = height_;
            this.Parent = null;
        }
        

        public bool AllocateSons()
        {
            if (!HasSons())
            {
                Children[0] = new QTNode<TKey>(LowerBoundX, LowerBoundY, UpperBoundX/2d, UpperBoundY/2d, Height++);
                Children[0].Parent = this;
                Children[1] = new QTNode<TKey>(UpperBoundX/2d, UpperBoundY, UpperBoundX, UpperBoundY/2d, Height++);
                Children[1].Parent = this;
                Children[2] = new QTNode<TKey>(UpperBoundX/2d, UpperBoundY/2d, UpperBoundX, UpperBoundY, Height++);
                Children[2].Parent = this;
                Children[3] = new QTNode<TKey>(LowerBoundX, UpperBoundY/2d, UpperBoundX/2d, UpperBoundY, Height++);
                Children[3].Parent = this;
                IsLeaf = false;
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
                for(int i = 0; i < Children.Length; i++)
                {
                    if (!Children[i].IsLeaf || Children[i].Records.Count > 0 || Children[i].DoesntFitInSon.Count > 0)
                    {
                        return false;
                    }
                }
                for (int i = 0; i < Children.Length; i++)
                {
                    Children[i] = null;
                }
                IsLeaf = true;
                return true;
            }
            else
            {
                return true;
            }
        }

        public bool HasSons()
        {
            for(int i = 0; i < Children.Length; i++)
            {
                if (Children[i] == null)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
