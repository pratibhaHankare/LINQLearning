using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPratice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sampleList = new List<int>() { 1,2,3,4,5,6,7,8,9,10,11,12};
            var methodSyn = sampleList.Where(varibleList => varibleList > 2);
            foreach (var item in methodSyn)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Max Value:");
            var mixedSyn = (from varList in sampleList
                            select varList).Max();
            Console.WriteLine(mixedSyn);
            
            Console.ReadLine();
        }
    }
}
