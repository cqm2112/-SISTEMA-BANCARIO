using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.Model
{
    public class SavingAccount : ISavingAccount
    {
        private int IdAccount { get; set; }
        public decimal Balance { get; set; }

        public decimal Opening(decimal OpeningAmount)
        {
            Balance = OpeningAmount;
            Random random = new Random();
            var idAccount = random.Next(10000000, 999999999).ToString("D6");
            return Convert.ToInt64(idAccount);
        }

        public decimal Deposit(decimal depositMoney)
        {
            Balance += depositMoney;
            return Balance;
        }

        public virtual decimal Retreats(decimal retreatsMoney)
        {
            Balance -= retreatsMoney;
            return Balance;
        }

        public decimal CheckBalance()
        {
            return Balance;
        }
    }
}
