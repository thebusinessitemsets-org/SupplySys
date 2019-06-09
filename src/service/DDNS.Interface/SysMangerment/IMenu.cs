using DDNS.Entity.SysMangerment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDNS.Interface.SysMangerment
{
    public interface IMenu
    {
        Task<bool> Add(MenuInfoEntity menuInfoEntity);
        Task<bool> Del(int id);
        Task<bool> Update(MenuInfoEntity menuInfoEntity);
        Task<MenuInfoEntity> Get(int id);
        Task<IEnumerable<MenuInfoEntity>> Get(string menuName);

        Task<bool> Add(MenuControlInfoEntity menuInfoEntity);
        Task<bool> DelMenuControlInfo(int id);
        Task<bool> Update(MenuControlInfoEntity menuInfoEntity);
        Task<MenuControlInfoEntity> GetMenuContrlInfo(int id);
        Task<IEnumerable<MenuControlInfoEntity>> GetMenuContrlInfo(string menuName);

    }
}
