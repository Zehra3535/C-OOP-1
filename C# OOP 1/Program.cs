using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ogrenci referance1 = new Ogrenci();
             referance1.name = "Sam Smith";
            referance1.age = 15;
           
            referance1.print();
            referance1.EnterData(10, 23);

            referance1.Method3(513,4);

            Console.ReadKey();
        }
    }
}
