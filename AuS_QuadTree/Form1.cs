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