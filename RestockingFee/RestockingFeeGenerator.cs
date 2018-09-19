using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestockingFee
{
    public class RestockingFeeCalculator
    {
        public static double TenPercent(double itemPrice)
        {
            itemPrice *= 0.9f;
            itemPrice *= 100;
            itemPrice += 0.1f; //adds 0.1 cents for rounding errors with doubles
            itemPrice = Math.Round(itemPrice);
            itemPrice /= 100;
            return itemPrice;
        }
    }
}
