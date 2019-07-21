using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity.PurchaseCenter;
using System.Threading.Tasks;

namespace DDNS.Interface.PurchaseCenter
{
    public interface IPurchase00
    {
        Task<bool> AddPurchase00s(List<Purchase00Entity> purchase00Entities);
        Task<bool> DelPurchase00(int id);
        Task<bool> UpdatePurchase00(Purchase00Entity purchase00Entity);
        Task<Purchase00Entity> Purchase00(int id);
        Task<IEnumerable<Purchase00Entity>> Purchase00List();
    }
}
