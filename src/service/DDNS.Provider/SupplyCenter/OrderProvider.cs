using DDNS.DataModel.SupplyCenter;
using DDNS.Entity.SupplyCenter;
using DDNS.Interface.SupplyCenter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDNS.Provider.SupplyCenter
{
    public class OrderProvider:IOrder
    {
        private readonly OrderDataModel _data;

        public OrderProvider(OrderDataModel data)
        {
            _data = data;
        }

        public Task<bool> AddOrder(OrderEntity orderEntity)
        {
           return _data.AddOrder(orderEntity);
        }

        public Task<bool> DelOrder(int id)
        {
            return _data.DelOrder(id);
        }
        public Task<bool> UpdateOrder(OrderEntity orderEntity)
        {
            return _data.UpdateOrder(orderEntity);
        }
        public Task<OrderEntity> Order(int id)
        {
            return _data.Order(id);
        }
        public Task<IEnumerable<OrderEntity>> OrderList(DateTime begTime, DateTime endTime)
        {
            return _data.OrderList(begTime, endTime);
        }

        public Task<bool> AddOrder01(Order01Entity orderEntity)
        {
            return _data.AddOrder01(orderEntity);
        }
        public Task<bool> DelOrder01(int id)
        {
            return _data.DelOrder01(id);
        }
        public Task<bool> UpdateOrder01(Order01Entity orderEntity)
        {
            return _data.UpdateOrder01(orderEntity);

        }
        public Task<Order01Entity> Order01(int id)
        {
            return _data.Order01(id);
        }
        public Task<IEnumerable<Order01Entity>> Order01List(int id)
        {
            return _data.Order01List(id);
        }
         
    }
}
