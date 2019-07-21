using System;
using System.Collections.Generic;
using System.Text;
using DDNS.DataModel.DataCenter;
using DDNS.Entity.DataCenter;
using DDNS.Interface.DataCenter;
using System.Threading.Tasks;

namespace DDNS.Provider.DataCenter
{
    public class PRODUCT01Provider:IPRODUCT01
    {
        public readonly PRODUCT01DataModel _data;
        public PRODUCT01Provider(PRODUCT01DataModel data)
        {
            _data = data;
        }

        public Task<bool> AddPRODUCT01s(List<PRODUCT01Entity> pRODUCT01Entities)
        {
            return _data.AddPRODUCT01s(pRODUCT01Entities);
        }

        public Task<bool> DelPRODUCT01(int ID)
        {
            return _data.DelPRODUCT01(ID);
        }

        public Task<bool> UpdatePRODUCT01(PRODUCT01Entity pRODUCT01Entity)
        {
            return _data.UpdatePRODUCT01(pRODUCT01Entity);
        }

        public Task<PRODUCT01Entity> PRODUCT01(int id)
        {
            return _data.PRODUCT01(id);
        }

        public Task<IEnumerable<PRODUCT01Entity>> PRODUCT01List()
        {
            return _data.PRODUCT01List();
        }
    }
}
