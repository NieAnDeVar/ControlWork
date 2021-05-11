using System;

namespace ControlWork
{
    public class Airplane : Transport
    {
        
        public int Tax;
        public int TaxMultiplier;

        protected override void CalculateTax()
        {
            FullPrice -= (Tax * TaxMultiplier);
        }
    }
}