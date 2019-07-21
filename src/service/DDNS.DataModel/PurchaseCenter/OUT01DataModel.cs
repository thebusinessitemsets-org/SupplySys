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
    public class OUT01DataModel
    {
        private readonly DDNSDbContext _content;

        public OUT01DataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> AddOUT01s(List<OUT01Entity> oUT01Entities)
        {
            await _content.OUT01.AddRangeAsync(oUT01Entities);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelOUT01(int Id)
        {
            var _data = _content.OUT01.FindAsync(Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOUT01(OUT01Entity oUT01Entity)
        {
            var _data = _content.OUT01.FindAsync(oUT01Entity.Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<OUT01Entity> OUT01(int id)
        {
            return await _content.OUT01.FindAsync(id);
        }

        public async Task<IEnumerable<OUT01Entity>> OUT01List()
        {
            var list = await _content.OUT01.Where(x => x.Id == x.Id).ToListAsync();
            list = list.OrderByDescending(x => x.Id).ToList();
            return list;
        }
    }
}
