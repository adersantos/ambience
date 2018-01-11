using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambience
{
    class Program
    {
        static void Main(string[] args)
        {
            var uteis = new Uteis();
            Console.WriteLine(uteis.NumerosPrimos(5));
            Console.ReadKey();
        }
    }
}
