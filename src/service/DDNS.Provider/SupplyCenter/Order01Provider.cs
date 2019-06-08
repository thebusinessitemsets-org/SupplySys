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
