using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeBattle
{
    public class Pole1
    {
        public string[,] pole1()
        {
            string[,] pole11 = new string[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    pole11[i, j] = "+";
                    Console.Write(pole11[i,j]);
                }
                Console.WriteLine();
            }
            return pole11;
        }
    }
}
