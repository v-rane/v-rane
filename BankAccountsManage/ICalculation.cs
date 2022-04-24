using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsManage
{
    public interface ICalculation
    {
        /*
         * @className - BankAccountsManage
         * @objective -interface created and getTotalAmount method is declared 
         */
        Dictionary<int, List<CalculatedData>> getTotalAmount(List<AccountData> list);

    }
}
