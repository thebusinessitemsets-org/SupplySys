using DDNS.DataModel.SupplyCenter;
using DDNS.Entity.SupplyCenter;
using DDNS.Interface.SupplyCenter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDNS.Provider.SupplyCenter
{
    public class ColOrder01Provider:IColOrder01
    {
        private readonly ColOrder01DataModel _data;

        public ColOrder01Provider(ColOrder01DataModel data)
        {
            _data = data;
        }

        public Task<bool> AddColOrder01(ColOrder01Entity colorder01Entity)
        {
            return _data.AddColOrder01(colorder01Entity);
        }
         
        public Task<bool> UpdateColOrder01(ColOrder01Entity colorder01Entity)
        {
            return _data.UpdateColOrder01(colorder01Entity);
        }
        public Task<ColOrder01Entity> ColOrder01(int id)
        {
            return _data.ColOrder01(id);
        }
        public Task<IEnumerable<ColOrder01Entity>> ColOrder01List(int id)
        {
            return _data.ColOrder01List(id);
        }
    }
}
