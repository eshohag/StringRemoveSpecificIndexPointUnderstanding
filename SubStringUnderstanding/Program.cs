using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRemoveUnderstanding
{
    class Program
    {
        static void Main(string[] args)
        {
            string valueOfTest = "19260001";
            int originalBabyId = Convert.ToInt32(valueOfTest.Remove(0,4));
            Console.WriteLine(originalBabyId);
            Console.ReadKey();
        }
    }
}
