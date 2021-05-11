using System;

namespace ControlWork
{
    public class Auto
    {
        public int price;
        public int NumOfStopping;
        public int PriceOfStopping;
        public int FuelPrice;
        public int ConsumptionPer100Km;
        public int Legth;



        public void CalculateFinalPrice()
        {
            int PriceFor100km = FuelPrice * ConsumptionPer100Km;
            int PriceForStopping = NumOfStopping * PriceOfStopping;
            int FullPrice = PriceFor100km + PriceForStopping;
            Console.WriteLine("Price for Auto:");
            Console.WriteLine($"Full Price for {Legth} = {FullPrice} ");
        }
    }
}