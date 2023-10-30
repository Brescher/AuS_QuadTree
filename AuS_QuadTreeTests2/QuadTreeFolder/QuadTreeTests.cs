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
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            QuadTree<Parcel> tree = new QuadTree<Parcel>(10000, 10000, 50);
            List<Parcel> list = new List<Parcel>();
            Random genItemsToDelete = new Random();
            Random genItemToDelete = new Random();
            int numberOfItemsToDelete = genItemsToDelete.Next(list.Count);
            int itemToDelete = 0;
            for (int i = 0; i < numberOfItemsToDelete; i++)
            {
                itemToDelete = genItemToDelete.Next(list.Count - 1);
                tree.Delete(list[itemToDelete]);
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
            for (int i = 0; i < 50000; i++)
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