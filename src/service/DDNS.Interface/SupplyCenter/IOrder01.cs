using DDNS.Entity.SupplyCenter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDNS.Interface.SupplyCenter
{
    public interface IOrder01
    { 
        Task<bool> AddOrder01(Order01Entity orderEntity);
        Task<bool> DelOrder01(int id);
        Task<bool> UpdateOrder01(Order01Entity orderEntity);
        Task<Order01Entity> Order01(int id);
        Task<List<Order01Entity>> Order01List(DateTime begTime, DateTime endTime);
    }
}
