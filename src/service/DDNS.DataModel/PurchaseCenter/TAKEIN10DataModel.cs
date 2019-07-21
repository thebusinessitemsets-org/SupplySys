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
    public class TAKEIN10DataModel
    {
        private readonly DDNSDbContext _content;

        public TAKEIN10DataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> AddTAKEIN10s(List<TAKEIN10Entity> tAKEIN10Entities)
        {
            await _content.TAKEIN10.AddRangeAsync(tAKEIN10Entities);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelTAKEIN10(int Id)
        {
            var _data = _content.TAKEIN10.FindAsync(Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateTAKEIN10(TAKEIN10Entity tAKEIN10Entities)
        {
            var _data = _content.TAKEIN10.FindAsync(tAKEIN10Entities.Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<TAKEIN10Entity> TAKEIN10(int id)
        {
            return await _content.TAKEIN10.FindAsync(id);
        }

        public async Task<IEnumerable<TAKEIN10Entity>> TAKEIN10List()
        {
            var list = await _content.TAKEIN10.Where(x => x.Id == x.Id).ToListAsync();
            list = list.OrderByDescending(x => x.Id).ToList();
            return list;
        }
    }
}
