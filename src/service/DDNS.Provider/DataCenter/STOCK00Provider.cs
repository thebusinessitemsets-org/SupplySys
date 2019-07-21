using System;
using System.Collections.Generic;
using System.Text;
using DDNS.DataModel.DataCenter;
using DDNS.Entity.DataCenter;
using DDNS.Interface.DataCenter;
using System.Threading.Tasks;

namespace DDNS.Provider.DataCenter
{
    public class STOCK00Provider:ISTOCK00
    {
        public readonly STOCK00DataModel _data;
        public STOCK00Provider(STOCK00DataModel data)
        {
            _data = data;
        }

        public Task<bool> AddSTOCK00s(List<STOCK00Entity> sTOCK00Entities)
        {
            return _data.AddSTOCK00s(sTOCK00Entities);
        }

        public Task<bool> DelSTOCK00(int ID)
        {
            return _data.DelSTOCK00(ID);
        }

        public Task<bool> UpdateSTOCK00(STOCK00Entity sTOCK00Entities)
        {
            return _data.UpdateSTOCK00(sTOCK00Entities);
        }

        public Task<STOCK00Entity> STOCK00(int id)
        {
            return _data.STOCK00(id);
        }

        public Task<IEnumerable<STOCK00Entity>> STOCK00List()
        {
            return _data.STOCK00List();
        }
    }
}
