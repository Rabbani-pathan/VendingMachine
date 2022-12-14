using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    interface VendingmachineDAO
    {
       

        float buy(string products, float overallmoney);

        float coinvalue(string products);


    }
}
