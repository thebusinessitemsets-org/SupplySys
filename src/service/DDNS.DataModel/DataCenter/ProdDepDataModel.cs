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
    public class ProdDepDataModel
    {
        private readonly DDNSDbContext _content;

        public ProdDepDataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> AddProdDep(ProdDepEntity prodDepEntity)
        {
            await _content.ProdDep.AddAsync(prodDepEntity);
            
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelProdDep(int Id)
        {
            var _data = _content.ProdDep.FindAsync(Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateProdDep(ProdDepEntity prodDepEntity)
        {
            var _data = _content.ProdDep.FindAsync(prodDepEntity.Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<ProdDepEntity> ProdDep(int id)
        {
            return await _content.ProdDep.FindAsync(id);
        }

        public async Task<IEnumerable<ProdDepEntity>> ProdDepList()
        {
            var list = await _content.ProdDep.Where(x => x.Id == x.Id).ToListAsync();
            list = list.OrderByDescending(x => x.Id).ToList();
            return list;
        }
    }
}
