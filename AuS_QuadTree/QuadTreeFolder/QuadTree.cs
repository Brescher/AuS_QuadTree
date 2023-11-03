using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AuS_QuadTree.QuadTreeFolder
{
    public class QuadTree<TKey> where TKey : IQTData<TKey>, IEquatable<TKey>
    {
        QTNode<TKey> root;
        double maxX, maxY;
        int maxHeight, secondaryKey;
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
            secondaryKey = 0;
        }
        //insert a metody pren
        public void Insert(TKey key)
        {
            QTNode<TKey> helpNode = Root;
            TKey helpData;
            key.IdentificationKey = secondaryKey++;
            Queue<TKey> qData = new Queue<TKey>();
            Queue<QTNode<TKey>> qNodes = new Queue<QTNode<TKey>>();
            qData.Enqueue(key);
            qNodes.Enqueue(helpNode);
            InsertBody(qData, qNodes);
        }

        private void InsertWithNode(TKey key, QTNode<TKey> node)
        {
            Queue<TKey> qData = new Queue<TKey>();
            Queue<QTNode<TKey>> qNodes = new Queue<QTNode<TKey>>();
            qData.Enqueue(key);
            qNodes.Enqueue(node);
            InsertBody(qData, qNodes);
        }

        private void InsertBody(Queue<TKey> qData, Queue<QTNode<TKey>> qNodes)
        {
            QTNode<TKey> helpNode;
            TKey helpData;
            while (qData.Count > 0)
            {
                helpData = qData.Dequeue();
                helpNode = qNodes.Dequeue();

                if (helpData == null)
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
                else if (helpNode.IsLeaf && helpData.CompareTo(helpNode) == 1
                        && (helpNode.Records.Count == 0 && helpNode.DoesntFitInSon.Count == 0))
                {
                    helpNode.Records.Add(helpData);
                }
                else if (helpNode.IsLeaf && helpData.CompareTo(helpNode) == 1
                        && (helpNode.Records.Count > 0 || helpNode.DoesntFitInSon.Count > 0))
                {
                    if (SonExists(helpNode, helpData))
                    {
                        helpNode = FindSonNode(helpNode, helpData);
                        helpNode.Records.Add(helpData);
                        helpNode = helpNode.Parent;
                    }
                    else
                    {
                        helpNode.DoesntFitInSon.Add(helpData);
                    }
                    if (helpNode.Records.Count > 0)
                    {
                        foreach (TKey record in helpNode.Records)
                        {
                            qData.Enqueue(record);
                            qNodes.Enqueue(helpNode);
                        }
                        helpNode.Records.Clear();
                    }
                }
                else if (helpNode.IsLeaf && helpData.CompareTo(helpNode) == -1)
                {
                    helpNode.Parent.DoesntFitInSon.Add(helpData);
                }
                else if (!helpNode.IsLeaf && helpData.CompareTo(helpNode) == 1)
                {
                    if (SonExists(helpNode, helpData))
                    {
                        helpNode = FindSonNode(helpNode, helpData);
                        qData.Enqueue(helpData);
                        qNodes.Enqueue(helpNode);
                    }
                    else
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
                if (CompareCoordinatesNode(node, x1, y1, x2, y2))
                {
                    if (!node.IsLeaf)
                    {
                        for (int i = 0; i < node.Children.Length; i++)
                        {
                            nodes.Enqueue(node.Children[i]);
                        }
                    }
                    if (node.Records.Count > 0)
                    {
                        foreach (TKey rec in node.Records)
                        {
                            if (rec.CompareIntersect(x1, y1, x2, y2) == 1)
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
            if (((node.LowerBoundX <= x1 && node.UpperBoundX >= x1) || (node.LowerBoundX <= x2 && node.UpperBoundX >= x2) ||
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
        //delete a metody pren
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

                if (!itemDeleted)
                {
                    //najdi syna v ktorom moze byt item
                    if (helpNode.IsLeaf)
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

            if (itemDeleted)
            {
                return DeleteBody(helpNode);
            } else
            {
                return false;
            }
        }

        private bool DeleteWithNodeFromRecords(TKey key, QTNode<TKey> node)
        {
            node.Records.Remove(key);
            return DeleteBody(node);
        }

        private bool DeleteWithNodeFromDoesntFitInSon(TKey key, QTNode<TKey> node)
        {
            node.DoesntFitInSon.Remove(key);
            return DeleteBody(node);
        }

        private bool DeleteBody(QTNode<TKey> helpNode)
        {
            Queue<QTNode<TKey>> collapsingNodes = new Queue<QTNode<TKey>>();
            collapsingNodes.Enqueue(helpNode);
            while (collapsingNodes.Count > 0)
            {
                helpNode = collapsingNodes.Dequeue();
                if (helpNode.IsLeaf)
                {
                    if (helpNode.Parent != null)
                    {
                        if (helpNode.CheckNumberOfItemsAsSon())
                        {
                            ReallocateData(helpNode.Parent);
                            collapsingNodes.Enqueue(helpNode.Parent);
                            helpNode.Parent.DeallocateSons();
                        }
                    }
                }
                else
                {
                    if (helpNode.CheckNumberOfItemsAsParent())
                    {
                        ReallocateData(helpNode);
                        collapsingNodes.Enqueue(helpNode);
                        helpNode.DeallocateSons();
                    }
                }
            }
            return true;
        }


        private void ReallocateData(QTNode<TKey> helpNode)
        {
            foreach (QTNode<TKey> item in helpNode.Children)
            {
                if (item.GetNumberOfItems() == 1)
                {
                    foreach (TKey data in item.Records)
                    {
                        helpNode.Records.Add(data);
                    }
                    foreach (TKey data in item.DoesntFitInSon)
                    {
                        helpNode.Records.Add(data);
                    }
                    item.Records.Clear();
                    item.DoesntFitInSon.Clear();
                }
                else if (item.GetNumberOfItems() > 1)
                {
                    throw new Exception("More items in nodes, do not collapse tree!");
                }
            }
        }

        private List<QTNode<TKey>> LevelOrder(QTNode<TKey> node)
        {
            List<QTNode<TKey>> levelOrder = new List<QTNode<TKey>>();
            Queue<QTNode<TKey>> queue = new Queue<QTNode<TKey>>();
            QTNode<TKey> helpNode = null;
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                helpNode = queue.Dequeue();
                levelOrder.Add(helpNode);
                if (!helpNode.IsLeaf)
                {
                    foreach (QTNode<TKey> son in helpNode.Children)
                    {
                        queue.Enqueue(son);
                    }
                }
            }
            return levelOrder;
        }

        private Stack<QTNode<TKey>> LevelOrderStack(QTNode<TKey> node)
        {
            Stack<QTNode<TKey>> levelOrder = new Stack<QTNode<TKey>>();
            Queue<QTNode<TKey>> queue = new Queue<QTNode<TKey>>();
            QTNode<TKey> helpNode = null;
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                helpNode = queue.Dequeue();
                levelOrder.Push(helpNode);
                if (!helpNode.IsLeaf)
                {
                    foreach (QTNode<TKey> son in helpNode.Children)
                    {
                        queue.Enqueue(son);
                    }
                }
            }
            return levelOrder;
        }

        public double GetTreeHealth()
        {
            double max = 0, min = int.MaxValue;
            if (root.IsLeaf)
            {
                return 1;
            } else
            {
                List<QTNode<TKey>>[] qTNodes = new List<QTNode<TKey>>[4];
                qTNodes[0] = LevelOrder(root.Children[0]);
                qTNodes[1] = LevelOrder(root.Children[1]);
                qTNodes[2] = LevelOrder(root.Children[2]);
                qTNodes[3] = LevelOrder(root.Children[3]);

                for(int i = 0; i < qTNodes.Length; i++)
                {
                    List<QTNode<TKey>> list = qTNodes[i];
                    if(max < list[list.Count - 1].Height)
                    {
                        max = list[list.Count - 1].Height;
                    }
                    if(min > list[list.Count - 1].Height)
                    {
                        min = list[list.Count - 1].Height;
                    }
                }

            }
            return min/max;
        }

        public int GetNumberOfItemsInTree()
        {
            int items = 0;
            Queue<QTNode<TKey>> queue = new Queue<QTNode<TKey>>();
            QTNode<TKey> helpNode = null;
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                helpNode = queue.Dequeue();
                items += helpNode.GetNumberOfItems();
                if (!helpNode.IsLeaf)
                {
                    foreach (QTNode<TKey> son in helpNode.Children)
                    {
                        queue.Enqueue(son);
                    }
                }
            }
            return items;
        }

        //zmena vysky stromu
        public bool ChangeHeight(int newHeight)
        {
            Stack<QTNode<TKey>> nodes = LevelOrderStack(root);
            Stack<QTNode<TKey>> nodesToTruncate = new Stack<QTNode<TKey>>();
            QTNode<TKey> node = null;
            if (newHeight < 1)
            {
                return false;
            }
            int oldHeight = maxHeight;
            maxHeight = newHeight;
            if (newHeight < oldHeight)
            {
                while(nodes.Count > 0)
                {
                    node = nodes.Pop();
                    if(node.Parent != null)
                    {
                        if (!node.Parent.IsLeaf)
                        {
                            if (node.Height > maxHeight)
                            {
                                while(node.Records.Count > 0)
                                {
                                    TKey key = node.Records[0];
                                    if (DeleteWithNodeFromRecords(key, node))
                                    {
                                        InsertWithNode(key, root);
                                    }
                                    else
                                    {
                                        throw new Exception("Item not deleted during change of height");
                                    }
                                }
                                while (node.DoesntFitInSon.Count > 0)
                                {
                                    TKey key = node.DoesntFitInSon[0];
                                    if (DeleteWithNodeFromDoesntFitInSon(key, node))
                                    {
                                        InsertWithNode(key, root);
                                    }
                                    else
                                    {
                                        throw new Exception("Item not deleted during change of height");
                                    }
                                }
                            }
                        }
                    }
                    if (node.Height == maxHeight)
                    {
                        nodesToTruncate.Push(node);
                    }
                }
                while (nodesToTruncate.Count > 0)
                {
                    node = nodesToTruncate.Pop();
                    if (node.CheckNumberOfItemsForHeightChange())
                    {
                        node.ReallocateDataAndDeallocateSonsForHeightChage();
                    }
                }
                return true;
            } 
            else if(newHeight > oldHeight)
            {
                while (nodes.Count > 0)
                {
                    node = nodes.Pop();
                    if (node.Height == oldHeight)
                    {
                        while(node.GetNumberOfItems() > 1)
                        {
                            if(node.Records.Count > 0)
                            {
                                TKey key = node.Records[0];
                                node.Records.RemoveAt(0);
                                InsertWithNode(key, node);

                            } else
                            {
                                break;
                            }
                        }
                    }
                }
                return true;
            } 
            else if(newHeight == oldHeight)
            {
                return true;
            }
            return false;
        }

        public int GetMaxHeight()
        {
            int height = 0;
            List<QTNode<TKey>> nodes = LevelOrder(root);
            foreach (QTNode<TKey> item in nodes)
            {
                if(item.Height > height)
                {
                    height = item.Height;
                }
            }

            return height;
        }
    }
}
