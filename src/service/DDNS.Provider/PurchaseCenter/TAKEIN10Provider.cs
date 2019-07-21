using System;
using System.Collections.Generic;
using System.Text;
using DDNS.DataModel.PurchaseCenter;
using DDNS.Entity.PurchaseCenter;
using DDNS.Interface.PurchaseCenter;
using System.Threading.Tasks;

namespace DDNS.Provider.PurchaseCenter
{
    public class TAKEIN10Provider:ITAKEIN10
    {
        public readonly TAKEIN10DataModel _data;
        public TAKEIN10Provider(TAKEIN10DataModel data)
        {
            _data = data;
        }

        public Task<bool> AddTAKEIN10s(List<TAKEIN10Entity> tAKEIN10Entities)
        {
            return _data.AddTAKEIN10s(tAKEIN10Entities);
        }

        public Task<bool> DelTAKEIN10(int ID)
        {
            return _data.DelTAKEIN10(ID);
        }

        public Task<bool> UpdateTAKEIN10(TAKEIN10Entity tAKEIN10Entity)
        {
            return _data.UpdateTAKEIN10(tAKEIN10Entity);
        }

        public Task<TAKEIN10Entity> TAKEIN10(int id)
        {
            return _data.TAKEIN10(id);
        }

        public Task<IEnumerable<TAKEIN10Entity>> TAKEIN10List()
        {
            return _data.TAKEIN10List();
        }
    }
}
