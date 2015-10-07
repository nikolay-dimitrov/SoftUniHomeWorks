using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string holderfirstName;
            string holdermiddleName;
            string holderlastName;
            decimal balance;
            string currency;
            string bankName;
            string iBAN;
            long creditCard1;
            long creditCard2;
            long creditCard3;
            holderfirstName = "Dimitur";
            holdermiddleName = "Georgiev";
            holderlastName = "Dimitrov";
            balance = 7320;
            currency = "Euro";
            bankName = "OBBBank";
            iBAN = "BG85STSA12345678912345";
            creditCard1 = 2648869522650124;
            creditCard2 = 2648869545839017;
            creditCard3 = 2648869534567833;
            Console.WriteLine("{0} {1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}\n{9}", holderfirstName, holdermiddleName ,holderlastName, balance, currency, bankName, iBAN, creditCard1, creditCard2, creditCard3);


        }

        
    }
}
