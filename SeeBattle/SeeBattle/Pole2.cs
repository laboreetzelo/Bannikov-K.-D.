using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeBattle
{
    public class Pole2
    {
        public string[,] pole2()
        {
            string[,] pole22 = new string[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    pole22[i, j] = "+";
                    Console.Write(pole22[i, j]);
                }
                Console.WriteLine();
            }
            return pole22;
        }
    }
}
