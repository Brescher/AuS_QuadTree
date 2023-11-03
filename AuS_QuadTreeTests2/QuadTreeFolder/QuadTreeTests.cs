using Microsoft.VisualStudio.TestTools.UnitTesting;
using AuS_QuadTree.QuadTreeFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuS_QuadTree.Data;

namespace AuS_QuadTree.QuadTreeFolder.Tests
{
    [TestClass()]
    public class QuadTreeTests
    {
        [TestMethod()]
        public void InsertTest()
        {
            QuadTree<Parcel> tree = new QuadTree<Parcel>(10000, 10000, 50);
            List<Parcel> list = new List<Parcel>();

            Random randomGPS1 = new Random();
            Random randomGPS2 = new Random();
            Random increaseXGPS = new Random();
            Random increaseYGPS = new Random();

            for (int i = 0; i < 100000; i++)
            {
                double X1 = randomGPS1.NextDouble() * (tree.MaxX - 250);
                double Y1 = randomGPS2.NextDouble() * (tree.MaxY - 250);
                double increaseX = increaseXGPS.NextDouble() * 250;
                double increaseY = increaseYGPS.NextDouble() * 250;
                double X2 = X1 + increaseX;
                double Y2 = Y1 + increaseY;
                GPS GPS1 = new GPS('A', 'A', X1, Y1);
                GPS GPS2 = new GPS('A', 'A', X2, Y2);
                Parcel parcela = new Parcel(i, $"parcela {i}", GPS1, GPS2);
                list.Add(parcela);
                tree.Insert(parcela);
            }
            bool result;
            if (tree.GetNumberOfItemsInTree() == list.Count)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void FindTest()
        {
            QuadTree<Parcel> tree = new QuadTree<Parcel>(10000, 10000, 50);
            List<Parcel> list = new List<Parcel>();
            List<Parcel> list2 = new List<Parcel>();
            List<Parcel> find = new List<Parcel>();

            Random randomGPS1 = new Random();
            Random randomGPS2 = new Random();
            Random increaseXGPS = new Random();
            Random increaseYGPS = new Random();

            for (int i = 0; i < 10000; i++)
            {
                double X1 = randomGPS1.NextDouble() * (tree.MaxX - 250);
                double Y1 = randomGPS2.NextDouble() * (tree.MaxY - 250);
                double increaseX = increaseXGPS.NextDouble() * 250;
                double increaseY = increaseYGPS.NextDouble() * 250;
                double X2 = X1 + increaseX;
                double Y2 = Y1 + increaseY;
                GPS GPS1 = new GPS('A', 'A', X1, Y1);
                GPS GPS2 = new GPS('A', 'A', X2, Y2);
                Parcel parcela = new Parcel(i, $"parcela {i}", GPS1, GPS2);
                list.Add(parcela);
                tree.Insert(parcela);
            }

            Random randomFind1 = new Random();
            Random randomFind2 = new Random();
            Random randomFindincreaseX = new Random();
            Random randomFindincreaseY = new Random();

            bool foundAll = true;
            for (int i = 0; i < 1000; i++)
            {
                double X1 = randomFind1.NextDouble() * (tree.MaxX - tree.MaxX / 2);
                double Y1 = randomFind2.NextDouble() * (tree.MaxY - tree.MaxY / 2);
                double increaseX = randomFindincreaseX.NextDouble() * (tree.MaxX / 2);
                double increaseY = randomFindincreaseY.NextDouble() * (tree.MaxY / 2);
                double X2 = X1 + increaseX;
                double Y2 = Y1 + increaseY;
                find = tree.Find(X1, Y1, X2, Y2);
                list2.Clear();

                foreach (Parcel parcela in list)
                {
                    if (((parcela.LowerBound.X <= X1 && parcela.UpperBound.X >= X1 || (parcela.LowerBound.X <= X2 && parcela.UpperBound.X >= X2) ||
                            (parcela.LowerBound.X >= X1 && parcela.LowerBound.X <= X2) || (parcela.UpperBound.X >= X1 && parcela.UpperBound.X <= X2)) &&
                            ((parcela.LowerBound.Y <= Y1 && parcela.UpperBound.Y >= Y1) || (parcela.LowerBound.Y <= Y2 && parcela.UpperBound.Y >= Y2) ||
                            (parcela.LowerBound.Y >= Y1 && parcela.LowerBound.Y <= Y2) || (parcela.UpperBound.Y >= Y1 && parcela.UpperBound.Y <= Y2))))
                    {
                        list2.Add(parcela);
                    }
                }
                

                if(list2.Count != find.Count)
                {
                    Assert.IsTrue(false);
                }

                bool foundOne = false;
                foreach (Parcel item in find)
                {
                    foundOne = false;
                    foreach (Parcel item1 in list2)
                    {
                        if (item.Equals(item1))
                        {
                            foundOne = true;
                            break;
                        }
                    }
                    if (!foundOne)
                    {
                        foundAll = false;
                        break;
                    }
                }
            }

            Assert.IsTrue(foundAll);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            QuadTree<Parcel> tree;
            List<Parcel> list = new List<Parcel>();
            Random genItemsToDelete = new Random();
            Random genItemToDelete = new Random();
            Random randomGPS1 = new Random();
            Random randomGPS2 = new Random();
            Random increaseXGPS = new Random();
            Random increaseYGPS = new Random();
            bool result = false;
            for (int j = 0; j < 10; j++)
            {
                tree = new QuadTree<Parcel>(10000, 10000, 20);
                list.Clear();
                for (int i = 0; i < 10000; i++)
                {
                    double X1 = randomGPS1.NextDouble() * (tree.MaxX - 25);
                    double Y1 = randomGPS2.NextDouble() * (tree.MaxY - 25);
                    double increaseX = increaseXGPS.NextDouble() * 25;
                    double increaseY = increaseYGPS.NextDouble() * 25;
                    double X2 = X1 + increaseX;
                    double Y2 = Y1 + increaseY;
                    GPS GPS1 = new GPS('A', 'A', X1, Y1);
                    GPS GPS2 = new GPS('A', 'A', X2, Y2);
                    Parcel parcela = new Parcel(i, $"parcela {i}", GPS1, GPS2);
                    list.Add(parcela);
                    tree.Insert(parcela);
                }

                int numberOfItemsToDelete = genItemsToDelete.Next(list.Count);
                int itemToDelete = 0;
                for (int i = 0; i < numberOfItemsToDelete; i++)
                {
                    itemToDelete = genItemToDelete.Next(list.Count - 1);
                    if (!tree.Delete(list[itemToDelete]))
                    {
                        Assert.IsTrue(false);
                    }
                    list.RemoveAt(itemToDelete);
                    if (tree.GetNumberOfItemsInTree() != list.Count)
                    {
                        Assert.IsTrue(false);
                    }
                }
                //int count = list.Count;
                //for (int i = 0; i < count; i++)
                //{
                //    Tree.Delete(list[0]);
                //    list.RemoveAt(0);
                //}
                
                if (tree.GetNumberOfItemsInTree() == list.Count)
                {
                    result = true;
                }
                else
                {
                    result = false;
                    break;
                }
            }
            
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void ChangeHeightTest()
        {
            QuadTree<Parcel> tree = new QuadTree<Parcel>(10000, 10000, 50);

            Random randomGPS1 = new Random();
            Random randomGPS2 = new Random();
            Random increaseXGPS = new Random();
            Random increaseYGPS = new Random();
            Random heightGen = new Random();

            for (int i = 0; i < 100000; i++)
            {
                double X1 = randomGPS1.NextDouble() * (tree.MaxX - 250);
                double Y1 = randomGPS2.NextDouble() * (tree.MaxY - 250);
                double increaseX = increaseXGPS.NextDouble() * 250;
                double increaseY = increaseYGPS.NextDouble() * 250;
                double X2 = X1 + increaseX;
                double Y2 = Y1 + increaseY;
                GPS GPS1 = new GPS('A', 'A', X1, Y1);
                GPS GPS2 = new GPS('A', 'A', X2, Y2);
                Parcel parcela = new Parcel(i, $"parcela {i}", GPS1, GPS2);
                tree.Insert(parcela);
            }

            bool result = true;
            for(int i = 0; i < 1000; i++)
            {
                int newHeight = heightGen.Next(100) + 1;
                tree.ChangeHeight(newHeight);
                int maxHeight = tree.GetMaxHeight();
                int count = tree.GetNumberOfItemsInTree();
                if (count != 100000)
                {
                    result = false;
                    break;
                }
                if (maxHeight > newHeight)
                {
                    result = false;
                    break;
                }
            }
            
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void InsertAndDeleteTest()
        {
            QuadTree<Parcel> tree = new QuadTree<Parcel>(10000, 10000, 50);
            List<Parcel> list = new List<Parcel>();

            Random randomGPS1 = new Random();
            Random randomGPS2 = new Random();
            Random increaseXGPS = new Random();
            Random increaseYGPS = new Random();
            Random genItemToDelete = new Random();
            Random opeartionGen = new Random();


            double X1;
            double Y1;
            double increaseX;
            double increaseY;
            double X2;
            double Y2;
            int itemToDelete = 0;

            for (int i = 0; i < 1000; i++)
            {
                X1 = randomGPS1.NextDouble() * (tree.MaxX - 250);
                Y1 = randomGPS2.NextDouble() * (tree.MaxY - 250);
                increaseX = increaseXGPS.NextDouble() * 250;
                increaseY = increaseYGPS.NextDouble() * 250;
                X2 = X1 + increaseX;
                Y2 = Y1 + increaseY;
                GPS GPS1 = new GPS('A', 'A', X1, Y1);
                GPS GPS2 = new GPS('A', 'A', X2, Y2);
                Parcel parcela = new Parcel(i, $"parcela {i}", GPS1, GPS2);
                list.Add(parcela);
                tree.Insert(parcela);
            }

            double opearation;
            for (int i = 0; i < 500000; i++)
            {
                opearation = opeartionGen.NextDouble();
                if (opearation < 0.5)
                {
                    //insert
                    X1 = randomGPS1.NextDouble() * (tree.MaxX - 250);
                    Y1 = randomGPS2.NextDouble() * (tree.MaxY - 250);
                    increaseX = increaseXGPS.NextDouble() * 250;
                    increaseY = increaseYGPS.NextDouble() * 250;
                    X2 = X1 + increaseX;
                    Y2 = Y1 + increaseY;
                    GPS GPS1 = new GPS('A', 'A', X1, Y1);
                    GPS GPS2 = new GPS('A', 'A', X2, Y2);
                    Parcel parcela = new Parcel(i, $"parcela {i}", GPS1, GPS2);
                    list.Add(parcela);
                    tree.Insert(parcela);
                    if (tree.GetNumberOfItemsInTree() != list.Count)
                    {
                        Assert.IsTrue(false);
                    }
                }
                else
                {
                    itemToDelete = genItemToDelete.Next(list.Count - 1);
                    tree.Delete(list[itemToDelete]);
                    list.RemoveAt(itemToDelete);
                    if (tree.GetNumberOfItemsInTree() != list.Count)
                    {
                        Assert.IsTrue(false);
                    }
                }
            }

            bool result;
            if (tree.GetNumberOfItemsInTree() == list.Count)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            Assert.IsTrue(result);
        }
    }
}