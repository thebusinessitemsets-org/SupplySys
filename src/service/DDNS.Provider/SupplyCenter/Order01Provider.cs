using DDNS.DataModel.SupplyCenter;
using DDNS.Entity.SupplyCenter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDNS.Provider.SupplyCenter
{
    public class Order01Provider
    {
        private readonly Order01DataModel _data;

        public Order01Provider(Order01DataModel data)
        {
            _data = data;
        }

        public Task<bool> AddOrder01(Order01Entity orderEntity)
        {
           return _data.AddOrder01(orderEntity);
        }
        Task<bool> DelOrder01(int id)
        {
            return _data.DelOrder01(id);
        }
        Task<bool> UpdateOrder01(Order01Entity orderEntity)
        {
            return _data.UpdateOrder01(orderEntity);

        }
        Task<Order01Entity> Order01(int id)
        {
            return _data.Order01(id);
        }
        Task<IEnumerable<Order01Entity>> Order01List(string orderId)
        {
            return _data.Order01List(orderId);
        }
    }
}
