using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity.PurchaseCenter;
using System.Threading.Tasks;


namespace DDNS.Interface.PurchaseCenter
{
    public interface IPurchase01
    {
        Task<bool> AddPurchase01s(List<Purchase01Entity> purchase01Entities);
        Task<bool> DelPurchase01(int id);
        Task<bool> UpdatePurchase01(Purchase01Entity purchase01Entity);
        Task<Purchase01Entity> Purchase01(int id);
        Task<IEnumerable<Purchase01Entity>> Purchase01List();
    }
}
