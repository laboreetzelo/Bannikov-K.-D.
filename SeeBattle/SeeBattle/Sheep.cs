using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeBattle
{
    public class Sheep
    {
        public string sheep(string[,] pole22)
        {
            Console.Write("Введите координаты кормы");
            int cif1;
            cif1 = Convert.ToInt32(Console.ReadLine());
            int cif11;
            cif11 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координаты носа");
            int cif2;
            cif2 = Convert.ToInt32(Console.ReadLine());
            int cif22;
            cif22 = Convert.ToInt32(Console.ReadLine());
                  if (cif1 - cif2!=0) // вертикаль
                  {
                    pole22[cif1, cif11] = "|";
                  }
                  if (cif1 - cif2 == 0) // горизонталь
                    {
                        pole22[cif1, cif11] = "-";
                    }
            return sheep(pole22);
        }
    }
}
