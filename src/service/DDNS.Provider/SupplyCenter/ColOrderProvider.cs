using DDNS.DataModel.SupplyCenter;
using DDNS.Entity.SupplyCenter;
using DDNS.Interface.SupplyCenter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDNS.Provider.SupplyCenter
{
    public class ColOrderProvider:IColOrder
    {
        private readonly ColOrderDataModel _data;

        public ColOrderProvider(ColOrderDataModel data)
        {
            _data = data;
        }

        public Task<bool> AddColOrder(ColOrderEntity colorderEntity)
        {
            return _data.AddColOrder(colorderEntity);
        }

        public Task<bool> DelColOrder(int id)
        {
            return _data.DelColOrder(id);
        }
        public Task<bool> UpdateColOrder(ColOrderEntity colorderEntity)
        {
            return _data.UpdateColOrder(colorderEntity);
        }
        public Task<ColOrderEntity> ColOrder(int id)
        {
            return _data.ColOrder(id);
        }
        public Task<IEnumerable<ColOrderEntity>> ColOrderList(DateTime begTime, DateTime endTime)
        {
            return _data.ColOrderList(begTime, endTime);
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
