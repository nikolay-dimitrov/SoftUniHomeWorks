using Problem2BankOfKurtovoKonare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2BankOfKurtovoKonare.Interface
{
    interface IAccount
    {
        Customer Customer { get; set; }

        decimal Balance { get; set; }

        decimal InterestRate { get; set; }

        void DepositMoney(decimal money);

        decimal CalculateInterest(int months);
    }
}
