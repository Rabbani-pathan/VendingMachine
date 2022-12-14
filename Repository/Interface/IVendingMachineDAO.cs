using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Interface;

namespace Repository.Interface
{
    interface IVendingMachineDAO
    {
        float buy(string products, float overallmoney);

        float coinvalue(string products);
    }
}
