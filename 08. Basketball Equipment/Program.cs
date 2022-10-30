using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
         // input
         int priceForWholeYear = int.Parse(Console.ReadLine());

            // calculate
            double shosePrice = priceForWholeYear - (priceForWholeYear * 0.4);
            double jerseyPrice = shosePrice - (shosePrice * 0.2);
            double ballPrice = jerseyPrice / 4.0;
            double accesoriesPrice = ballPrice / 5.0;

         // output
         Console.WriteLine(shosePrice + jerseyPrice + ballPrice + accesoriesPrice + priceForWholeYear); 
        }
    }
}
