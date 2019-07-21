using System;
using System.Collections.Generic;
using System.Text;
using DDNS.DataModel.PurchaseCenter;
using DDNS.Entity.PurchaseCenter;
using DDNS.Interface.PurchaseCenter;
using System.Threading.Tasks;

namespace DDNS.Provider.PurchaseCenter
{
    public class TAKEIN11Provider:ITAKEIN11
    {
        public readonly TAKEIN11DataModel _data;
        public TAKEIN11Provider(TAKEIN11DataModel data)
        {
            _data = data;
        }

        public Task<bool> AddTAKEIN11s(List<TAKEIN11Entity> tAKEIN11Entities)
        {
            return _data.AddTAKEIN11s(tAKEIN11Entities);
        }

        public Task<bool> DelTAKEIN11(int ID)
        {
            return _data.DelTAKEIN11(ID);
        }

        public Task<bool> UpdateTAKEIN11(TAKEIN11Entity tAKEIN11Entity)
        {
            return _data.UpdateTAKEIN11(tAKEIN11Entity);
        }

        public Task<TAKEIN11Entity> TAKEIN11(int id)
        {
            return _data.TAKEIN11(id);
        }

        public Task<IEnumerable<TAKEIN11Entity>> TAKEIN11List()
        {
            return _data.TAKEIN11List();
        }
    }
}
