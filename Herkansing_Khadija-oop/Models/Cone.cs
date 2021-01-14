using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herkansing_Khadija_oop.Interfaces;

namespace Herkansing_Khadija_oop.Models
{
    public enum Flavor
    {
        Strawberry,
        Banana,
        ChocKolate,
        Vanila,
        Mokka,
        Chockolate
    }
    public class Cone : IEatable
    {
        private Flavor _flavor { get; set; }

        public Cone(Flavor flavor)
        {
            this._flavor = flavor;
        }

        public void Eat()
        {
            Console.WriteLine($"I am eating a cone with {_flavor}");
            GetPrice();
        }

        public void GetPrice()
        {
            switch (_flavor)
            {
                case Flavor.Strawberry:
                    PriceList.Strawberry();
                    break;
                case Flavor.Banana:
                    PriceList.Banana();
                    break;
                case Flavor.ChocKolate:

                    PriceList.Chockolate();
                    break;
                //case Flavor.Vanila:
                //    PriceList.Vanila();
                //    break;


                case Flavor.Mokka:
                    PriceList.Mokka();
                    break;
                default:
                    break;
            }
        }
    }
}