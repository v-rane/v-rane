using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace BankAccountsManage
{
    public class Program
    {
        /*
         * @className - Program
         * @objective - for orcastation of program by calling several methods 
         */
        static void Main(string[] args)
        {

            string filePath = "C:\\Users\\VarshaRane\\Desktop\\accountResult.csv";
            //creating object of accountData and passing values in it
            AccountData accountData1 = new AccountData(101, "Raj", 1000, 8, 4);
            AccountData accountData2 = new AccountData(102, "Ram", 15000, 7, 4);
            AccountData accountData3 = new AccountData(103, "Raj", 2500, 10, 8);
            AccountData accountData4 = new AccountData(104, "Varsha", 1200, 8, 12);
            AccountData accountData5 = new AccountData(105, "Ravi", 1100, 7, 10);
            AccountData accountData6 = new AccountData(106, "Ram", 20000, 6, 6);
            AccountData accountData7 = new AccountData(107, "Ram", 90000, 7, 8);
            AccountData accountData8 = new AccountData(108, "Jeson", 6000, 8, 3);
            AccountData accountData9 = new AccountData(109, "Harsha", 12000, 5, 9);
            AccountData accountData10 = new AccountData(110, "Faran", 1500, 8, 8);
            //adding values in list after creating list of accountData
            List<AccountData> list = new List<AccountData>();
            list.Add(accountData1);
            list.Add(accountData2);
            list.Add(accountData3);   
            list.Add(accountData4);
            list.Add(accountData5);
            list.Add(accountData6);
            list.Add(accountData7);
            list.Add(accountData8);
            list.Add(accountData9);
            list.Add(accountData10);

            //calling method of ImplcalculationOnAcc by creating object of it
            ImplCalculationsOnAccData implCalculationsOnAcc = new ImplCalculationsOnAccData();
            CalculatedData calculatedData = new CalculatedData();   
            Dictionary<int, CalculatedData> resultMap = implCalculationsOnAcc.getTotalAmount(list);


            writeSourceFile wsf = new writeSourceFile();
           if( wsf.writeOnSourceFile(resultMap, filePath))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

                
        }
    }
}
