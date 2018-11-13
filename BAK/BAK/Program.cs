using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAK
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Number = new Chislo();
            var Prover = new Proverka();
            int number;
            int[] nums = Number.Chislo1();
            Console.Write("Введите число: ");
            number = Convert.ToInt32(Console.ReadLine());
            Prover.Proverka1(number, nums);
            Console.ReadKey();
        }
    }
}
