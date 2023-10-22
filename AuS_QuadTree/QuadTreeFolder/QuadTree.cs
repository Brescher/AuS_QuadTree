using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuS_QuadTree.QuadTreeFolder
{
    public class QuadTree<TKey> where TKey : IQTData<TKey>, IEquatable<TKey>
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
        //insert a metody pren
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
                else if (helpNode.Height == 1 && helpData.CompareTo(helpNode) == -1)
                {
                    throw new Exception("Data bigger than tree");
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
            if (node.IsLeaf)
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
            if (allocatedSons)
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
        //find a metody pren
        public List<TKey> Find(double _x1, double _y1, double _x2, double _y2)
        {
            double x1, y1, x2, y2;
            if (_x1 > _x2)
            {
                x1 = _x2;
                x2 = _x1;
            } else
            {
                x1 = _x1;
                x2 = _x2;
            }
            if (_y1 > _y2)
            {
                y1 = _y2;
                y2 = _y1;
            } else
            {
                y1 = _y1;
                y2 = _y2;
            }
            List<TKey> list = new List<TKey>();
            Queue<QTNode<TKey>> nodes = new Queue<QTNode<TKey>>();
            nodes.Enqueue(root);
            QTNode<TKey> node;
            while (nodes.Count > 0)
            {
                node = nodes.Dequeue();
                if(CompareCoordinatesNode(node, x1, y1, x2, y2))
                {
                    if(!node.IsLeaf)
                    {
                        for(int i = 0; i < node.Children.Length; i++)
                        {
                            nodes.Enqueue(node.Children[i]);
                        }
                    }
                    if(node.Records.Count > 0)
                    {
                        foreach(TKey rec in node.Records)
                        {
                            if(rec.CompareIntersect(x1, y1, x2, y2) == 1)
                            {
                                list.Add(rec);
                            }
                        }
                    }
                    if (node.DoesntFitInSon.Count > 0)
                    {
                        foreach (TKey rec in node.DoesntFitInSon)
                        {
                            if (rec.CompareIntersect(x1, y1, x2, y2) == 1)
                            {
                                list.Add(rec);
                            }
                        }
                    }
                }
            }

            return list;
        }

        public bool CompareCoordinatesNode(QTNode<TKey> node, double x1, double y1, double x2, double y2)
        {
            if(((node.LowerBoundX <= x1 && node.UpperBoundX >= x1) || (node.LowerBoundX <= x2 && node.UpperBoundX >= x2) || 
               (node.LowerBoundX >= x1 && node.LowerBoundX <= x2) || (node.UpperBoundX >= x1 && node.UpperBoundX <= x2)) &&
               ((node.LowerBoundY <= y1 && node.UpperBoundY >= y1) || (node.LowerBoundY <= y2 && node.UpperBoundY >= y2) ||
               (node.LowerBoundY >= y1 && node.LowerBoundY <= y2) || (node.UpperBoundY >= y1 && node.UpperBoundY <= y1)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CompareCoordinatesData(TKey data, double x1, double y1, double x2, double y2)
        {
            if (data.CompareIntersect(x1, y1, x2, y2) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //delete a metody prem
        public bool Delete(TKey key)
        {
            QTNode<TKey> helpNode = Root;
            TKey helpData = key;
            Queue<QTNode<TKey>> qNodes = new Queue<QTNode<TKey>>();
            qNodes.Enqueue(helpNode);
            bool itemDeleted = false;
            while (qNodes.Count > 0)
            {
                helpNode = qNodes.Dequeue();
                if (!itemDeleted)
                {
                    for (int i = 0; i < helpNode.Records.Count; i++)
                    {
                        if (helpData.Equals(helpNode.Records[i]))
                        {
                            helpNode.Records.RemoveAt(i);
                            itemDeleted = true;
                            break;
                        }
                    }
                }
                if (!itemDeleted)
                {
                    for (int i = 0; i < helpNode.DoesntFitInSon.Count; i++)
                    {
                        if (helpData.Equals(helpNode.DoesntFitInSon[i]))
                        {
                            helpNode.DoesntFitInSon.RemoveAt(i);
                            itemDeleted = true;
                            break;
                        }
                    }
                }
                if (itemDeleted)
                {
                    //preskumat synov ci maju prvky a tak

                    Queue<QTNode<TKey>> collapsingNodes = new Queue<QTNode<TKey>>();
                    collapsingNodes.Enqueue(helpNode);
                    while (collapsingNodes.Count > 0)
                    {
                        helpNode = collapsingNodes.Dequeue();
                        if (helpNode.IsLeaf)
                        {
                            if (helpNode.CheckNumberOfItemsAsSon())
                            {
                                //pokracovat tuna
                            } 
                            else
                            {
                                return true;
                            }
                        }
                    }
                    return true;
                } else
                {
                    //najdi syna v ktorom moze byt item
                    if(helpNode.IsLeaf)
                    {
                        return false;
                    } 
                    else
                    {
                        helpNode = FindSonNode(helpNode, helpData);
                        if (helpNode != null)
                        {
                            qNodes.Enqueue(helpNode);
                        }
                        else
                        {
                            return false;
                        }
                        
                    }
                }
            }
            return false;
        }

    }
}
