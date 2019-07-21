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
    public class PRODUCT01DataModel
    {
        private readonly DDNSDbContext _content;

        public PRODUCT01DataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> AddPRODUCT01s(List<PRODUCT01Entity> pRODUCT01Entities)
        {
            await _content.PRODUCT01.AddRangeAsync(pRODUCT01Entities);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelPRODUCT01(int Id)
        {
            var _data = _content.PRODUCT01.FindAsync(Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdatePRODUCT01(PRODUCT01Entity pRODUCT01Entity)
        {
            var _data = _content.PRODUCT01.FindAsync(pRODUCT01Entity.Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<PRODUCT01Entity> PRODUCT01(int id)
        {
            return await _content.PRODUCT01.FindAsync(id);
        }

        public async Task<IEnumerable<PRODUCT01Entity>> PRODUCT01List()
        {
            var list = await _content.PRODUCT01.Where(x => x.Id == x.Id).ToListAsync();
            list = list.OrderByDescending(x => x.Id).ToList();
            return list;
        }
    }
}
