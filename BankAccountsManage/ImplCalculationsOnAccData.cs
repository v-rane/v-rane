using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsManage
{
    public class ImplCalculationsOnAccData : ICalculation
    {
        /*
         * @className -BankAccountsManage
         * @objective - to implement methods declared in interface for calculation on accountData purpose
         * @Date - 24-4-2022
         * @auther name - Varsha Rane
         */


        public Dictionary<int, List<CalculatedData>> getTotalAmount(List<AccountData> accountList)
        {
            /*
             * @MethodName - getTotalAmount
             * @objective - to calculate totall sum of all accounts of user 
             * @para - List<AccountData>
             * @return -Dictionary<int, List<CalculatedData>>
             */

            Dictionary<int, List<CalculatedData>> totalAmountdic = new Dictionary<int,List<CalculatedData>>();
            //dic is created with id as key and List<calculatedData as value 
            //variables are declared for assigning values after calculating intrest and amount
            int simpleIntrest = 0;
            int totalAmmount = 0;
            //accountList is iterated for calculating intrest and amount
            foreach (AccountData account in accountList)
            {
                simpleIntrest = (account.Amount * account.Intrest * account.Month) / 100;
                totalAmmount = simpleIntrest + account.Amount;
            }
            //accountList is iterated and values are assigned in calculated data after creating object of Calculated data
            foreach(AccountData account in accountList)
            {
                CalculatedData calculatedData = new CalculatedData();
                calculatedData.AccountId = account.AccountId;
                calculatedData.AccountHolderName = account.AccountHolderName;
                calculatedData.TotalAmmount= totalAmmount;
                //if dic contains accountId then object of calculated data is after assigning values in it is added 
                if(totalAmountdic.ContainsKey(account.AccountId))
                {
                    totalAmountdic[account.AccountId].Add(calculatedData);
                }
                else
                {
                    //if accountId is not there then in dic id is and calculatedData object is added 
                    totalAmountdic.Add(account.AccountId, new List<CalculatedData>());
                    totalAmountdic[account.AccountId].Add(calculatedData);
                }           
            }
            //dic is returned
            return totalAmountdic;
        }
    }
}
