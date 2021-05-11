using System;

namespace ControlWork
{
    public class Airplane
    {
        public int price;
        public int NumOfStopping;
        public int PriceOfStopping;
        public int FuelPrice;
        public int ConsumptionPer100Km;
        public int PriceForRent;
        public int Tax;
        public int TaxMultiplier;
        public int Legth;
        
        public void CalculateFinalPrice()
        {
            int PriceFor100km = FuelPrice * ConsumptionPer100Km;
            int PriceForStopping = NumOfStopping * PriceOfStopping;
            int FullTax = Tax * TaxMultiplier;
            int FullPrice = PriceFor100km + PriceForStopping + PriceForRent - FullTax;
            Console.WriteLine("Price for Airplane:");
            Console.WriteLine($"Full Price for {Legth} = {FullPrice} ");
        }
    }
}