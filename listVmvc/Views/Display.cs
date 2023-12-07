using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listVmvc.View
{
    public class Display
    {
        public List<int> ListAllNumbers { get; set; }
        public List<int> ListPrimeNumbers { get; set; }

        public void Input()
        {
            Console.WriteLine("Vuvedete spisuk ot chisla na 1 red s interval: ");
            ListAllNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        }

        public void Output()
        {
            Console.WriteLine(string.Join(" ",ListPrimeNumbers));
        }
    }
}
