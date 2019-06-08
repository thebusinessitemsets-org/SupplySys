using DDNS.DataModel.SupplyCenter;
using DDNS.Entity.SupplyCenter;
using DDNS.Interface.SupplyCenter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDNS.Provider.SupplyCenter
{
    public class ColOrder02Provider:IColOrder02
    {
        private readonly ColOrder02DataModel _data;

        public ColOrder02Provider(ColOrder02DataModel data)
        {
            _data = data;
        }

        public Task<bool> AddColOrder02(ColOrder02Entity colorder02Entity)
        {
            return _data.AddColOrder02(colorder02Entity);
        }

        public Task<bool> UpdateColOrder02(ColOrder02Entity colorder02Entity)
        {
            return _data.UpdateColOrder02(colorder02Entity);
        }
        public Task<ColOrder02Entity> ColOrder02(int id)
        {
            return _data.ColOrder02(id);
        }
        public Task<IEnumerable<ColOrder02Entity>> ColOrder02List(int id)
        {
            return _data.ColOrder02List(id);
        }
    }
}
