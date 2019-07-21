using System;
using System.Collections.Generic;
using System.Text;
using DDNS.DataModel.PurchaseCenter;
using DDNS.Entity.PurchaseCenter;
using DDNS.Interface.PurchaseCenter;
using System.Threading.Tasks;

namespace DDNS.Provider.PurchaseCenter
{
    public class IN00Provider:IIN00
    {
        public readonly IN00DataModel _data;
        public IN00Provider(IN00DataModel data)
        {
            _data = data;
        }

        public Task<bool> AddIN00s(List<IN00Entity> iN00Entities)
        {
            return _data.AddIN00s(iN00Entities);
        }

        public Task<bool> DelIN00(int ID)
        {
            return _data.DelIN00(ID);
        }

        public Task<bool> UpdateIN00(IN00Entity iN00Entity)
        {
            return _data.UpdateIN00(iN00Entity);
        }

        public Task<IN00Entity> IN00(int id)
        {
            return _data.IN00(id);
        }

        public Task<IEnumerable<IN00Entity>> IN00List()
        {
            return _data.IN00List();
        }
    }
}
