using System;
using System.Collections.Generic;
using System.Text;
using DDNS.DataModel.PurchaseCenter;
using DDNS.Entity.PurchaseCenter;
using DDNS.Interface.PurchaseCenter;
using System.Threading.Tasks;

namespace DDNS.Provider.PurchaseCenter
{
    public class OUT_BACK01Provider : IOUT_BACK01
    {
        public readonly OUT_BACK01DataModel _data;
        public OUT_BACK01Provider(OUT_BACK01DataModel data)
        {
            _data = data;
        }

        public Task<bool> AddOUT_BACK01s(List<OUT_BACK01Entity> oUT_BACK01Entities)
        {
            return _data.AddOUT_BACK01s(oUT_BACK01Entities);
        }

        public Task<bool> DelOUT_BACK01(int ID)
        {
            return _data.DelOUT_BACK01(ID);
        }

        public Task<bool> UpdateOUT_BACK01(OUT_BACK01Entity oUT_BACK01Entity)
        {
            return _data.UpdateOUT_BACK01(oUT_BACK01Entity);
        }

        public Task<OUT_BACK01Entity> OUT_BACK01(int id)
        {
            return _data.OUT_BACK01(id);
        }

        public Task<IEnumerable<OUT_BACK01Entity>> OUT_BACK01List()
        {
            return _data.OUT_BACK01List();
        }
    }
}
