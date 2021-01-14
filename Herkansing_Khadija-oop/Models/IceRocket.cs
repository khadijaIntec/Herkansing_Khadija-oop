using Herkansing_Khadija_oop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herkansing_Khadija_oop.Models
{
    public class IceRocket : IEatable
    {
        public void Eat()
        {
            Console.WriteLine("I'am Eating an Ice Rocket ");
            GetPrice();
        }

        public void GetPrice()
        {
            Console.WriteLine("The price for a Ice Rocket is 2.01");
        }
       
        }
}

