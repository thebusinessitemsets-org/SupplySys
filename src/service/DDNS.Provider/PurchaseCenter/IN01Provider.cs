using System;
using System.Collections.Generic;
using System.Text;
using DDNS.DataModel.PurchaseCenter;
using DDNS.Entity.PurchaseCenter;
using DDNS.Interface.PurchaseCenter;
using System.Threading.Tasks;

namespace DDNS.Provider.PurchaseCenter
{
    public class IN01Provider:IIN01
    {
        public readonly IN01DataModel _data;
        public IN01Provider(IN01DataModel data)
        {
            _data = data;
        }

        public Task<bool> AddIN01s(List<IN01Entity> iN01Entities)
        {
            return _data.AddIN01s(iN01Entities);
        }

        public Task<bool> DelIN01(int ID)
        {
            return _data.DelIN01(ID);
        }

        public Task<bool> UpdateIN01(IN01Entity iN01Entity)
        {
            return _data.UpdateIN01(iN01Entity);
        }

        public Task<IN01Entity> IN01(int id)
        {
            return _data.IN01(id);
        }

        public Task<IEnumerable<IN01Entity>> IN01List()
        {
            return _data.IN01List();
        }
    }
}
