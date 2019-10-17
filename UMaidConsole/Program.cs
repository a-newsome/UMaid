using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace UMaidConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PropertyInfo house = new PropertyInfo();
            house.numBeds = 4;
            house.numBaths = 2;
            house.size = 1200;

            Console.WriteLine("This house has " + house.numBeds + " bedrooms, " + house.numBaths +
                " bathrooms, and is " + house.size + " sq. feet.");

            Console.WriteLine("The average cost is " + PropertyInfo.getAverage(house.priceHeavy) + ".");

            house.priceHeavy.Add(300.00);
            house.priceHeavy.Add(200.00);
            house.priceHeavy.Add(300.00);
            house.priceHeavy.Add(200.00);
            house.priceHeavy.Add(1000.00);

            Console.WriteLine("The average cost is " + PropertyInfo.getAverage(house.priceHeavy) + ".");
        }
    }
}
