using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisi k = new Kisi();
            string ads;
            Console.Write("İsim Girin: ");
            ads = Console.ReadLine();
            string meslek;
            Console.Write("Mesleğinizi Girin: ");
            meslek=Console.ReadLine();
            Console.Write("Yaşınızı Girin: ");
            int yasi=Convert.ToInt32(Console.ReadLine());
            k.kisi(ads, meslek, yasi);
            Console.Read();
        }
    }
}
