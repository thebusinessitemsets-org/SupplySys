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
    public class ProdKindDataModel
    {
        private readonly DDNSDbContext _content;

        public ProdKindDataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> AddProdKind(ProdKindEntity prodKindEntity)
        {
            await _content.ProdKind.AddAsync(prodKindEntity);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> AddProdKinds(List<ProdKindEntity> prodKindEntitys)
        {
            await _content.ProdKind.AddRangeAsync(prodKindEntitys);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelProdKind(int Id)
        {
            var _data = _content.ProdKind.FindAsync(Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateProdKind(ProdKindEntity prodKindEntity)
        {
            var _data = _content.ProdKind.FindAsync(prodKindEntity.Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<ProdKindEntity> ProdKind(int id)
        {
            return await _content.ProdKind.FindAsync(id);
        }

        public async Task<IEnumerable<ProdKindEntity>> ProdKindList()
        {
            var list = await _content.ProdKind.Where(x => x.Id == x.Id).ToListAsync();
            list = list.OrderByDescending(x => x.Id).ToList();
            return list;
        }
    }
}
