using DDNS.DataModel.SysMangerment;
using DDNS.Entity.SysMangerment;
using DDNS.Interface.SysMangerment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDNS.Provider.SysMangerment
{
    public class MenuInfoProvider:IMenu
    {
        private readonly MenuDataModel _data;

        public MenuInfoProvider(MenuDataModel data)
        {
            _data = data;
        }
        public Task<bool> Add(MenuInfoEntity menuInfoEntity)
        {
            return _data.Add(menuInfoEntity);
        }

        public Task<bool> Del(int id)
        {
            return _data.Del(id);
        }

        public Task<bool> Update(MenuInfoEntity menuInfoEntity)
        {
            return _data.Update(menuInfoEntity);
        }

        public Task<MenuInfoEntity> Get(int id)
        {
            return _data.Get(id);
        }

        public Task<IEnumerable<MenuInfoEntity>> Get(string menuName)
        {
            return _data.Get(menuName);
        }

        public Task<bool> Add(MenuControlInfoEntity menuControlInfoEntity)
        {
            return _data.Add(menuControlInfoEntity);
        }

        public Task<bool> DelMenuControlInfo(int id)
        {
            return _data.DelMenuControl(id);
        }

        public Task<bool> Update(MenuControlInfoEntity menuControlInfoEntity)
        {
            return _data.Update(menuControlInfoEntity);
        }

        public Task<MenuControlInfoEntity> GetMenuContrlInfo(int id)
        {
            return _data.GetMenuControlInfo(id);
        }

        public Task<IEnumerable<MenuControlInfoEntity>> GetMenuContrlInfo(string menuControlName)
        {
            return _data.GetMenuControlInfo(menuControlName);
        }
    }
}
