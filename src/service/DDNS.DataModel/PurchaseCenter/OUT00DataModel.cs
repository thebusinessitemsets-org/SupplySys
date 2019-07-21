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
    public class OUT00DataModel
    {
        private readonly DDNSDbContext _content;

        public OUT00DataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> AddOUT00s(List<OUT00Entity> oUT00Entities)
        {
            await _content.OUT00.AddRangeAsync(oUT00Entities);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelOUT00(int Id)
        {
            var _data = _content.OUT00.FindAsync(Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOUT00(OUT00Entity oUT00Entity)
        {
            var _data = _content.OUT00.FindAsync(oUT00Entity.Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<OUT00Entity> OUT00(int id)
        {
            return await _content.OUT00.FindAsync(id);
        }

        public async Task<IEnumerable<OUT00Entity>> OUT00List()
        {
            var list = await _content.OUT00.Where(x => x.Id == x.Id).ToListAsync();
            list = list.OrderByDescending(x => x.Id).ToList();
            return list;
        }
    }
}
