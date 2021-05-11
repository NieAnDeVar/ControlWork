using System;

namespace ControlWork
{
    public class Auto: Transport
    {
        public int FuelTax;
        protected override void CalculateTax()
        {
            FullPrice -= FuelTax;
        }
    }
}