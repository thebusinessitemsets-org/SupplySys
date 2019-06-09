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
    public class BranchDataModel
    {
        private readonly DDNSDbContext _content;

        public BranchDataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> Add(BranchEntity branchEntity)
        {
            await _content.Branch.AddAsync(branchEntity);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> Del(int id)
        {
            await _content.Branch.FindAsync(id);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(BranchEntity branchEntity)
        {
            var _menu = await _content.Branch.FindAsync(branchEntity.ID);
            if (_menu != null)
            {
                _menu = branchEntity;

                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<BranchEntity> Get(int id)
        {
            return await _content.Branch.FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<IEnumerable<BranchEntity>> Get(string name)
        {
            var list = await _content.Branch.ToListAsync();

            if (!string.IsNullOrEmpty(name))
            {
                list = list.Where(x => x.Name.Contains(name)).ToList();
            }

            list = list.OrderByDescending(x => x.ID).ToList();

            return list;
        }




    }
}
