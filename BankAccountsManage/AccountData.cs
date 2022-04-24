using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsManage
{
    public class AccountData
    {
        /*
         * @className -AccountData
         * @objective - getter setter for AccountData
         */
        public int AccountId { get; set; }
        public string AccountHolderName { get; set; }
        public int Amount { get; set; }
        public int Intrest { get; set; }
        public int Month { get; set; }

        //ctor for AccountData
        public AccountData(int aId,string accName, int amount,int intrest,int month)
        {
            AccountId = aId;
            AccountHolderName = accName;    
            Amount = amount;
            Intrest = intrest;
            Month = month;

        }

    }
}
