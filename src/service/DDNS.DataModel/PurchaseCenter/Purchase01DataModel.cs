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
    public class Purchase01DataModel
    {
        private readonly DDNSDbContext _content;

        public Purchase01DataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> AddPurchase01s(List<Purchase01Entity> purchase01Entities)
        {
            await _content.Purchase01.AddRangeAsync(purchase01Entities);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelPurchase01(int Id)
        {
            var _data = _content.Purchase01.FindAsync(Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdatePurchase01(Purchase01Entity purchase01Entity)
        {
            var _data = _content.Purchase01.FindAsync(purchase01Entity.Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<Purchase01Entity> Purchase01(int id)
        {
            return await _content.Purchase01.FindAsync(id);
        }

        public async Task<IEnumerable<Purchase01Entity>> Purchase01List()
        {
            var list = await _content.Purchase01.Where(x => x.Id == x.Id).ToListAsync();
            list = list.OrderByDescending(x => x.Id).ToList();
            return list;
        }
    }
}
