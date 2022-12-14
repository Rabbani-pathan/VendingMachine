using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace VendingMachine
{
    public class Program
    {

        static void Main(string[] args)
        {
            VendingMachineIMPL vmi = new VendingMachineIMPL();

            float overallmoney = 0;

        Reenter:

            Console.WriteLine("selet the coin you want to enter");

            Console.WriteLine("Enter 'nickels' || 'dimes' || 'quarters'");

            string cointype = Console.ReadLine().ToLower();

            Console.WriteLine("you have selected" + " "+ cointype);

            List<string> validCoinTypes = new() {
            Coinsname.nickels.ToString(),
            Coinsname.quarters.ToString(),
            Coinsname.dimes.ToString()
            };


            if (!validCoinTypes.Contains(cointype))

            {
                try
                {
                    throw new Exception("you have to enter valid coin");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    goto Reenter;
                }
            }


            float money = vmi.coinvalue(cointype);

            Console.WriteLine(money);

            overallmoney += money;

            Console.WriteLine("Your current amount is" + "  " + overallmoney);

        Repurchase:

            Console.WriteLine("Do you want to purchase product");
            Console.WriteLine("Type YES or NO");

            string openion = Console.ReadLine().ToUpper();

            if (openion.Trim()== "YES")
            {
                Console.WriteLine("Please Select from the list of Products");

                Console.WriteLine("Enter 'CO' for cola");
                Console.WriteLine("Enter 'CH' for chips");
                Console.WriteLine("Enter 'CA' for candy");

                string product = Console.ReadLine().ToUpper();

                //Product product1= new Product();

                //product.

                float finalamount = vmi.buy(product, overallmoney);

                if (finalamount == 0)
                {
                    Console.WriteLine("Please insert Coins");

                    goto Reenter;
                }

                else
                {
                    Console.WriteLine("Your available balance is "+ " " + finalamount);

                    Console.WriteLine("Add More Money ? type : YES or NO");

                    overallmoney= finalamount;

                    string reopenion = Console.ReadLine().ToUpper();

                    if (reopenion.Trim()== "YES")
                    {

                        goto Reenter;


                    }

                    else
                    {
                        goto Repurchase;
                    }



                }

            }

            else
            {
                Console.WriteLine("Add More Money ? type : YES or NO");

                string reopenion = Console.ReadLine().ToUpper();

                if (reopenion.Trim()== "YES")
                {
                    Console.WriteLine("selet the coin you want to enter");


                    goto Reenter;


                }

                else if (reopenion.Trim()== "NO")
                {

                    goto Repurchase;


                }
            }


        }
    }
}
