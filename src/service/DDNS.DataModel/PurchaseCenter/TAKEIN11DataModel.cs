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
    public class TAKEIN11DataModel
    {
        private readonly DDNSDbContext _content;

        public TAKEIN11DataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> AddTAKEIN11s(List<TAKEIN11Entity> tAKEIN11Entities)
        {
            await _content.TAKEIN11.AddRangeAsync(tAKEIN11Entities);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelTAKEIN11(int Id)
        {
            var _data = _content.TAKEIN11.FindAsync(Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateTAKEIN11(TAKEIN11Entity tAKEIN11Entity)
        {
            var _data = _content.TAKEIN11.FindAsync(tAKEIN11Entity.Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<TAKEIN11Entity> TAKEIN11(int id)
        {
            return await _content.TAKEIN11.FindAsync(id);
        }

        public async Task<IEnumerable<TAKEIN11Entity>> TAKEIN11List()
        {
            var list = await _content.TAKEIN11.Where(x => x.Id == x.Id).ToListAsync();
            list = list.OrderByDescending(x => x.Id).ToList();
            return list;
        }
    }
}
