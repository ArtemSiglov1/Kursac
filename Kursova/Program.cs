using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Voditeli voditeli = new Voditeli(23, new FullName("", "Артем", null), 8, 2, 1, 12);
                Console.WriteLine(voditeli.ToString());
            }
            catch {}
            Console.Read();
        }
    }
}
