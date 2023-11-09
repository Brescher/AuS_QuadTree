using AuS_QuadTree.Data;
using AuS_QuadTree.ImplementedFeatures;
using AuS_QuadTree.QuadTreeFolder;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace AuS_QuadTree
{
    public partial class Form1 : Form
    {
        Features feat = new Features();
        List<Parcel> parcels = new List<Parcel>();
        List<Estate> estates = new List<Estate>();

        int findItem = 0;
        public Form1()
        {
            InitializeComponent();
            //test();
        }



        private void findParcels_Click(object sender, EventArgs e)
        {
            parcels.Clear();
            parcels = feat.FindParcels(Convert.ToDouble(X1.Text), Convert.ToDouble(Y1.Text), Convert.ToDouble(X2.Text), Convert.ToDouble(Y2.Text));
            int i = 1;
            dataGridView1.Rows.Clear();
            foreach (Parcel item in parcels)
            {
                dataGridView1.Rows.Add(i, item.Index, item.IdentificationKey, item.Description, Math.Round(item.LowerBound.X, 2), Math.Round(item.LowerBound.Y, 2), Math.Round(item.UpperBound.X, 2), Math.Round(item.UpperBound.Y, 2),
                     item.LowerBound.Latitude + " | " + item.LowerBound.Longitude, item.UpperBound.Latitude + " | " + item.UpperBound.Longitude);
                i++;
            }
            findItem = 1;
        }

        private void findEstates_Click(object sender, EventArgs e)
        {
            estates.Clear();
            estates = feat.FindEstates(Convert.ToDouble(X1.Text), Convert.ToDouble(Y1.Text), Convert.ToDouble(X2.Text), Convert.ToDouble(Y2.Text));
            int i = 1;
            dataGridView1.Rows.Clear();
            foreach (Estate item in estates)
            {
                dataGridView1.Rows.Add(i, item.Index, item.IdentificationKey, item.Description, Math.Round(item.LowerBound.X, 2), Math.Round(item.LowerBound.Y, 2), Math.Round(item.UpperBound.X, 2), Math.Round(item.UpperBound.Y, 2),
                     item.LowerBound.Latitude + " | " + item.LowerBound.Longitude, item.UpperBound.Latitude + " | " + item.UpperBound.Longitude);
                i++;
            }
            findItem = 2;
        }

        private void findBoth_Click(object sender, EventArgs e)
        {
            parcels.Clear();
            estates.Clear();
            parcels = feat.FindParcels(Convert.ToDouble(X1.Text), Convert.ToDouble(Y1.Text), Convert.ToDouble(X2.Text), Convert.ToDouble(Y2.Text));
            estates = feat.FindEstates(Convert.ToDouble(X1.Text), Convert.ToDouble(Y1.Text), Convert.ToDouble(X2.Text), Convert.ToDouble(Y2.Text));
            int i = 1;
            dataGridView1.Rows.Clear();
            foreach (Parcel item in parcels)
            {
                dataGridView1.Rows.Add(i, item.Index, item.IdentificationKey, item.Description, Math.Round(item.LowerBound.X, 2), Math.Round(item.LowerBound.Y, 2), Math.Round(item.UpperBound.X, 2), Math.Round(item.UpperBound.Y, 2),
                     item.LowerBound.Latitude + " | " + item.LowerBound.Longitude, item.UpperBound.Latitude + " | " + item.UpperBound.Longitude);
                i++;
            }
            foreach (Estate item in estates)
            {
                dataGridView1.Rows.Add(i, item.Index, item.IdentificationKey, item.Description, Math.Round(item.LowerBound.X, 2), Math.Round(item.LowerBound.Y, 2), Math.Round(item.UpperBound.X, 2), Math.Round(item.UpperBound.Y, 2),
                     item.LowerBound.Latitude + " | " + item.LowerBound.Longitude, item.UpperBound.Latitude + " | " + item.UpperBound.Longitude);
                i++;
            }
            findItem = 3;
        }

        private void insertParcel_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(number.Text);
            int key = Convert.ToInt32(keyBox.Text);
            string desc = description.Text;
            double x1 = Convert.ToDouble(insertX1.Text);
            double y1 = Convert.ToDouble(insertY1.Text);
            double x2 = Convert.ToDouble(insertX2.Text);
            double y2 = Convert.ToDouble(insertY2.Text);

            feat.AddParcel(i, key, desc, x1, y1, x2, y2);
        }

        private void insertEstate_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(number.Text);
            int key = Convert.ToInt32(keyBox.Text);
            string desc = description.Text;
            double x1 = Convert.ToDouble(insertX1.Text);
            double y1 = Convert.ToDouble(insertY1.Text);
            double x2 = Convert.ToDouble(insertX2.Text);
            double y2 = Convert.ToDouble(insertY2.Text);

            feat.AddEstate(i, key, desc, x1, y1, x2, y2);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(indexToEdit.Text);


            switch (findItem)
            {
                case 0:
                    break;
                case 1:
                    EditParcel(index);
                    break;
                case 2:
                    EditEstate(index);
                    break;
                case 3:
                    int sizeOfParcels = parcels.Count;
                    int sizeOfEstates = estates.Count;
                    if (index > sizeOfParcels)
                    {
                        EditEstate(index - sizeOfParcels);
                    }
                    else
                    {
                        EditParcel(index);
                    }
                    break;
                default:
                    break;
            }
        }

        private void EditParcel(int index)
        {
            int newNumber = 0, key = 0;
            string desc = "";
            double x1 = 0, y1 = 0, x2 = 0, y2 = 0;
            if (!string.IsNullOrEmpty(editNumber.Text))
            {
                newNumber = Convert.ToInt32(editNumber.Text);
            }
            if (!string.IsNullOrEmpty(editDesc.Text))
            {
                desc = editDesc.Text;
            }
            if (!string.IsNullOrEmpty(editX1.Text))
            {
                x1 = Convert.ToDouble(editX1.Text);
            }
            if (!string.IsNullOrEmpty(editY1.Text))
            {
                y1 = Convert.ToDouble(editY1.Text);
            }
            if (!string.IsNullOrEmpty(editX2.Text))
            {
                x2 = Convert.ToDouble(editX2.Text);
            }
            if (!string.IsNullOrEmpty(editY2.Text))
            {
                y2 = Convert.ToDouble(editY2.Text);
            }

            Parcel old = parcels[index - 1];

            if (x1 == 0 && y1 == 0 && x2 == 0 && y2 == 0)
            {
                if (newNumber != 0)
                {
                    old.Index = newNumber;
                }
                if (!desc.Equals(""))
                {
                    old.Description = desc;
                }
            }
            else
            {
                if (newNumber == 0)
                {
                    newNumber = old.Index;
                }
                if (desc.Equals(""))
                {
                    desc = old.Description;
                }
                if (x1 == 0)
                {
                    x1 = old.LowerBound.X;
                }
                if (y1 == 0)
                {
                    y1 = old.LowerBound.Y;
                }
                if (x2 == 0)
                {
                    x2 = old.UpperBound.X;
                }
                if (y2 == 0)
                {
                    y2 = old.UpperBound.Y;
                }
                key = old.IdentificationKey;
                feat.DeleteParcel(old);
                feat.AddParcel(newNumber, key, desc, x1, y1, x2, y2);
            }
        }

        private void EditEstate(int index)
        {
            int newNumber = 0, key = 0;
            string desc = "";
            double x1 = 0, y1 = 0, x2 = 0, y2 = 0;
            if (!string.IsNullOrEmpty(editNumber.Text))
            {
                newNumber = Convert.ToInt32(editNumber.Text);
            }
            if (!string.IsNullOrEmpty(editDesc.Text))
            {
                desc = editDesc.Text;
            }
            if (!string.IsNullOrEmpty(editX1.Text))
            {
                x1 = Convert.ToDouble(editX1.Text);
            }
            if (!string.IsNullOrEmpty(editY1.Text))
            {
                y1 = Convert.ToDouble(editY1.Text);
            }
            if (!string.IsNullOrEmpty(editX2.Text))
            {
                x2 = Convert.ToDouble(editX2.Text);
            }
            if (!string.IsNullOrEmpty(editY2.Text))
            {
                y2 = Convert.ToDouble(editY2.Text);
            }

            Estate oldE = estates[index - 1];
            if (x1 == 0 && y1 == 0 && x2 == 0 && y2 == 0)
            {
                if (newNumber != 0)
                {
                    oldE.Index = newNumber;
                }
                if (!desc.Equals(""))
                {
                    oldE.Description = desc;
                }
            }
            else
            {
                if (newNumber == 0)
                {
                    newNumber = oldE.Index;
                }
                if (desc.Equals(""))
                {
                    desc = oldE.Description;
                }
                if (x1 == 0)
                {
                    x1 = oldE.LowerBound.X;
                }
                if (y1 == 0)
                {
                    y1 = oldE.LowerBound.Y;
                }
                if (x2 == 0)
                {
                    x2 = oldE.UpperBound.X;
                }
                if (y2 == 0)
                {
                    y2 = oldE.UpperBound.Y;
                }
                key = oldE.IdentificationKey;
                feat.DeleteEstate(oldE);
                feat.AddEstate(newNumber, key, desc, x1, y1, x2, y2);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(indexToDelete.Text);


            switch (findItem)
            {
                case 0:
                    break;
                case 1:
                    feat.DeleteParcel(parcels[index - 1]);
                    break;
                case 2:
                    feat.DeleteEstate(estates[index - 1]);
                    break;
                case 3:
                    int sizeOfParcels = parcels.Count;
                    int sizeOfEstates = estates.Count;
                    if (index > sizeOfParcels)
                    {
                        feat.DeleteEstate(estates[index - 1 - sizeOfParcels]);
                    }
                    else
                    {
                        feat.DeleteParcel(parcels[index - 1]);
                    }
                    break;
                default:
                    break;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            feat.Save();
        }

        private void load_Click(object sender, EventArgs e)
        {
            feat.Load();
        }

        private void Populate_Click(object sender, EventArgs e)
        {
            double pX1 = Convert.ToDouble(parcelsX1.Text);
            double pY1 = Convert.ToDouble(parcelsY1.Text);
            double pX2 = Convert.ToDouble(parcelsX2.Text);
            double pY2 = Convert.ToDouble(parcelsY2.Text);
            int pHeight = Convert.ToInt32(parcelsHeight.Text);
            int pItems = Convert.ToInt32(parcelsItems.Text);
            double pMaxW = Convert.ToDouble(pMaxWidth.Text);
            double pMaxL = Convert.ToDouble(pMaxLength.Text);

            double eX1 = Convert.ToDouble(estatesX1.Text);
            double eY1 = Convert.ToDouble(estatesY1.Text);
            double eX2 = Convert.ToDouble(estatesX2.Text);
            double eY2 = Convert.ToDouble(estatesY2.Text);
            int eHeight = Convert.ToInt32(estatesHeight.Text);
            int eItems = Convert.ToInt32(estatesItems.Text);
            double eMaxW = Convert.ToDouble(eMaxWidth.Text);
            double eMaxL = Convert.ToDouble(eMaxLength.Text);

            feat.PopulateParcels(pX1, pY1, pX2, pY2, pHeight, pItems, pMaxW, pMaxL);
            feat.PopulateEstates(eX1, eY1, eX2, eY2, eHeight, eItems, eMaxW, eMaxL);
        }

        private void optimizeBtn_Click(object sender, EventArgs e)
        {
            feat.Optimize();
        }
    }
}