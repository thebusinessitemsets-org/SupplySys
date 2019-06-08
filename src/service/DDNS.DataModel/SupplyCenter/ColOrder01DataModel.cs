﻿using DDNS.Entity;
using DDNS.Entity.SupplyCenter;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDNS.DataModel.SupplyCenter
{
    public class ColOrder01DataModel
    {
        private readonly DDNSDbContext _content;

        public ColOrder01DataModel(DDNSDbContext context)
        {
            _content = context;
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


    }
}
