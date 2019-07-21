using System;
using System.Collections.Generic;
using System.Text;
using DDNS.DataModel.DataCenter;
using DDNS.Entity.DataCenter;
using DDNS.Interface.DataCenter;
using System.Threading.Tasks;

namespace DDNS.Provider.DataCenter
{
    public class PRODUCT00Provider:IPRODUCT00
    {
        public readonly PRODUCT00DataModel _data;
        public PRODUCT00Provider(PRODUCT00DataModel data)
        {
            _data = data;
        }

        public Task<bool> AddPRODUCT00s(List<PRODUCT00Entity> pRODUCT00Entities)
        {
            return _data.AddPRODUCT00s(pRODUCT00Entities);
        }

        public Task<bool> DelPRODUCT00(int ID)
        {
            return _data.DelPRODUCT00(ID);
        }

        public Task<bool> UpdatePRODUCT00(PRODUCT00Entity pRODUCT00Entity)
        {
            return _data.UpdatePRODUCT00(pRODUCT00Entity);
        }

        public Task<PRODUCT00Entity> PRODUCT00(int id)
        {
            return _data.PRODUCT00(id);
        }

        public Task<IEnumerable<PRODUCT00Entity>> PRODUCT00List()
        {
            return _data.PRODUCT00List();
        }
    }
}
