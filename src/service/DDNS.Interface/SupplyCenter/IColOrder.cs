using DDNS.Entity.SupplyCenter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDNS.Interface.SupplyCenter
{
    public interface IColOrder
    {
        Task<bool> AddColOrder(ColOrderEntity colorderEntity);
        Task<bool> DelColOrder(int id);
        Task<bool> UpdateColOrder(ColOrderEntity colorderEntity);
        Task<ColOrderEntity> ColOrder(int id);
        Task<IEnumerable<ColOrderEntity>> ColOrderList(DateTime begTime, DateTime endTime);
    }
}
