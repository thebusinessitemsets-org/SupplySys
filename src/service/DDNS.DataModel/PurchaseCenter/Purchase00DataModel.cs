using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity;
using DDNS.Entity.PurchaseCenter;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace DDNS.DataModel.PurchaseCenter
{
    public class Purchase00DataModel
    {
        private readonly DDNSDbContext _content;

        public Purchase00DataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> AddPurchase00s(List<Purchase00Entity> purchase00Entities)
        {
            await _content.Purchase00.AddRangeAsync(purchase00Entities);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelPurchase00(int Id)
        {
            var _data = _content.Purchase00.FindAsync(Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdatePurchase00(Purchase00Entity purchase00Entity)
        {
            var _data = _content.Purchase00.FindAsync(purchase00Entity.Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<Purchase00Entity> Purchase00(int id)
        {
            return await _content.Purchase00.FindAsync(id);
        }

        public async Task<IEnumerable<Purchase00Entity>> Purchase00List()
        {
            var list = await _content.Purchase00.Where(x => x.Id == x.Id).ToListAsync();
            list = list.OrderByDescending(x => x.Id).ToList();
            return list;
        }
    }
}
