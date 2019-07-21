﻿using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity;
using DDNS.Entity.PurchaseCenter;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace DDNS.DataModel.PurchaseCenter
{
    public class OUT_BACK00DataModel
    {
        private readonly DDNSDbContext _content;

        public OUT_BACK00DataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> AddOUT_BACK00s(List<OUT_BACK00Entity> oUT_BACK00Entities)
        {
            await _content.OUT_BACK00.AddRangeAsync(oUT_BACK00Entities);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelOUT_BACK00(int Id)
        {
            var _data = _content.OUT_BACK00.FindAsync(Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOUT_BACK00(OUT_BACK00Entity oUT_BACK00Entity)
        {
            var _data = _content.OUT_BACK00.FindAsync(oUT_BACK00Entity.Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<OUT_BACK00Entity> OUT_BACK00(int id)
        {
            return await _content.OUT_BACK00.FindAsync(id);
        }

        public async Task<IEnumerable<OUT_BACK00Entity>> OUT_BACK00List()
        {
            var list = await _content.OUT_BACK00.Where(x => x.Id == x.Id).ToListAsync();
            list = list.OrderByDescending(x => x.Id).ToList();
            return list;
        }
    }
}
