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
    public class COMPONENT00DataModel
    {
        private readonly DDNSDbContext _content;

        public COMPONENT00DataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> AddCOMPONENT00s(List<COMPONENT00Entity> cOMPONENT00Entities)
        {
            await _content.COMPONENT00.AddRangeAsync(cOMPONENT00Entities);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelCOMPONENT00(int Id)
        {
            var _data = _content.COMPONENT00.FindAsync(Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateCOMPONENT00(COMPONENT00Entity cOMPONENT00Entity)
        {
            var _data = _content.COMPONENT00.FindAsync(cOMPONENT00Entity.Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<COMPONENT00Entity> COMPONENT00(int id)
        {
            return await _content.COMPONENT00.FindAsync(id);
        }

        public async Task<IEnumerable<COMPONENT00Entity>> COMPONENT00List()
        {
            var list = await _content.COMPONENT00.Where(x => x.Id == x.Id).ToListAsync();
            list = list.OrderByDescending(x => x.Id).ToList();
            return list;
        }
    }
}
