using Herkansing_Khadija_oop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herkansing_Khadija_oop.Models
{
    public enum MagnumIce
    {
        MilkChocolate,
        WhiteChockolate,
        BlackChocolate,
        AlpineNuts,
        RomanticStrawberries,
        MilkChockolate,
        BlackChockolate,
    }
    public class Magnum : IEatable
    {
        private MagnumIce _magnumIce { get; set; }

        public Magnum(MagnumIce magnumIce)
        {
            this._magnumIce = magnumIce;
        }

        public void Eat()
        {
            Console.WriteLine($"I am eating a Magnum with {_magnumIce}");
            GetPrice();
        }

        public void GetPrice()
        {
            switch (_magnumIce)
            {
                case MagnumIce.MilkChockolate:
                    PriceList.MilkChockolate();
                    break;

                case MagnumIce.WhiteChockolate:
                    PriceList.WhiteChockolate();
                    break;
                case MagnumIce.BlackChocolate:
                    PriceList.BlackChocoklate();

                    break;
                case MagnumIce.AlpineNuts:
                    PriceList.Alpinenuts();
                    break;
                case MagnumIce.RomanticStrawberries:
                    PriceList.RomanticStrawberries();
                    break;
                default:
                    break;
            }
        }
    }
}
