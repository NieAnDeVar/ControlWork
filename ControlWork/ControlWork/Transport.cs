using System;

namespace ControlWork
{
    public abstract class Transport
    {
        public int price;
        public int NumOfStopping;
        public int PriceOfStopping;
        public int FuelPrice;
        public int ConsumptionPer100Km;
        public int Legth;

        public int FullPrice;
        public void CheckFullPrice()
        {
            CalculateFullPrice();
            HookAdditionaTaxes();
            CalculateTax();
            PrintDetails();
            
        }

        protected void CalculateFullPrice()
        {
            int PriceFor100km = FuelPrice * ConsumptionPer100Km;
            int PriceForStopping = NumOfStopping * PriceOfStopping;
            FullPrice = PriceFor100km + PriceForStopping;
        }

        private void PrintDetails()
        {
            Console.WriteLine("Price for Auto:");
            Console.WriteLine($"Full Price for {Legth} = {FullPrice} ");
        }
        protected virtual void HookAdditionaTaxes() { }
        protected abstract void CalculateTax();

        
    }
}