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
    public class MenuDataModel
    {
        private readonly DDNSDbContext _content;

        public MenuDataModel(DDNSDbContext context)
        {
            _content = context;
        }

        public async Task<bool> Add(MenuInfoEntity menuInfoEntity)
        {
            await _content.MenuInfo.AddAsync(menuInfoEntity);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> Del(int id)
        {
            await _content.MenuInfo.FindAsync(id);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(MenuInfoEntity menuInfoEntity)
        {
            var _menu = await _content.MenuInfo.FindAsync(menuInfoEntity.ID);
            if (_menu != null)
            {
                _menu = menuInfoEntity;

                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<MenuInfoEntity> Get(int id)
        {
            return await _content.MenuInfo.FirstOrDefaultAsync(x=>x.ID == id);
        }

        public async Task<IEnumerable<MenuInfoEntity>> Get(string menuName)
        {
            var list = await _content.MenuInfo.ToListAsync();

            if (!string.IsNullOrEmpty(menuName))
            {
                list = list.Where(x => x.NAME.Contains(menuName)).ToList();
            }
             
            list = list.OrderByDescending(x => x.ID).ToList();

            return list;
        }



        public async Task<bool> Add(MenuControlInfoEntity menuControlInfoEntity)
        {
            await _content.MenuControlInfo.AddAsync(menuControlInfoEntity);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelMenuControl(int id)
        {
            await _content.MenuControlInfo.FindAsync(id);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(MenuControlInfoEntity menuControlInfoEntity)
        {
            var _menuControl = await _content.MenuControlInfo.FindAsync(menuControlInfoEntity.ID);
            if (_menuControl != null)
            {
                _menuControl = menuControlInfoEntity;

                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<MenuControlInfoEntity> GetMenuControlInfo(int id)
        {
            return await _content.MenuControlInfo.FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<IEnumerable<MenuControlInfoEntity>> GetMenuControlInfo(string menuControlName)
        {
            var list = await _content.MenuControlInfo.ToListAsync();

            if (!string.IsNullOrEmpty(menuControlName))
            {
                list = list.Where(x => x.CName.Contains(menuControlName)).ToList();
            }

            list = list.OrderByDescending(x => x.ID).ToList();

            return list;
        }


    }
}
