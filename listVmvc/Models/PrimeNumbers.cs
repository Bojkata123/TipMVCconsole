using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace listVmvc.Models
{
    public class PrimeNumbers
    {
        private List<int> listPrimeNumbers;

        public List<int> ListallNumbers
        {
            get { return listallNumbers; }
            set { listallNumbers = value; }
        }

        private List<int> listallNumbers;

        public List<int> ListPrimeNumbers
        {
            get { return listallNumbers; }
            set { listallNumbers = value; }
        }

        public PrimeNumbers(List<int> listallNumbers)
        {
            this.listallNumbers = listallNumbers;
        }
        public PrimeNumbers() : this(new List<int>()) { }

        private bool IsPrime(int number)
        {
            bool result = true;

            for (int delitel = 2; delitel < number ; delitel++)
            {
                if (number % delitel ==  0) // se deli
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        public List<int> OnlyPrimeNumber(List<int> numbers)
        {
            List<int> resultPrimeNumbers = new List<int>();
            foreach (int item in numbers)
            {
                if (IsPrime(item))
                {
                    resultPrimeNumbers.Add(item);
                }
            }
            return resultPrimeNumbers;
        }
    }
}
