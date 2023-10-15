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
            GPS gps1 = new GPS('N', 'W', 7, 7);
            GPS gps2 = new GPS('N', 'W', 13, 13);
            GPS gps3 = new GPS('N', 'W', 11, 11);
            GPS gps4 = new GPS('N', 'W', 20, 20);
            Parcel p1 = new Parcel(1, "parcela 1", gps1, gps2);
            Parcel p2 = new Parcel(2, "parcela 2", gps3, gps4);

            QuadTree<Parcel> tree = new QuadTree<Parcel>(100d, 100d, 10);
            tree.Insert(p1);
            tree.Insert(p2);
        }
    }
}