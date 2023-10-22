using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string ad;
            Console.Write("İsminizi yazın ");
            ad = Console.ReadLine();
            Console.WriteLine("Adınız : " + ad );



            Console.Write("Bir sayı giriniz : ");
            int x; 
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("girilen sayının karesi = " + x * x);
            Console.Read();
        }
    }
}
