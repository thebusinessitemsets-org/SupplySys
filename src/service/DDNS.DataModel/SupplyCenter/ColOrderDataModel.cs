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
    public class ColOrderDataModel
    {
        private readonly DDNSDbContext _content;

        public ColOrderDataModel(DDNSDbContext context)
        {
            _content = context;
        }
        public async Task<bool> AddColOrder(ColOrderEntity colorderEntity)
        {
            await _content.ColOrder.AddAsync(colorderEntity);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelColOrder(int id)
        {
            var _order = await _content.ColOrder.FindAsync(id);
            if (_order != null)
            {
                _order.STATUS = -1;//虚拟删除
                return await _content.SaveChangesAsync() > 0;
            }
            else
                return false;
        }

        public async Task<bool> UpdateColOrder(ColOrderEntity colorderEntity)
        {
            var _order = await _content.ColOrder.FindAsync(colorderEntity.Id);
            if (_order != null)
            {
                _order = colorderEntity;

                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<ColOrderEntity> ColOrder(int id)
        {
            return await _content.ColOrder.FindAsync(id);
        }

        public async Task<IEnumerable<ColOrderEntity>> ColOrderList(DateTime begTime, DateTime endTime)
        {
            var list = await _content.ColOrder.Where(x => x.EXPECT_DATE >= begTime && x.EXPECT_DATE <= endTime).ToListAsync();

            list = list.OrderByDescending(x => x.EXPECT_DATE).ToList();

            return list;

        }

        public async Task<bool> AddColOrder01(ColOrder01Entity colorder01Entity)
        {
            await _content.ColOrder01.AddAsync(colorder01Entity);
            return await _content.SaveChangesAsync() > 0;
        }


        public async Task<bool> UpdateColOrder01(ColOrder01Entity colorder01Entity)
        {
            var _order = await _content.ColOrder01.FindAsync(colorder01Entity.Id);
            if (_order != null)
            {
                _order = colorder01Entity;

                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<ColOrder01Entity> ColOrder01(int id)
        {
            return await _content.ColOrder01.FindAsync(id);
        }

        public async Task<IEnumerable<ColOrder01Entity>> ColOrder01List(int id)
        {
            var list = await _content.ColOrder01.Where(x => x.Id == id).ToListAsync();

            list = list.OrderByDescending(x => x.SNo).ToList();

            return list;

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
