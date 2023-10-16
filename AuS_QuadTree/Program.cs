using AuS_QuadTree.Data;
using AuS_QuadTree.QuadTreeFolder;

namespace AuS_QuadTree
{
    //internal static class Program
    //{
    //    /// <summary>
    //    ///  The main entry point for the application.
    //    /// </summary>
    //    [STAThread]
    //    static void Main()
    //    {
    //        // To customize application configuration such as set high DPI settings or default font,
    //        // see https://aka.ms/applicationconfiguration.
    //        ApplicationConfiguration.Initialize();
    //        Application.Run(new Form1());
    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            GPS gps1 = new GPS('N', 'W', 7d, 7d);
            GPS gps2 = new GPS('N', 'W', 13d, 13d);
            GPS gps3 = new GPS('N', 'W', 11d, 11d);
            GPS gps4 = new GPS('N', 'W', 20d, 20d);
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
            //tree.Insert(p1);
            //tree.Insert(p2);
            tree.Insert(p3);
            tree.Insert(p4);
            tree.Insert(p5);
        }
    }
}