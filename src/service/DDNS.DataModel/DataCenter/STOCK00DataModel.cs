using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity;
using DDNS.Entity.DataCenter;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace DDNS.DataModel.DataCenter
{
    public class STOCK00DataModel
    {
        private readonly DDNSDbContext _content;

        public STOCK00DataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> AddSTOCK00s(List<STOCK00Entity> sTOCK00Entities)
        {
            await _content.STOCK00.AddRangeAsync(sTOCK00Entities);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelSTOCK00(int Id)
        {
            var _data = _content.STOCK00.FindAsync(Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateSTOCK00(STOCK00Entity sTOCK00Entity)
        {
            var _data = _content.STOCK00.FindAsync(sTOCK00Entity.Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<STOCK00Entity> STOCK00(int id)
        {
            return await _content.STOCK00.FindAsync(id);
        }

        public async Task<IEnumerable<STOCK00Entity>> STOCK00List()
        {
            var list = await _content.STOCK00.Where(x => x.Id == x.Id).ToListAsync();
            list = list.OrderByDescending(x => x.Id).ToList();
            return list;
        }
    }
}
