using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAK
{
    public class Chislo
    {
        public int[] Chislo1()
        {
            int[] nums = new int[4];
            Random chislo = new Random();
            nums[0] = chislo.Next(1,9);
            int i = 1;
            while (i<4)
            {
            Go:
                nums[i] = chislo.Next(0, 9);
                for (int j = 0; j<i; j++)
                {
                    if(nums[i] == nums[j])
                     {
                        goto Go;
                     }
                }
                i++;               
            }
            Console.WriteLine();
            return nums;
        }
    }
}
