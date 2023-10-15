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
        #region properties
        public QTNode<TKey> Root { get => root; set => root = value; }
        public double MaxX { get => maxX; set => maxX = value; }
        public double MaxY { get => maxY; set => maxY = value; }
        public int MaxHeight { get => maxHeight; set => maxHeight = value; }
        #endregion

        public QuadTree(double maxX_, double maxY_, int maxHeight_)
        {
            MaxX = maxX_;
            MaxY = maxY_;
            MaxHeight = maxHeight_;
            Root = new QTNode<TKey>(0, 0, MaxX, MaxY, 1);
        }

        public void Insert(TKey key)
        {
            QTNode<TKey> helpNode = Root;
            TKey helpData;
            Queue<TKey> qData = new Queue<TKey>();
            Queue<QTNode<TKey>> qNodes = new Queue<QTNode<TKey>>();
            qData.Enqueue(key); 
            qNodes.Enqueue(helpNode);

            while(qData.Count > 0)
            {
                helpData = qData.Dequeue();
                helpNode = qNodes.Dequeue();

                if(helpData == null )
                {
                    throw new Exception("null data");
                } 
                else if (helpNode.Height == MaxHeight)
                {
                    switch (helpData.CompareTo(helpNode))
                    {
                        case 1:
                            helpNode.Records.Add(helpData);
                            break;
                        case -1:
                            helpNode.Parent.DoesntFitInSon.Add(helpData);
                            break;
                        default:
                            throw new Exception("null data");
                            break;
                    }
                }
                else if(helpNode.Height == 1 && helpData.CompareTo(helpNode) == -1)
                {
                    throw new Exception("Data bigger than tree");
                }
                else if(helpNode.IsLeaf && helpData.CompareTo(helpNode) == 1 
                        && (helpNode.Records.Count == 0 && helpNode.DoesntFitInSon.Count == 0))
                {
                    helpNode.Records.Add(helpData);
                }
                else if(helpNode.IsLeaf && helpData.CompareTo(helpNode) == 1
                        && (helpNode.Records.Count > 0 || helpNode.DoesntFitInSon.Count > 0))
                {
                    if(SonExists(helpNode, helpData))
                    {
                        helpNode = FindSonNode(helpNode, helpData);
                        helpNode.Records.Add(helpData);
                        helpNode = helpNode.Parent;
                    }else
                    {
                        helpNode.DoesntFitInSon.Add(helpData);
                    }
                    if(helpNode.Records.Count > 0)
                    {
                        foreach(TKey record in helpNode.Records)
                        {
                            qData.Enqueue(record);
                            qNodes.Enqueue(helpNode);
                        }
                        helpNode.Records.Clear();
                    }
                }else if(helpNode.IsLeaf && helpData.CompareTo(helpNode) == -1)
                {
                    helpNode.Parent.DoesntFitInSon.Add(helpData);
                }
                else if(!helpNode.IsLeaf && helpData.CompareTo(helpNode) == 1)
                {
                    if(SonExists(helpNode, helpData))
                    {
                        helpNode = FindSonNode(helpNode, helpData);
                        qData.Enqueue(helpData);
                        qNodes.Enqueue(helpNode);
                    } else
                    {
                        helpNode.DoesntFitInSon.Add(helpData);
                    }
                }
            }
            
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
