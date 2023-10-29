using AuS_QuadTree.Data;
using AuS_QuadTree.QuadTreeFolder;
using AuS_QuadTree.Tester;

namespace AuS_QuadTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Test();
            TestInsertAndDelete();
        }


        public void TestInsertAndDelete()
        {
            TestCase test = new TestCase();
            string text = "";
            if (test.TestInsert())
            {
                text += "\r\nDo stromu sa vlozili vsetky prvky.";
            } else
            {
                text += "\r\nDo stromu sa nevlozili vsetky prvky.";
            }

            if (test.TestDelete())
            {
                text += "\r\nVymazal sa pocet prvkov ktory sa mal";
                text += test.Tree.GetNumberOfItemsInTree();
            }
            else
            {
                text += "\r\nNevymazal sa pocet prvkov ktory sa mal";
            }
            textBox1.Text = text;
        }

        public void Test()
        {
            TestCase test = new TestCase();
            string text = "";
            if (test.TestBoth())
            {
                text += "\r\nSedi pocet prvkov.";
            }
            else
            {
                text += "\r\nNesedi pocet prvkov.";
            }
            textBox1.Text = text;

            List<Parcel> list = new List<Parcel>();
            list = test.Tree.Find(0, 0, 10000, 10000);
            text += test.Tree.GetNumberOfItemsInTree().ToString();
            text += $"\r\n {list.Count} ";
            textBox1.Text = text;
        }
        public void Run()
        {
            GPS gps1 = new GPS('N', 'W', 26d, 26d);
            GPS gps2 = new GPS('N', 'W', 49d, 49d);
            GPS gps3 = new GPS('N', 'W', 26d, 26d);
            GPS gps4 = new GPS('N', 'W', 30d, 30d);
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
            tree.Delete(p3);
            List<Parcel> list = new List<Parcel>();
            list = tree.Find(0, 0, 100, 100);
            string text = "";
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