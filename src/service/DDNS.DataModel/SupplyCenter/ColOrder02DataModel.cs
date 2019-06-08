using DDNS.Entity;
using DDNS.Entity.SupplyCenter;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDNS.DataModel.SupplyCenter
{
    public class ColOrder02DataModel
    {
        private readonly DDNSDbContext _content;

        public ColOrder02DataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> AddColOrder02(ColOrder02Entity colorder02Entity)
        {
            await _content.ColOrder02.AddAsync(colorder02Entity);
            return await _content.SaveChangesAsync() > 0;
        }


        public async Task<bool> UpdateColOrder02(ColOrder02Entity colorder02Entity)
        {
            var _order = await _content.ColOrder02.FindAsync(colorder02Entity.Id);
            if (_order != null)
            {
                _order = colorder02Entity;

                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<ColOrder02Entity> ColOrder02(int id)
        {
            return await _content.ColOrder02.FindAsync(id);
        }

        public async Task<IEnumerable<ColOrder02Entity>> ColOrder02List(int id)
        {
            var list = await _content.ColOrder02.Where(x => x.Id == id).ToListAsync();

            list = list.OrderByDescending(x => x.SNo).ToList();

            return list;

        }
    }
}
