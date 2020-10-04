using System;
namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inv;
            Ball ball1 = new Ball("кожа", 2018, "Популярный бренд",5, 228  );
            Basketball_Ball ball2 = new Basketball_Ball("синтетика", 2009, "Бренд", 16, 1342);
            Console.WriteLine(ball1.ToString());
            Iusing ball3 = new Ball("жареные гвозди", 2999, "Nokia", 1, 99999);
            Console.WriteLine(ball3.ToString());
            Console.WriteLine("Использование AS:");
            inv = ball1 as Inventory;
            Console.WriteLine(inv.ToString());
            Tennis ten1 = new Tennis(1, 2223, 2, "зелёный");
            Console.WriteLine(ten1.ToString());
            Iusing bar1 = new Bars(2, 3213, 2, 3);
            Console.WriteLine(bar1.ToString());
            Mats mat1 = new Mats(5, 1531, "Квадрат", 2);
            Console.WriteLine(mat1.ToString());
            Iusing ben1 = new Bench(4, 214, 4);
            Console.WriteLine(ben1.ToString());
            ball1.Use();
            ball2.Use();
            ball3.Use();
            inv.Use();
            ten1.Use();
            bar1.Use();
            mat1.Use();
            ben1.Use();
            Iusing[] array = { ball3, bar1, ben1 };
            Printer printer = new Printer();
            for (int i = 0; i < array.Length; i++)
            {
                printer.iAmPrinting(array[i]);
            }
            Console.ReadLine();
        }
    }
}
