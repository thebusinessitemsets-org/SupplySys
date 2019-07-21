using System;
using System.Collections.Generic;
using System.Text;
using DDNS.DataModel.DataCenter;
using DDNS.Entity.DataCenter;
using DDNS.Interface.DataCenter;
using System.Threading.Tasks;

namespace DDNS.Provider.DataCenter
{
    public class COMPONENT01Provider: ICOMPONENT01
    {
        public readonly COMPONENT01DataModel _data;
        public COMPONENT01Provider(COMPONENT01DataModel data)
        {
            _data = data;
        }

        public Task<bool> AddCOMPONENT01s(List<COMPONENT01Entity> cOMPONENT01Entities)
        {
            return _data.AddCOMPONENT01s(cOMPONENT01Entities);
        }

        public Task<bool> DelCOMPONENT01(int ID)
        {
            return _data.DelCOMPONENT01(ID);
        }

        public Task<bool> UpdateCOMPONENT01(COMPONENT01Entity cOMPONENT01Entity)
        {
            return _data.UpdateCOMPONENT01(cOMPONENT01Entity);
        }

        public Task<COMPONENT01Entity> COMPONENT01(int id)
        {
            return _data.COMPONENT01(id);
        }

        public Task<IEnumerable<COMPONENT01Entity>> COMPONENT01List()
        {
            return _data.COMPONENT01List();
        }
    }
}
