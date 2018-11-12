using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAK
{
    public class Proverka
    {
        public string Proverka1(int number, int[] nums)
        {
            int cows = 0, bulls = 0, k=0;
            int[] Prover = new int[4];
            for (int i = 3; i > -1; i--)
            {
                Prover[i] = number % 10;
                number = number / 10;
                for (int j = 0; j < 4; j++)
                {
                    if ((Prover[i] == nums[j]) && (i == j))
                    {
                        bulls++;
                        k++;
                    }
                    if ((Prover[i] == nums[j]) && (i != j))
                    {
                        cows++;
                    }
                }
            }
            return ($"{bulls} Быков, {cows} Коров");
        }
    }
}
