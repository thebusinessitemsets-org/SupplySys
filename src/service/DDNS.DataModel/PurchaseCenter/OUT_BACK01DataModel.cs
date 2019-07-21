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
    public class OUT_BACK01DataModel
    {
        private readonly DDNSDbContext _content;

        public OUT_BACK01DataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> AddOUT_BACK01s(List<OUT_BACK01Entity> oUT_BACK01Entities)
        {
            await _content.OUT_BACK01.AddRangeAsync(oUT_BACK01Entities);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelOUT_BACK01(int Id)
        {
            var _data = _content.OUT_BACK01.FindAsync(Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOUT_BACK01(OUT_BACK01Entity oUT_BACK01Entity)
        {
            var _data = _content.OUT_BACK01.FindAsync(oUT_BACK01Entity.Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<OUT_BACK01Entity> OUT_BACK01(int id)
        {
            return await _content.OUT_BACK01.FindAsync(id);
        }

        public async Task<IEnumerable<OUT_BACK01Entity>> OUT_BACK01List()
        {
            var list = await _content.OUT_BACK01.Where(x => x.Id == x.Id).ToListAsync();
            list = list.OrderByDescending(x => x.Id).ToList();
            return list;
        }
    }
}
