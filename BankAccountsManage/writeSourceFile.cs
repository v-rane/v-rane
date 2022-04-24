using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccountsManage
{
    public class writeSourceFile
    {
        public bool writeOnSourceFile(Dictionary<int,List<CalculatedData>> writedic,string filePath)
        {
            bool checkFileStatus = false;
            StreamWriter sw = new StreamWriter(filePath);
            foreach (var data in writedic)
            {
                foreach(CalculatedData key in data.Value)
                {
                    string line = key.AccountId +"," + key.AccountHolderName +","+ key.TotalAmmount;
                    sw.WriteLine(line);
                    checkFileStatus = true;
                }
            }
            return checkFileStatus;

        }
    }
}
