using System.Collections.Generic;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            isimler.Add("Kerem");
            Console.WriteLine(isimler.Count);
            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }

}