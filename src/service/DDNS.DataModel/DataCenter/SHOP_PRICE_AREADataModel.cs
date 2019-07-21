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
    public class SHOP_PRICE_AREADataModel
    {
        private readonly DDNSDbContext _content;

        public SHOP_PRICE_AREADataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> AddSHOP_PRICE_AREAs(List<SHOP_PRICE_AREAEntity> sHOP_PRICE_AREAEntities)
        {
            await _content.SHOP_PRICE_AREA.AddRangeAsync(sHOP_PRICE_AREAEntities);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelSHOP_PRICE_AREA(int Id)
        {
            var _data = _content.SHOP_PRICE_AREA.FindAsync(Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateSHOP_PRICE_AREA(SHOP_PRICE_AREAEntity sHOP_PRICE_AREAEntity)
        {
            var _data = _content.SHOP_PRICE_AREA.FindAsync(sHOP_PRICE_AREAEntity.Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<SHOP_PRICE_AREAEntity> SHOP_PRICE_AREA(int id)
        {
            return await _content.SHOP_PRICE_AREA.FindAsync(id);
        }

        public async Task<IEnumerable<SHOP_PRICE_AREAEntity>> SHOP_PRICE_AREAList()
        {
            var list = await _content.SHOP_PRICE_AREA.Where(x => x.Id == x.Id).ToListAsync();
            list = list.OrderByDescending(x => x.Id).ToList();
            return list;
        }
    }
}
