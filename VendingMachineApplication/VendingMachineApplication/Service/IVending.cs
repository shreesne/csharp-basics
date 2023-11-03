using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineApplication.Model;

namespace VendingMachineApplication.Service
{
    public interface IVending
    {

        Product Purchase(string productId);
        List<string> ShowAll();
       void InsertMoney(int denomination);
       Dictionary<TKey, TValue> EndTransactions<TKey, TValue>(Dictionary<TKey, TValue> dict1, Dictionary<TKey, TValue> dict2, bool overwriteExistingKeys = true);
    }
}
