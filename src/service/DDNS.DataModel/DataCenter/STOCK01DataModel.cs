﻿using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity;
using DDNS.Entity.DataCenter;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace DDNS.DataModel.DataCenter
{
    public class STOCK01DataModel
    {
        private readonly DDNSDbContext _content;

        public STOCK01DataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> AddSTOCK01s(List<STOCK01Entity> sTOCK01Entities)
        {
            await _content.STOCK01.AddRangeAsync(sTOCK01Entities);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelSTOCK01(int Id)
        {
            var _data = _content.STOCK01.FindAsync(Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateSTOCK01(STOCK01Entity sTOCK01Entity)
        {
            var _data = _content.STOCK01.FindAsync(sTOCK01Entity.Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<STOCK01Entity> STOCK01(int id)
        {
            return await _content.STOCK01.FindAsync(id);
        }

        public async Task<IEnumerable<STOCK01Entity>> STOCK01List()
        {
            var list = await _content.STOCK01.Where(x => x.Id == x.Id).ToListAsync();
            list = list.OrderByDescending(x => x.Id).ToList();
            return list;
        }
    }
}
