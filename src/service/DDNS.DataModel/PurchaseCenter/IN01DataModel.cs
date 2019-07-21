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
    public class IN01DataModel
    {
        private readonly DDNSDbContext _content;

        public IN01DataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> AddIN01s(List<IN01Entity> iN01Entities)
        {
            await _content.IN01.AddRangeAsync(iN01Entities);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelIN01(int Id)
        {
            var _data = _content.IN01.FindAsync(Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateIN01(IN01Entity iN01Entity)
        {
            var _data = _content.IN01.FindAsync(iN01Entity.Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<IN01Entity> IN01(int id)
        {
            return await _content.IN01.FindAsync(id);
        }

        public async Task<IEnumerable<IN01Entity>> IN01List()
        {
            var list = await _content.IN01.Where(x => x.Id == x.Id).ToListAsync();
            list = list.OrderByDescending(x => x.Id).ToList();
            return list;
        }
    }
}
