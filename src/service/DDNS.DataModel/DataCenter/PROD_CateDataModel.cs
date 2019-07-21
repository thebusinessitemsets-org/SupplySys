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
    public class PROD_CateDataModel
    {
        private readonly DDNSDbContext _content;

        public PROD_CateDataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> AddPROD_Cate(PROD_CateEntity prod_CateEntity)
        {
            await _content.PROD_Cate.AddAsync(prod_CateEntity);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> AddPROD_Cates(List<PROD_CateEntity> prod_CateEntities)
        {
            await _content.PROD_Cate.AddRangeAsync(prod_CateEntities);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelPROD_Cate(int Id)
        {
            var _data = _content.PROD_Cate.FindAsync(Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdatePROD_Cate(PROD_CateEntity pROD_CateEntity)
        {
            var _data = _content.PROD_Cate.FindAsync(pROD_CateEntity.Id);
            if (_data != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<PROD_CateEntity> PROD_Cate(int id)
        {
            return await _content.PROD_Cate.FindAsync(id);
        }

        public async Task<IEnumerable<PROD_CateEntity>> PROD_CateList()
        {
            var list = await _content.PROD_Cate.Where(x => x.Id == x.Id).ToListAsync();
            list = list.OrderByDescending(x => x.Id).ToList();
            return list;
        }
    }
}
