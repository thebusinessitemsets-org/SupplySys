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
    public class IN00DataModel
    {
        private readonly DDNSDbContext _content;

        public IN00DataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> AddIN00s(List<IN00Entity> iN00Entities)
        {
            await _content.IN00.AddRangeAsync(iN00Entities);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelIN00(int Id)
        {
            var _data = _content.IN00.FindAsync(Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateIN00(IN00Entity iN00Entity)
        {
            var _data = _content.IN00.FindAsync(iN00Entity.Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<IN00Entity> IN00(int id)
        {
            return await _content.IN00.FindAsync(id);
        }

        public async Task<IEnumerable<IN00Entity>> IN00List()
        {
            var list = await _content.IN00.Where(x => x.Id == x.Id).ToListAsync();
            list = list.OrderByDescending(x => x.Id).ToList();
            return list;
        }
    }
}
