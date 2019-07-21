using System;
using System.Collections.Generic;
using System.Text;
using DDNS.DataModel.PurchaseCenter;
using DDNS.Entity.PurchaseCenter;
using DDNS.Interface.PurchaseCenter;
using System.Threading.Tasks;

namespace DDNS.Provider.PurchaseCenter
{
    public class Purchase00Provider:IPurchase00
    {
        public readonly Purchase00DataModel _data;
        public Purchase00Provider(Purchase00DataModel data)
        {
            _data = data;
        }

        public Task<bool> AddPurchase00s(List<Purchase00Entity> purchase00Entities)
        {
            return _data.AddPurchase00s(purchase00Entities);
        }

        public Task<bool> DelPurchase00(int ID)
        {
            return _data.DelPurchase00(ID);
        }

        public Task<bool> UpdatePurchase00(Purchase00Entity purchase00Entity)
        {
            return _data.UpdatePurchase00(purchase00Entity);
        }

        public Task<Purchase00Entity> Purchase00(int id)
        {
            return _data.Purchase00(id);
        }

        public Task<IEnumerable<Purchase00Entity>> Purchase00List()
        {
            return _data.Purchase00List();
        }
    }
}
