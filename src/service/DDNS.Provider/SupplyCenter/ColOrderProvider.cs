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
    }
}
