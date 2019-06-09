using DDNS.Entity;
using DDNS.Entity.SysMangerment;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDNS.DataModel.SysMangerment
{
    public class DIVISIONDataModel
    {
        private readonly DDNSDbContext _content;

        public DIVISIONDataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> Add(DIVISIONEntity dIVISIONEntity)
        {
            await _content.DIVISION.AddAsync(dIVISIONEntity);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> Del(int id)
        {
            await _content.DIVISION.FindAsync(id);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(DIVISIONEntity dIVISIONEntity)
        {
            var _menu = await _content.DIVISION.FindAsync(dIVISIONEntity.ID);
            if (_menu != null)
            {
                _menu = dIVISIONEntity;

                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<DIVISIONEntity> Get(int id)
        {
            return await _content.DIVISION.FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<IEnumerable<DIVISIONEntity>> Get(string divName)
        {
            var list = await _content.DIVISION.ToListAsync();

            if (!string.IsNullOrEmpty(divName))
            {
                list = list.Where(x => x.DIV_NAME.Contains(divName)).ToList();
            }

            list = list.OrderByDescending(x => x.ID).ToList();

            return list;
        }
    }
}
