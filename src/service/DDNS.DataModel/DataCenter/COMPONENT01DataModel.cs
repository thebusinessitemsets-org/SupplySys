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
    public class COMPONENT01DataModel
    {
        private readonly DDNSDbContext _content;

        public COMPONENT01DataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> AddCOMPONENT01s(List<COMPONENT01Entity> cOMPONENT01Entities)
        {
            await _content.COMPONENT01.AddRangeAsync(cOMPONENT01Entities);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelCOMPONENT01(int Id)
        {
            var _data = _content.COMPONENT01.FindAsync(Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateCOMPONENT01(COMPONENT01Entity cOMPONENT01Entity)
        {
            var _data = _content.COMPONENT01.FindAsync(cOMPONENT01Entity.Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<COMPONENT01Entity> COMPONENT01(int id)
        {
            return await _content.COMPONENT01.FindAsync(id);
        }

        public async Task<IEnumerable<COMPONENT01Entity>> COMPONENT01List()
        {
            var list = await _content.COMPONENT01.Where(x => x.Id == x.Id).ToListAsync();
            list = list.OrderByDescending(x => x.Id).ToList();
            return list;
        }
    }
}
