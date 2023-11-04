using AuS_QuadTree.Data;
using AuS_QuadTree.QuadTreeFolder;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuS_QuadTree.ImplementedFeatures
{
    public class Features
    {
        QuadTree<Parcel> parcels;
        QuadTree<Estate> estates;

        public QuadTree<Parcel> Parcels { get => parcels; set => parcels = value; }
        public QuadTree<Estate> Estates { get => estates; set => estates = value; }

        public Features()
        {
            Parcels = new QuadTree<Parcel>(0, 0, 100000, 100000, 20);
            Estates = new QuadTree<Estate>(0, 0, 100000, 100000, 20);
            populateTrees();
        }

        public void populateTrees()
        {
            Random randomGPS1 = new Random();
            Random randomGPS2 = new Random();
            Random increaseXGPS = new Random();
            Random increaseYGPS = new Random();

            Random randomGPS1Es = new Random();
            Random randomGPS2Es = new Random();
            Random increaseXGPSEs = new Random();
            Random increaseYGPSEs = new Random();

            for (int i = 0; i < 100000; i++)
            {
                double X1 = randomGPS1.NextDouble() * (Parcels.MaxX - 200);
                double Y1 = randomGPS2.NextDouble() * (Parcels.MaxY - 200);
                double increaseX = increaseXGPS.NextDouble() * 200;
                double increaseY = increaseYGPS.NextDouble() * 200;
                double X2 = X1 + increaseX;
                double Y2 = Y1 + increaseY;

                GPS GPS1 = GenerateGPS(X1, Y1);
                GPS GPS2 = GenerateGPS(X2, Y2);
                Parcel parcela = new Parcel(i, $"parcela {i}", GPS1, GPS2);
                Parcels.Insert(parcela);
            }


            for (int i = 0; i < 100000; i++)
            {
                double X1 = randomGPS1.NextDouble() * (Parcels.MaxX - 100);
                double Y1 = randomGPS2.NextDouble() * (Parcels.MaxY - 100);
                double increaseX = increaseXGPS.NextDouble() * 100;
                double increaseY = increaseYGPS.NextDouble() * 100;
                double X2 = X1 + increaseX;
                double Y2 = Y1 + increaseY;
                GPS GPS1 = GenerateGPS(X1, Y1);
                GPS GPS2 = GenerateGPS(X2, Y2);
                Estate nehnutelnost = new Estate(i, $"nehnutelnost {i}", GPS1, GPS2);
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
            return Parcels.Find(X1, Y1, X2, Y2);
        }

        public List<Estate> FindEstates(double X1, double Y1, double X2, double Y2)
        {
            return Estates.Find(X1, Y1, X2, Y2);
        }


        public void AddParcel(int index_, string description_, double X1, double Y1, double X2, double Y2)
        {
            GPS GPS1 = GenerateGPS(X1, Y1);
            GPS GPS2 = GenerateGPS(X2, Y2);

            Parcel parcela = new Parcel(index_, description_, GPS1, GPS2);
            List<Estate> nehnutelnosti = Estates.Find(GPS1.X, GPS1.Y, GPS2.X, GPS2.Y);
            foreach (Estate item in nehnutelnosti)
            {
                item.LocatedOn.Add(parcela);
                parcela.LocatedIn.Add(item);
            }
            Parcels.Insert(parcela);
        }

        public void AddEstate(int index_, string description_, double X1, double Y1, double X2, double Y2)
        {
            GPS GPS1 = GenerateGPS(X1, Y1);
            GPS GPS2 = GenerateGPS(X2, Y2);

            Estate nehnutelnost = new Estate(index_, description_, GPS1, GPS2);
            List<Parcel> parceli = Parcels.Find(GPS1.X, GPS1.Y, GPS2.X, GPS2.Y);
            foreach (Parcel item in parceli)
            {
                item.LocatedIn.Add(nehnutelnost);
                nehnutelnost.LocatedOn.Add(item);
            }
            Estates.Insert(nehnutelnost);
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
    }
}
