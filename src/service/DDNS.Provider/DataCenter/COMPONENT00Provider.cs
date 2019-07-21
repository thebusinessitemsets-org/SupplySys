using System;
using System.Collections.Generic;
using System.Text;
using DDNS.DataModel.DataCenter;
using DDNS.Entity.DataCenter;
using DDNS.Interface.DataCenter;
using System.Threading.Tasks;

namespace DDNS.Provider.DataCenter
{
    public class COMPONENT00Provider:ICOMPONENT00
    {
        public readonly COMPONENT00DataModel _data;
        public COMPONENT00Provider(COMPONENT00DataModel data)
        {
            _data = data;
        }

        public Task<bool> AddCOMPONENT00s(List<COMPONENT00Entity> COMPONENT00Entities)
        {
            return _data.AddCOMPONENT00s(COMPONENT00Entities);
        }

        public Task<bool> DelCOMPONENT00(int ID)
        {
            return _data.DelCOMPONENT00(ID);
        }

        public Task<bool> UpdateCOMPONENT00(COMPONENT00Entity COMPONENT00Entity)
        {
            return _data.UpdateCOMPONENT00(COMPONENT00Entity);
        }

        public Task<COMPONENT00Entity> COMPONENT00(int id)
        {
            return _data.COMPONENT00(id);
        }

        public Task<IEnumerable<COMPONENT00Entity>> COMPONENT00List()
        {
            return _data.COMPONENT00List();
        }
    }
}
