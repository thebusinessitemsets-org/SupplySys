using System;
using System.Collections.Generic;
using System.Text;
using DDNS.DataModel.PurchaseCenter;
using DDNS.Entity.PurchaseCenter;
using DDNS.Interface.PurchaseCenter;
using System.Threading.Tasks;

namespace DDNS.Provider.PurchaseCenter
{
    public class OUT_BACK00Provider : IOUT_BACK00
    {
        public readonly OUT_BACK00DataModel _data;
        public OUT_BACK00Provider(OUT_BACK00DataModel data)
        {
            _data = data;
        }

        public Task<bool> AddOUT_BACK00s(List<OUT_BACK00Entity> oUT_BACK00Entities)
        {
            return _data.AddOUT_BACK00s(oUT_BACK00Entities);
        }

        public Task<bool> DelOUT_BACK00(int ID)
        {
            return _data.DelOUT_BACK00(ID);
        }

        public Task<bool> UpdateOUT_BACK00(OUT_BACK00Entity oUT_BACK00Entity)
        {
            return _data.UpdateOUT_BACK00(oUT_BACK00Entity);
        }

        public Task<OUT_BACK00Entity> OUT_BACK00(int id)
        {
            return _data.OUT_BACK00(id);
        }

        public Task<IEnumerable<OUT_BACK00Entity>> OUT_BACK00List()
        {
            return _data.OUT_BACK00List();
        }
    }
}
