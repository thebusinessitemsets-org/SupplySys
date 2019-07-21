using System;
using System.Collections.Generic;
using System.Text;
using DDNS.DataModel.DataCenter;
using DDNS.Entity.DataCenter;
using DDNS.Interface.DataCenter;
using System.Threading.Tasks;

namespace DDNS.Provider.DataCenter
{
    public class STOCK01Provider:ISTOCK01
    {
        public readonly STOCK01DataModel _data;
        public STOCK01Provider(STOCK01DataModel data)
        {
            _data = data;
        }

        public Task<bool> AddSTOCK01s(List<STOCK01Entity> sTOCK01Entities)
        {
            return _data.AddSTOCK01s(sTOCK01Entities);
        }

        public Task<bool> DelSTOCK01(int ID)
        {
            return _data.DelSTOCK01(ID);
        }

        public Task<bool> UpdateSTOCK01(STOCK01Entity sTOCK01Entities)
        {
            return _data.UpdateSTOCK01(sTOCK01Entities);
        }

        public Task<STOCK01Entity> STOCK01(int id)
        {
            return _data.STOCK01(id);
        }

        public Task<IEnumerable<STOCK01Entity>> STOCK01List()
        {
            return _data.STOCK01List();
        }
    }
}
