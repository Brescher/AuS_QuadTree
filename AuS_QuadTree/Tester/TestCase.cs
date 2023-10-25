using AuS_QuadTree.Data;
using AuS_QuadTree.QuadTreeFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuS_QuadTree.Tester
{
    public class TestCase
    {
        QuadTree<Parcel> tree;
        List<Parcel> list = new List<Parcel>();

        public QuadTree<Parcel> Tree { get => tree; set => tree = value; }

        public TestCase()
        {
            Tree = new QuadTree<Parcel>(10000, 10000, 50);
        }

        public bool TestInsert()
        {
            Random randomGPS1 = new Random();
            Random randomGPS2 = new Random();
            Random increaseXGPS = new Random();
            Random increaseYGPS = new Random();

            for(int i = 0; i < 10000; i++)
            {
                double X1 = randomGPS1.NextDouble() * (Tree.MaxX - 250);
                double Y1 = randomGPS2.NextDouble() * (Tree.MaxY - 250);
                double increaseX = increaseXGPS.NextDouble() * 250;
                double increaseY = increaseYGPS.NextDouble() * 250;
                double X2 = X1 + increaseX;
                double Y2 = Y1 + increaseY;
                GPS GPS1 = new GPS('A', 'A', X1, Y1);
                GPS GPS2 = new GPS('A', 'A', X2, Y2);
                Parcel parcela = new Parcel(i, $"parcela { i }", GPS1, GPS2);
                list.Add(parcela);
                Tree.Insert(parcela);
            }
            if(Tree.GetNumberOfItemsInTree() == list.Count)
            {
                return true;
            }else
            {
                return false;
            }
        }

        public bool TestDelete()
        {
            Random genItemsToDelete = new Random();
            Random genItemToDelete = new Random();
            int numberOfItemsToDelete = genItemsToDelete.Next(list.Count);
            int itemToDelete = 0;
            for (int i = 0; i < numberOfItemsToDelete; i++)
            {
                itemToDelete = genItemToDelete.Next(list.Count - 1);
                Tree.Delete(list[itemToDelete]);
                list.RemoveAt(itemToDelete);
                if (Tree.GetNumberOfItemsInTree() != list.Count)
                {
                    return false;
                }
            }
            //int count = list.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    Tree.Delete(list[0]);
            //    list.RemoveAt(0);
            //}
            if (Tree.GetNumberOfItemsInTree() == list.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TestBoth()
        {
            list.Clear();
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
                X1 = randomGPS1.NextDouble() * (Tree.MaxX - 250);
                Y1 = randomGPS2.NextDouble() * (Tree.MaxY - 250);
                increaseX = increaseXGPS.NextDouble() * 250;
                increaseY = increaseYGPS.NextDouble() * 250;
                X2 = X1 + increaseX;
                Y2 = Y1 + increaseY;
                GPS GPS1 = new GPS('A', 'A', X1, Y1);
                GPS GPS2 = new GPS('A', 'A', X2, Y2);
                Parcel parcela = new Parcel(i, $"parcela {i}", GPS1, GPS2);
                list.Add(parcela);
                Tree.Insert(parcela);
            }

            double opearation;
            for (int i = 0; i < 50000; i++)
            {
                opearation = opeartionGen.NextDouble();
                if(opearation < 0.5)
                {
                    //insert
                    X1 = randomGPS1.NextDouble() * (Tree.MaxX - 250);
                    Y1 = randomGPS2.NextDouble() * (Tree.MaxY - 250);
                    increaseX = increaseXGPS.NextDouble() * 250;
                    increaseY = increaseYGPS.NextDouble() * 250;
                    X2 = X1 + increaseX;
                    Y2 = Y1 + increaseY;
                    GPS GPS1 = new GPS('A', 'A', X1, Y1);
                    GPS GPS2 = new GPS('A', 'A', X2, Y2);
                    Parcel parcela = new Parcel(i, $"parcela {i}", GPS1, GPS2);
                    list.Add(parcela);
                    Tree.Insert(parcela);
                    if (Tree.GetNumberOfItemsInTree() != list.Count)
                    {
                        return false;
                    }
                } else
                {
                    itemToDelete = genItemToDelete.Next(list.Count - 1);
                    Tree.Delete(list[itemToDelete]);
                    list.RemoveAt(itemToDelete);
                    if (Tree.GetNumberOfItemsInTree() != list.Count)
                    {
                        return false;
                    }
                }
            }

            if (Tree.GetNumberOfItemsInTree() != list.Count)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
