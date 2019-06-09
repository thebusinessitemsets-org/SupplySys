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
    public class ProdUnitDataModel
    {
        private readonly DDNSDbContext _content;

        public ProdUnitDataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> AddProdUnit(ProdUnitEntity prodUnitEntity)
        {
            await _content.ProdUnit.AddAsync(prodUnitEntity);
            return await _content.SaveChangesAsync()>0;
        }

        public async Task<bool> DelProdUnit(int Id)
        {
            var _data= _content.ProdUnit.FindAsync(Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateProdUnit(ProdUnitEntity prodUnitEntity)
        {
            var _data = _content.ProdUnit.FindAsync(prodUnitEntity.Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<ProdUnitEntity> ProdUnit(int id)
        {
            return await _content.ProdUnit.FindAsync(id);
        }

        public async Task<IEnumerable<ProdUnitEntity>> ProdUnitList()
        {
            var list = await _content.ProdUnit.Where(x => x.Id == x.Id).ToListAsync();
            list = list.OrderByDescending(x => x.Id).ToList();
            return list;
        }

    }
}
