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
        List<TKey> records = new List<TKey>();
        List<TKey> doesntFitInSon = new List<TKey>();
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
                int newHeight = Height + 1;
                Children[0] = new QTNode<TKey>((double)LowerBoundX, (double)LowerBoundY, (double)((UpperBoundX - LowerBoundX) /2d) + LowerBoundX, (double)((UpperBoundY - LowerBoundY) / 2d) + LowerBoundY, newHeight);
                Children[0].Parent = this;
                Children[1] = new QTNode<TKey>((double)((UpperBoundX - LowerBoundX) / 2d) + LowerBoundX, (double)LowerBoundY, (double)UpperBoundX, (double)((UpperBoundY - LowerBoundY) / 2d) + LowerBoundY, newHeight);
                Children[1].Parent = this;
                Children[2] = new QTNode<TKey>((double)((UpperBoundX - LowerBoundX) / 2d) + LowerBoundX, (double)((UpperBoundY - LowerBoundY) / 2d) + LowerBoundY, (double)UpperBoundX, (double)UpperBoundY, newHeight);
                Children[2].Parent = this;
                Children[3] = new QTNode<TKey>((double)LowerBoundX, (double)((UpperBoundY - LowerBoundY) / 2d) + LowerBoundY, (double)((UpperBoundX - LowerBoundX) / 2d) + LowerBoundX, (double)UpperBoundY, newHeight);
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

        public bool CheckNumberOfItemsAsSon()
        {
            int numberOfItems = 0;
            numberOfItems += parent.records.Count;
            numberOfItems += parent.doesntFitInSon.Count;
            for(int i = 0; i < parent.Children.Length; i++)
            {
                numberOfItems += parent.Children[i].records.Count;
                numberOfItems += parent.Children[i].doesntFitInSon.Count;
            }

            if(numberOfItems > 1)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public bool CheckNumberOfItemsAsParent()
        {
            int numberOfItems = 0;
            numberOfItems += records.Count;
            numberOfItems += doesntFitInSon.Count;
            for (int i = 0; i < Children.Length; i++)
            {
                numberOfItems += Children[i].records.Count;
                numberOfItems += Children[i].doesntFitInSon.Count;
            }

            if (numberOfItems > 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ReallocateDataAndDeallocateSons()
        {
            for(int i = 0; i < parent.Children.Length;i++)
            {
                foreach(TKey item in parent.Children[i].records)
                {
                    parent.records.Add(item);
                }
                foreach (TKey item in parent.Children[i].DoesntFitInSon)
                {
                    parent.records.Add(item);
                }
                parent.Children[i].Records.Clear();
                parent.Children[i].DoesntFitInSon.Clear();
            }
            parent.DeallocateSons();
        }
    }
}
