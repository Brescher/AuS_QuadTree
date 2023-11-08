using AuS_QuadTree.Data;
using AuS_QuadTree.QuadTreeFolder;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuS_QuadTree.ImplementedFeatures
{
    public class Features
    {
        QuadTree<Parcel> parcels;
        QuadTree<Estate> estates;

        List<Parcel> parceli = new List<Parcel>();
        List<Estate> nehnutelnosti = new List<Estate>();

        public QuadTree<Parcel> Parcels { get => parcels; set => parcels = value; }
        public QuadTree<Estate> Estates { get => estates; set => estates = value; }

        public Features()
        {
            TestOptimalization();
        }

        public void PopulateParcels(double x1, double y1, double x2, double y2, int height, int numberItems)
        {
            parcels = new QuadTree<Parcel>(x1, y1, x2, y2, height);
            Random randomGPS1 = new Random();
            Random randomGPS2 = new Random();
            Random increaseXGPS = new Random();
            Random increaseYGPS = new Random();

            for (int i = 0; i < numberItems; i++)
            {
                double X1 = Math.Round(randomGPS1.NextDouble() * (Parcels.MaxX - 200), 2);
                double Y1 = Math.Round(randomGPS2.NextDouble() * (Parcels.MaxY - 200), 2);
                double increaseX = Math.Round(increaseXGPS.NextDouble() * 200, 2);
                double increaseY = Math.Round(increaseYGPS.NextDouble() * 200, 2);
                double X2 = X1 + increaseX;
                double Y2 = Y1 + increaseY;

                GPS GPS1 = GenerateGPS(X1, Y1);
                GPS GPS2 = GenerateGPS(X2, Y2);
                Parcel parcela = new Parcel(i, $"parcela {i}", GPS1, GPS2);
                parcela.IdentificationKey = i;
                Parcels.Insert(parcela);
            }
        }

        public void PopulateEstates(double x1, double y1, double x2, double y2, int height, int numberItems)
        {
            estates = new QuadTree<Estate>(x1, y1, x2, y2, height);

            Random randomGPS1 = new Random();
            Random randomGPS2 = new Random();
            Random increaseXGPS = new Random();
            Random increaseYGPS = new Random();

            for (int i = 0; i < 100000; i++)
            {
                double X1 = Math.Round(randomGPS1.NextDouble() * (Parcels.MaxX - 100), 2);
                double Y1 = Math.Round(randomGPS2.NextDouble() * (Parcels.MaxY - 100), 2);
                double increaseX = Math.Round(increaseXGPS.NextDouble() * 100, 2);
                double increaseY = Math.Round(increaseYGPS.NextDouble() * 100, 2);
                double X2 = X1 + increaseX;
                double Y2 = Y1 + increaseY;
                GPS GPS1 = GenerateGPS(X1, Y1);
                GPS GPS2 = GenerateGPS(X2, Y2);
                Estate nehnutelnost = new Estate(i, $"nehnutelnost {i}", GPS1, GPS2);
                nehnutelnost.IdentificationKey = i;
                List<Parcel> parceli = Parcels.Find(X1, Y1, X2, Y2);
                foreach (Parcel item in parceli)
                {
                    item.LocatedIn.Add(nehnutelnost);
                    nehnutelnost.LocatedOn.Add(item);
                }
                Estates.Insert(nehnutelnost);
            }
        }

        public List<Parcel> FindParcels(double X1, double Y1, double X2, double Y2)
        {
            return parceli = Parcels.Find(X1, Y1, X2, Y2);
        }

        public List<Estate> FindEstates(double X1, double Y1, double X2, double Y2)
        {
            return nehnutelnosti = Estates.Find(X1, Y1, X2, Y2);
        }


        public void AddParcel(int index_, int key_, string description_, double X1, double Y1, double X2, double Y2)
        {
            GPS GPS1 = GenerateGPS(X1, Y1);
            GPS GPS2 = GenerateGPS(X2, Y2);

            Parcel parcela = new Parcel(index_, description_, GPS1, GPS2);
            parcela.IdentificationKey = key_;
            List<Estate> est = Estates.Find(GPS1.X, GPS1.Y, GPS2.X, GPS2.Y);
            foreach (Estate item in est)
            {
                item.LocatedOn.Add(parcela);
                parcela.LocatedIn.Add(item);
            }
            Parcels.Insert(parcela);
        }

        public void AddEstate(int index_, int key_, string description_, double X1, double Y1, double X2, double Y2)
        {
            GPS GPS1 = GenerateGPS(X1, Y1);
            GPS GPS2 = GenerateGPS(X2, Y2);

            Estate nehnutelnost = new Estate(index_, description_, GPS1, GPS2);
            nehnutelnost.IdentificationKey = key_;
            List<Parcel> par = Parcels.Find(GPS1.X, GPS1.Y, GPS2.X, GPS2.Y);
            foreach (Parcel item in par)
            {
                item.LocatedIn.Add(nehnutelnost);
                nehnutelnost.LocatedOn.Add(item);
            }
            Estates.Insert(nehnutelnost);
        }

        public void DeleteParcel(Parcel parcel)
        {
            parcels.Delete(parcel);
            List<Estate> est = estates.Find(parcel.LowerBound.X, parcel.LowerBound.Y, parcel.UpperBound.X, parcel.UpperBound.Y);
            foreach (Estate item in est)
            {
                item.LocatedOn.Remove(parcel);
            }
        }

        public void DeleteEstate(Estate estate)
        {
            estates.Delete(estate);
            List<Parcel> par = parcels.Find(estate.LowerBound.X, estate.LowerBound.Y, estate.UpperBound.X, estate.UpperBound.Y);
            foreach (Parcel item in par)
            {
                item.LocatedIn.Remove(estate);
            }
        }

        public GPS GenerateGPS(double X1, double Y1)
        {
            char latitude, longitude;
            if (X1 > parcels.MaxX / 2)
            {
                longitude = 'E';
            }
            else
            {
                longitude = 'W';
            }

            if (Y1 > parcels.MaxY / 2)
            {
                latitude = 'S';
            }
            else
            {
                latitude = 'N';
            }

            GPS GPS1 = new GPS(latitude, longitude, X1, Y1);
            return GPS1;
        }

        public void Save()
        {
            StringBuilder parcelsText = new StringBuilder();
            StringBuilder estatesText = new StringBuilder();
            List<Parcel> dataParcels = parcels.Find(parcels.MinX, parcels.MinY, parcels.MaxX, parcels.MaxY);
            List<Estate> dataEstates = estates.Find(estates.MinX, estates.MinY, estates.MaxX, estates.MaxY);
            parcelsText.AppendLine($"{parcels.MinX}; {parcels.MinY}; {parcels.MaxX}; {parcels.MaxY}; {parcels.MaxHeight}");
            estatesText.AppendLine($"{estates.MinX}; {estates.MinY}; {estates.MaxX}; {estates.MaxY}; {estates.MaxHeight}");
            foreach (Parcel par in dataParcels)
            {
                parcelsText.AppendLine($"{par.Index}; {par.IdentificationKey}; {par.Description}; " +
                                       $"{par.LowerBound.X}; {par.LowerBound.Y}; " +
                                       $"{par.UpperBound.X}; {par.UpperBound.Y}");
            }

            foreach (Estate est in dataEstates)
            {
                estatesText.AppendLine($"{est.Index}; {est.IdentificationKey}; {est.Description}; " +
                                       $"{est.LowerBound.X}; {est.LowerBound.Y}; " +
                                       $"{est.UpperBound.X}; {est.UpperBound.Y}");
            }

            File.WriteAllText(@"..\..\..\Data\parcels.csv", parcelsText.ToString());
            File.WriteAllText(@"..\..\..\Data\estates.csv", estatesText.ToString());
        }

        public void Load()
        {
            LoadParcels();
            LoadEstates();
            int i = Parcels.GetNumberOfItemsInTree();
            int j = Estates.GetNumberOfItemsInTree();
            CreateReferences();
        }

        public void LoadParcels()
        {
            string filePath = @"..\..\..\Data\parcels.csv"; 

            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");

                string[] headerFields = parser.ReadFields();

                if (headerFields.Length != 5)
                {
                    Console.WriteLine("Invalid header format.");
                    return;
                }

                double minX = double.Parse(headerFields[0]);
                double minY = double.Parse(headerFields[1]);
                double maxX = double.Parse(headerFields[2]);
                double maxY = double.Parse(headerFields[3]);
                int height = int.Parse(headerFields[4]);

                Parcels = new QuadTree<Parcel>(minX, minY, maxX, maxY, height);

                List<Parcel> dataItems = new List<Parcel>();

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    if (fields.Length != 7)
                    {
                        Console.WriteLine("Invalid data format.");
                        return;
                    }

                    int id = int.Parse(fields[0]);
                    int key = int.Parse(fields[1]);
                    string description = fields[2];
                    double x1 = double.Parse(fields[3]);
                    double y1 = double.Parse(fields[4]);
                    double x2 = double.Parse(fields[5]);
                    double y2 = double.Parse(fields[6]);

                    GPS gps1 = GenerateGPS(x1, y1);
                    GPS gps2 = GenerateGPS(x2, y2);
                    Parcel item = new Parcel(id, description, gps1, gps2);
                    item.IdentificationKey = key;
                    Parcels.Insert(item);
                }
            }
        }

        public void LoadEstates()
        {
            string filePath = @"..\..\..\Data\estates.csv";

            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");

                string[] headerFields = parser.ReadFields();

                if (headerFields.Length != 5)
                {
                    Console.WriteLine("Invalid header format.");
                    return;
                }

                double minX = double.Parse(headerFields[0]);
                double minY = double.Parse(headerFields[1]);
                double maxX = double.Parse(headerFields[2]);
                double maxY = double.Parse(headerFields[3]);
                int height = int.Parse(headerFields[4]);

                Estates = new QuadTree<Estate>(minX, minY, maxX, maxY, height);

                List<Estate> dataItems = new List<Estate>();

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    if (fields.Length != 7)
                    {
                        Console.WriteLine("Invalid data format.");
                        return;
                    }

                    int id = int.Parse(fields[0]);
                    int key = int.Parse(fields[1]);
                    string description = fields[2];
                    double x1 = double.Parse(fields[3]);
                    double y1 = double.Parse(fields[4]);
                    double x2 = double.Parse(fields[5]);
                    double y2 = double.Parse(fields[6]);

                    GPS gps1 = GenerateGPS(x1, y1);
                    GPS gps2 = GenerateGPS(x2, y2);
                    Estate item = new Estate(id, description, gps1, gps2);
                    item.IdentificationKey = key;
                    Estates.Insert(item);
                }
            }
        }

        public void CreateReferences()
        {
            List<Parcel> parceli = Parcels.Find(Parcels.MinX, Parcels.MinY, Parcels.MaxX, Parcels.MaxY);
            foreach (Parcel par in parceli)
            {
                List<Estate> nehnutelnosti = Estates.Find(par.LowerBound.X, par.LowerBound.Y, par.UpperBound.X, par.UpperBound.Y);
                foreach (Estate est in nehnutelnosti)
                {
                    par.LocatedIn.Add(est);
                    est.LocatedOn.Add(par);
                }
            }
        }

        public void TestOptimalization()
        {
            QuadTree<Parcel> parcelsTest = new QuadTree<Parcel>(0, 0, 10000000, 10000000, 5);
            Random randomGPS1 = new Random();
            Random randomGPS2 = new Random();
            Random increaseXGPS = new Random();
            Random increaseYGPS = new Random();
            double x = (parcelsTest.MaxX - parcelsTest.MinX) / 2;
            double y = (parcelsTest.MaxY - parcelsTest.MinY) / 2;

            for (int i = 0; i < 1000000; i++)
            {
                double X1 = Math.Round(randomGPS1.NextDouble() * (x - 25), 2);
                double Y1 = Math.Round(randomGPS2.NextDouble() * (y - 25), 2);
                double increaseX = Math.Round(increaseXGPS.NextDouble() * 200, 2);
                double increaseY = Math.Round(increaseYGPS.NextDouble() * 200, 2);
                double X2 = X1 + increaseX;
                double Y2 = Y1 + increaseY;

                GPS GPS1 = new GPS('A', 'A', X1, Y1);
                GPS GPS2 = new GPS('A', 'A', X2, Y2);
                Parcel parcela = new Parcel(i, $"parcela {i}", GPS1, GPS2);
                parcela.IdentificationKey = i;
                parcelsTest.Insert(parcela);
            }

            int key = parcelsTest.GetNumberOfItemsInTree();
            double msInsertUnoptimalized = 0;
            double msDeleteUnoptimalized = 0;
            Stopwatch stopwatchInsert = new Stopwatch();
            Stopwatch stopwatchDelete = new Stopwatch();
            for (int i = 0; i < 100000; i++)
            {
                double X1 = Math.Round(randomGPS1.NextDouble() * (x - 25), 2);
                double Y1 = Math.Round(randomGPS2.NextDouble() * (y - 25), 2);
                double increaseX = Math.Round(increaseXGPS.NextDouble() * 25, 2);
                double increaseY = Math.Round(increaseYGPS.NextDouble() * 25, 2);
                double X2 = X1 + increaseX;
                double Y2 = Y1 + increaseY;

                GPS GPS1 = new GPS('A', 'A', X1, Y1);
                GPS GPS2 = new GPS('A', 'A', X2, Y2);
                Parcel parcela = new Parcel(i, $"parcela {i}", GPS1, GPS2);
                parcela.IdentificationKey = key + 1;
                //toto merat
                stopwatchInsert.Start();
                parcelsTest.Insert(parcela);
                stopwatchInsert.Stop();
                msInsertUnoptimalized += stopwatchInsert.ElapsedMilliseconds;

                //toto merat
                stopwatchDelete.Start();
                parcelsTest.Delete(parcela);
                stopwatchDelete.Stop();
                msDeleteUnoptimalized += stopwatchDelete.ElapsedMilliseconds;


            }

            parcelsTest.TreeHealth();



            int items = parcelsTest.GetNumberOfItemsInTree();
            double msInsertOptimalized = 0;
            double msDeleteOptimalized = 0;
            Stopwatch stopwatchInsertOpt = new Stopwatch();
            Stopwatch stopwatchDeleteOpt = new Stopwatch();
            for (int i = 0; i < 100000; i++)
            {
                double X1 = Math.Round(randomGPS1.NextDouble() * (x - 25), 2);
                double Y1 = Math.Round(randomGPS2.NextDouble() * (y - 25), 2);
                double increaseX = Math.Round(increaseXGPS.NextDouble() * 25, 2);
                double increaseY = Math.Round(increaseYGPS.NextDouble() * 25, 2);
                double X2 = X1 + increaseX;
                double Y2 = Y1 + increaseY;

                GPS GPS1 = new GPS('A', 'A', X1, Y1);
                GPS GPS2 = new GPS('A', 'A', X2, Y2);
                Parcel parcela = new Parcel(i, $"parcela {i}", GPS1, GPS2);
                parcela.IdentificationKey = key + 1;
                //toto merat
                stopwatchInsertOpt.Start();
                parcelsTest.Insert(parcela);
                stopwatchInsertOpt.Stop();
                msInsertOptimalized += stopwatchInsertOpt.ElapsedMilliseconds;
                //toto merat
                stopwatchDeleteOpt.Start();
                parcelsTest.Delete(parcela);
                stopwatchDeleteOpt.Stop();
                msDeleteOptimalized += stopwatchDeleteOpt.ElapsedMilliseconds;
            }


            double avgInsert = stopwatchInsert.ElapsedMilliseconds / 100000d;//msInsertUnoptimalized / 100000;//stopwatchInsert.ElapsedMilliseconds / 100000d;
            double avgDelete = stopwatchDelete.ElapsedMilliseconds / 100000d;//msDeleteUnoptimalized / 100000;//stopwatchDelete.ElapsedMilliseconds / 100000d;
            double avgInsertOpt = stopwatchInsertOpt.ElapsedMilliseconds / 100000d;//msInsertOptimalized / 100000d; //stopwatchInsertOpt.ElapsedMilliseconds / 100000d;
            double avgDeleteOpt = stopwatchDeleteOpt.ElapsedMilliseconds / 100000d;//msDeleteOptimalized / 100000d; //stopwatchDeleteOpt.ElapsedMilliseconds / 100000d;
        }
    }
}
