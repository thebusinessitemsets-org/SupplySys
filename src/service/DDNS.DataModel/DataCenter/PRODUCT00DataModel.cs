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
    public class PRODUCT00DataModel
    {
        private readonly DDNSDbContext _content;

        public PRODUCT00DataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> AddPRODUCT00s(List<PRODUCT00Entity> pRODUCT00Entities)
        {
            await _content.PRODUCT00.AddRangeAsync(pRODUCT00Entities);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelPRODUCT00(int Id)
        {
            var _data = _content.PRODUCT00.FindAsync(Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdatePRODUCT00(PRODUCT00Entity pRODUCT00Entity)
        {
            var _data = _content.PRODUCT00.FindAsync(pRODUCT00Entity.Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<PRODUCT00Entity> PRODUCT00(int id)
        {
            return await _content.PRODUCT00.FindAsync(id);
        }

        public async Task<IEnumerable<PRODUCT00Entity>> PRODUCT00List()
        {
            var list = await _content.PRODUCT00.Where(x => x.Id == x.Id).ToListAsync();
            list = list.OrderByDescending(x => x.Id).ToList();
            return list;
        }
    }
}
