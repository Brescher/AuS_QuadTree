using AuS_QuadTree.Data;
using AuS_QuadTree.ImplementedFeatures;
using AuS_QuadTree.QuadTreeFolder;
using System.Collections;
using System.Collections.Generic;

namespace AuS_QuadTree
{
    public partial class Form1 : Form
    {
        Features feat = new Features();
        public Form1()
        {
            InitializeComponent();
            //test();
        }

        public void test()
        {
            QuadTree<Parcel> tree = new QuadTree<Parcel>(10000, 10000, 50);
            List<Parcel> list = new List<Parcel>();
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
            for (int i = 0; i < 10; i++)
            {
                double X1 = randomFind1.NextDouble() * (tree.MaxX - tree.MaxX / 2);
                double Y1 = randomFind2.NextDouble() * (tree.MaxY - tree.MaxY / 2);
                double increaseX = randomFindincreaseX.NextDouble() * (tree.MaxX / 2);
                double increaseY = randomFindincreaseY.NextDouble() * (tree.MaxY / 2);
                double X2 = X1 + increaseX;
                double Y2 = Y1 + increaseY;
                find = tree.Find(X1, Y1, X2, Y2);

                bool foundOne = false;
                foreach (Parcel item in find)
                {
                    foundOne = false;
                    foreach (Parcel item1 in list)
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

        }

        private void findParcels_Click(object sender, EventArgs e)
        {
            List<Parcel> parcels = feat.FindParcels(Convert.ToDouble(X1.Text), Convert.ToDouble(Y1.Text), Convert.ToDouble(X2.Text), Convert.ToDouble(Y2.Text));
            int i = 1;
            string text = "";
            foreach (Parcel item in parcels)
            {
                text += $"\r\n{i}. {item.Index},  {item.Description},  " +
                        $"\r\n{Math.Round(item.LowerBound.X, 2)} | {Math.Round(item.LowerBound.Y, 2)} | {item.LowerBound.Latitude} {item.LowerBound.Longitude}" +
                        $"\r\n{Math.Round(item.UpperBound.X, 2)} | {Math.Round(item.UpperBound.Y, 2)} | {item.UpperBound.Latitude} {item.UpperBound.Longitude}";
                i++;
            }
            output.Text = text;
        }

        private void findEstates_Click(object sender, EventArgs e)
        {
            List<Estate> estates = feat.FindEstates(Convert.ToDouble(X1.Text), Convert.ToDouble(Y1.Text), Convert.ToDouble(X2.Text), Convert.ToDouble(Y2.Text));
            int i = 1;
            string text = "";
            foreach (Estate item in estates)
            {
                text += $"\r\n{i}. {item.Index},  {item.Description},  " +
                        $"\r\n{Math.Round(item.LowerBound.X, 2)} | {Math.Round(item.LowerBound.Y, 2)} | {item.LowerBound.Latitude} {item.LowerBound.Longitude}" +
                        $"\r\n{Math.Round(item.UpperBound.X, 2)} | {Math.Round(item.UpperBound.Y, 2)} | {item.UpperBound.Latitude} {item.UpperBound.Longitude}";
                i++;
            }
            output.Text = text;
        }

        private void findBoth_Click(object sender, EventArgs e)
        {
            List<Parcel> parcels = feat.FindParcels(Convert.ToDouble(X1.Text), Convert.ToDouble(Y1.Text), Convert.ToDouble(X2.Text), Convert.ToDouble(Y2.Text));
            List<Estate> estates = feat.FindEstates(Convert.ToDouble(X1.Text), Convert.ToDouble(Y1.Text), Convert.ToDouble(X2.Text), Convert.ToDouble(Y2.Text));
            int i = 1;
            string text = "";
            foreach (Parcel item in parcels)
            {
                text += $"\r\n{i}. {item.Index},  {item.Description},  " +
                        $"\r\n{Math.Round(item.LowerBound.X, 2)} | {Math.Round(item.LowerBound.Y, 2)} | {item.LowerBound.Latitude} {item.LowerBound.Longitude}" +
                        $"\r\n{Math.Round(item.UpperBound.X, 2)} | {Math.Round(item.UpperBound.Y, 2)} | {item.UpperBound.Latitude} {item.UpperBound.Longitude}";
                i++;
            }
            foreach (Estate item in estates)
            {
                text += $"\r\n{i}. {item.Index},  {item.Description},  " +
                        $"\r\n{Math.Round(item.LowerBound.X, 2)} | {Math.Round(item.LowerBound.Y, 2)} | {item.LowerBound.Latitude} {item.LowerBound.Longitude}" +
                        $"\r\n{Math.Round(item.UpperBound.X, 2)} | {Math.Round(item.UpperBound.Y, 2)} | {item.UpperBound.Latitude} {item.UpperBound.Longitude}";
                i++;
            }
            output.Text = text;

        }

        private void insertParcel_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(number.Text);
            string desc = description.Text;
            double x1 = Convert.ToDouble(insertX1.Text);
            double y1 = Convert.ToDouble(insertY1.Text);
            double x2 = Convert.ToDouble(insertX2.Text);
            double y2 = Convert.ToDouble(insertY2.Text);

            feat.AddParcel(i, desc, x1, y1, x2, y2);
        }

        private void insertEstate_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(number.Text);
            string desc = description.Text;
            double x1 = Convert.ToDouble(insertX1.Text);
            double y1 = Convert.ToDouble(insertY1.Text);
            double x2 = Convert.ToDouble(insertX2.Text);
            double y2 = Convert.ToDouble(insertY2.Text);

            feat.AddEstate(i, desc, x1, y1, x2, y2);
        }
    }
}