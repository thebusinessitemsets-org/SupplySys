using System;
using System.Collections.Generic;
using System.Text;
using DDNS.DataModel.PurchaseCenter;
using DDNS.Entity.PurchaseCenter;
using DDNS.Interface.PurchaseCenter;
using System.Threading.Tasks;

namespace DDNS.Provider.PurchaseCenter
{
    public class OUT01Provider:IOUT01
    {
        public readonly OUT01DataModel _data;
        public OUT01Provider(OUT01DataModel data)
        {
            _data = data;
        }

        public Task<bool> AddOUT01s(List<OUT01Entity> oUT01Entities)
        {
            return _data.AddOUT01s(oUT01Entities);
        }

        public Task<bool> DelOUT01(int ID)
        {
            return _data.DelOUT01(ID);
        }

        public Task<bool> UpdateOUT01(OUT01Entity oUT01Entity)
        {
            return _data.UpdateOUT01(oUT01Entity);
        }

        public Task<OUT01Entity> OUT01(int id)
        {
            return _data.OUT01(id);
        }

        public Task<IEnumerable<OUT01Entity>> OUT01List()
        {
            return _data.OUT01List();
        }
    }
}
