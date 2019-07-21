using System;
using System.Collections.Generic;
using System.Text;
using DDNS.DataModel.PurchaseCenter;
using DDNS.Entity.PurchaseCenter;
using DDNS.Interface.PurchaseCenter;
using System.Threading.Tasks;

namespace DDNS.Provider.PurchaseCenter
{
    public class Purchase01Provider: IPurchase01
    {
        public readonly Purchase01DataModel _data;
        public Purchase01Provider(Purchase01DataModel data)
        {
            _data = data;
        }

        public Task<bool> AddPurchase01s(List<Purchase01Entity> purchase01Entities)
        {
            return _data.AddPurchase01s(purchase01Entities);
        }

        public Task<bool> DelPurchase01(int ID)
        {
            return _data.DelPurchase01(ID);
        }

        public Task<bool> UpdatePurchase01(Purchase01Entity purchase01Entity)
        {
            return _data.UpdatePurchase01(purchase01Entity);
        }

        public Task<Purchase01Entity> Purchase01(int id)
        {
            return _data.Purchase01(id);
        }

        public Task<IEnumerable<Purchase01Entity>> Purchase01List()
        {
            return _data.Purchase01List();
        }
    }
}
