using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Interface;

namespace Repository
{
    public class VendingMachineIMPL :IVendingMachineDAO
    {
        public float buy(string product, float overallmoney)
        {
            float remainingamount;

            if (product.Equals("CO"))
            {
                remainingamount =   overallmoney - 50;

                Console.WriteLine("Cola is Dispensed");

                return remainingamount;
            }

            else if (product.Equals("CH"))

            {
                remainingamount =   overallmoney - 40;

                Console.WriteLine("Chips are Dispensed");

                return remainingamount;
            }

            else if (product.Equals("CA"))

            {
                remainingamount =   overallmoney - 20;

                Console.WriteLine("Candy is Dispensed");

                return remainingamount;
            }

            return 0;
        }

        public float coinvalue(string cointype)
        {
            float money;

            if (cointype =="nickels")
            {
                money = 80;
                return money;
            }
            else if (cointype =="dimes")
            {
                money = 40;
                return money;
            }
            else if (cointype =="quarters")
            {
                money = 30;
                return money;
            }
            return 0;
        }
    }
}
