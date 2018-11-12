using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeBattle
{
    public class Game
    {
        static void Main(string[] args)
        {
            var Polee1 = new Pole1();
            var Polee2 = new Pole2();
            Polee1.pole1();
            Console.WriteLine();
            Console.WriteLine();
            Polee2.pole2();
            Console.ReadKey();
        }
    }
}
