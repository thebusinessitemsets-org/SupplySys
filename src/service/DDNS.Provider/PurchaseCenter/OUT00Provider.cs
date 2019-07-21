using System;
using System.Collections.Generic;
using System.Text;
using DDNS.DataModel.PurchaseCenter;
using DDNS.Entity.PurchaseCenter;
using DDNS.Interface.PurchaseCenter;
using System.Threading.Tasks;

namespace DDNS.Provider.PurchaseCenter
{
    public class OUT00Provider:IOUT00
    {
        public readonly OUT00DataModel _data;
        public OUT00Provider(OUT00DataModel data)
        {
            _data = data;
        }

        public Task<bool> AddOUT00s(List<OUT00Entity> OUT00Entities)
        {
            return _data.AddOUT00s(OUT00Entities);
        }

        public Task<bool> DelOUT00(int ID)
        {
            return _data.DelOUT00(ID);
        }

        public Task<bool> UpdateOUT00(OUT00Entity OUT00Entity)
        {
            return _data.UpdateOUT00(OUT00Entity);
        }

        public Task<OUT00Entity> OUT00(int id)
        {
            return _data.OUT00(id);
        }

        public Task<IEnumerable<OUT00Entity>> OUT00List()
        {
            return _data.OUT00List();
        }
    }
}
