using DDNS.Entity;
using DDNS.Entity.SupplyCenter;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDNS.DataModel.SupplyCenter
{
    public class Order01DataModel
    {
        private readonly DDNSDbContext _content;

        public Order01DataModel(DDNSDbContext context)
        {
            _content = context;
        }
         
        public async Task<bool> AddOrder01(Order01Entity orderEntity)
        {
            await _content.Order01.AddAsync(orderEntity);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelOrder01(int id)
        {
            var _order = await _content.Order01.FindAsync(id);
            if (_order != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
                return false;
        }

        public async Task<bool> UpdateOrder01(Order01Entity orderEntity)
        {
            var _order = await _content.Order01.FindAsync(orderEntity.Id);
            if (_order != null)
            {
                _order = orderEntity;

                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<Order01Entity> Order01(int id)
        {
            return await _content.Order01.FindAsync(id);
        }

        public async Task<IEnumerable<Order01Entity>> Order01List(string orderId)
        {
            var list = await _content.Order01.Where(x => x.ORDER_ID == orderId).ToListAsync();

            list = list.OrderByDescending(x => x.CRT_DATETIME).ToList();

            return list;

        }


    }
}
