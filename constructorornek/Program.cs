using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string blg; 
            Console.Write("Ad - Soyad - Yaş - Meslek = ");
            blg = Console.ReadLine();
            bilgiler kisi = new bilgiler(blg);
            Console.Read();

        }
    }
}
