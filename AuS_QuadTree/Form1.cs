using AuS_QuadTree.Data;
using AuS_QuadTree.QuadTreeFolder;
using System.Collections.Generic;

namespace AuS_QuadTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Run();
            Test();
        }

        public void Test()
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
            for (int j = 0; j < 1000; j++)
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
                        result = false;
                    }
                    list.RemoveAt(itemToDelete);
                    if (tree.GetNumberOfItemsInTree() != list.Count)
                    {
                        result = false;
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


        }

        public void Run()
        {
            GPS gps1 = new GPS('N', 'W', 1d, 1d);
            GPS gps2 = new GPS('N', 'W', 2d, 2d);
            GPS gps3 = new GPS('N', 'W', 4d, 4d);
            GPS gps4 = new GPS('N', 'W', 5d, 5d);
            GPS gps5 = new GPS('N', 'W', 55d, 55d);
            GPS gps6 = new GPS('N', 'W', 70d, 70d);
            GPS gps7 = new GPS('N', 'W', 89d, 92d);
            GPS gps8 = new GPS('N', 'W', 95d, 98d);
            GPS gps9 = new GPS('N', 'W', 44d, 44d);
            GPS gps10 = new GPS('N', 'W', 55d, 55d);
            Parcel p1 = new Parcel(1, "parcela 1", gps1, gps2);
            Parcel p2 = new Parcel(2, "parcela 2", gps3, gps4);
            Parcel p3 = new Parcel(3, "parcela 3", gps5, gps6);
            Parcel p4 = new Parcel(4, "parcela 4", gps7, gps8);
            Parcel p5 = new Parcel(5, "parcela 5", gps9, gps10);

            QuadTree<Parcel> tree = new QuadTree<Parcel>(100d, 100d, 10);
            tree.Insert(p1);
            tree.Insert(p2);
            tree.Insert(p3);
            tree.Insert(p4);
            tree.Insert(p5);
            //tree.Delete(p3);
            List<Parcel> list = new List<Parcel>();
            list = tree.Find(0, 0, 100, 100);
            string text = "";

            tree.ChangeHeight(2);
            foreach (Parcel p in list)
            {
                Console.WriteLine($"this is result {p.Description}");
                text += $"this is result {p.Description}\n";
                
            }
            text += $"\n\r Tree health is {tree.GetTreeHealth()}";
            textBox1.Text = text;
        }
    }
}