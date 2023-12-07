using listVmvc.Models;
using listVmvc.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listVmvc.Controllers
{
    public class PrimeNumbersController
    {
        Display display = new Display();
        PrimeNumbers model = new PrimeNumbers();

        public PrimeNumbersController()
        {
            display.Input();

            display.ListPrimeNumbers = model.OnlyPrimeNumber(display.ListAllNumbers);


            display.Output();
        }



    }
}
