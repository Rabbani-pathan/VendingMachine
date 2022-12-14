using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace VendingMachine
{
    public class VendingmachineImpl 
    {
        public float buy (string product,float overallmoney)
        {
            float remainingamount;

            if(product.Equals("CO"))
           {
                remainingamount =   overallmoney - 10;

                Console.WriteLine("Cola is Dispensed");

                return remainingamount;
            }

            else if (product.Equals("CH"))

            {
                remainingamount =   overallmoney - 10;

                Console.WriteLine("Chips are Dispensed");

                return remainingamount;
            }

            else if (product.Equals("CA"))

            {
                remainingamount =   overallmoney - 10;

                Console.WriteLine("Candy is Dispensed");

                return remainingamount;
            }

            return 0;
        }

        public float coinvalue(string  cointype)
        {
            float money;

           if(cointype =="nickel")
            {
                money = 20;
                return money;
            }
            else if (cointype =="dimes")
            {
                money = 10;
                return money;
            }
            else if (cointype =="quarters")
            {
                money = 10;
                return money;
            }
            return 0;
        }
    }
}
