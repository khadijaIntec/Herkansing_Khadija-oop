using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herkansing_Khadija_oop.Models;


namespace Herkansing_Khadija_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            IceRocket ice = new IceRocket();
            ice.Eat();
            Console.WriteLine("************************");
            Magnum magnum = new Magnum(MagnumIce.MilkChocolate);
            magnum.Eat();

            Console.WriteLine("************************");

            Cone cone = new Cone(Flavor.Banana);
            cone.Eat();
            Console.ReadKey();

            Console.WriteLine("***************************");

            Magnum magnum1 = new Magnum(MagnumIce.RomanticStrawberries);
            magnum.Eat();


            Cone cone1 = new Cone(Flavor.Mokka);
            cone1.Eat();
        }
    }
}
