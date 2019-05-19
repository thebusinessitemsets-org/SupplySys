using DDNS.Entity.SupplyCenter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDNS.Interface.SupplyCenter
{
    public interface IOrder
    {
        Task<bool> AddOrder(OrderEntity orderEntity);
        Task<bool> DelOrder(int id);
        Task<bool> UpdateOrder(OrderEntity orderEntity);
        Task<OrderEntity> Order(int id);
        Task<IEnumerable<OrderEntity>> OrderList(DateTime begTime,DateTime endTime);
         
    }
}
