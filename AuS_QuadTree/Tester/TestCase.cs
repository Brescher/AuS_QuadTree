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
        QuadTree<Parcel> quadTree = new QuadTree<Parcel>(10000, 10000, 50);
        List<Parcel> list = new List<Parcel>();

        public TestCase()
        {
            
        }

        public bool TestInsert()
        {
            Random randomGPS1 = new Random();
            Random randomGPS2 = new Random();
            Random increaseXGPS = new Random();
            Random increaseYGPS = new Random();

            for(int i = 0; i < 10000; i++)
            {
                double X1 = randomGPS1.NextDouble() * (quadTree.MaxX - 250);
                double Y1 = randomGPS2.NextDouble() * (quadTree.MaxY - 250);
                double increaseX = increaseXGPS.NextDouble() * 250;
                double increaseY = increaseYGPS.NextDouble() * 250;
                double X2 = X1 + increaseX;
                double Y2 = Y1 + increaseY;
                GPS GPS1 = new GPS('A', 'A', X1, Y1);
                GPS GPS2 = new GPS('A', 'A', X2, Y2);
                Parcel parcela = new Parcel(i, $"parcela { i }", GPS1, GPS2);
                list.Add(parcela);
                quadTree.Insert(parcela);
            }
            if(quadTree.GetNumberOfItemsInTree() == list.Count)
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
                quadTree.Delete(list[itemToDelete]);
                list.RemoveAt(itemToDelete);
            }
            //int count = list.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    quadTree.Delete(list[0]);
            //    list.RemoveAt(0);
            //}
            if (quadTree.GetNumberOfItemsInTree() == list.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
