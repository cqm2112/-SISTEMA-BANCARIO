using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.Model
{
    interface ISavingAccount
    {
        decimal Opening(decimal openingAmount);
        decimal Deposit(decimal depositMoney);
        decimal Retreats(decimal retreatsMoney);
        decimal CheckBalance();
    }
}
