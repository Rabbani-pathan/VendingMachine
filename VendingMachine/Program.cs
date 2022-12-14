using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VendingMachine
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            VendingmachineImpl vmi = new VendingmachineImpl();

            float overallmoney = 0;

        Reenter:

            Console.WriteLine("selet the coin you want to enter");

            Console.WriteLine("Enter 'nickel' || 'dimes' || 'quarters'");

            string cointype = Console.ReadLine();

            Console.WriteLine("you have selected" + " "+ cointype);


            float money = vmi.coinvalue(cointype);

            Console.WriteLine(money);

            overallmoney += money;

            Console.WriteLine("Your current amount is" + "  " + overallmoney);

        Repurchase:

            Console.WriteLine("Do you want to purchase product");
            Console.WriteLine("Type YES or NO");

            string openion = Console.ReadLine();

            if (openion.Trim()== "YES")
            {
                Console.WriteLine("Please Select from the list of Products");

                Console.WriteLine("Enter 'CO' for cola");
                Console.WriteLine("Enter 'CH' for chips");
                Console.WriteLine("Enter 'CA' for candy");

                string product = Console.ReadLine();


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

                    string reopenion = Console.ReadLine();

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

                string reopenion = Console.ReadLine();

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
