using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDNS.Entity.AppSettings;
using DDNS.Entity.SysMangerment;
using DDNS.Provider.LoginLog;
using DDNS.Provider.SysMangerment;
using DDNS.ViewModel.Response;
using DDNS.ViewModel.SysMangerment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;

namespace DDNS.Web.API.SysMangerment
{
    [Route("api")]
    [ApiController]
    public class MenuApiController : ControllerBase
    {
        private readonly MenuInfoProvider _menuInfoProvider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<MenuApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public MenuApiController(MenuInfoProvider menuInfoProvider, LoginLogProvider loginLogProvider, IStringLocalizer<MenuApiController> localizer, IOptions<TunnelConfig> config)
        {
            _menuInfoProvider = menuInfoProvider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="menuInfoViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("addMenuInfo")]
        public async Task<ResponseViewModel<bool>> AddMenuInfo(MenuInfoViewModel menuInfoViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var menu = new MenuInfoEntity
            {
                NAME = menuInfoViewModel.NAME,
                URL = menuInfoViewModel.URL,
                ParentID = menuInfoViewModel.ParentID,
                Sort = menuInfoViewModel.Sort,
                Depth = menuInfoViewModel.Depth,
                IsDisplay = menuInfoViewModel.IsDisplay,
                IsMenu = menuInfoViewModel.IsMenu

            };

            data.Data = await _menuInfoProvider.Add(menu);

            return data;
        }

        /// <summary>
        /// 删除菜单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("delMenuInfo")]
        public async Task<ResponseViewModel<bool>> DelMenuInfo(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _menuInfoProvider.Del(id)
            };

            return data;
        }

        /// <summary>
        /// 更新菜单
        /// </summary>
        /// <param name="id"></param>
        /// <param name="menuInfoEditViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("updateMenuInfo")]
        public async Task<ResponseViewModel<bool>> UpdateMenuInfo(int id, MenuInfoEditViewModel menuInfoEditViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var menu = await _menuInfoProvider.Get(id);

            menu.NAME = menuInfoEditViewModel.NAME;
            menu.URL = menuInfoEditViewModel.URL;
            menu.ParentID = menuInfoEditViewModel.ParentID;
            menu.Sort = menuInfoEditViewModel.Sort;
            menu.Depth = menuInfoEditViewModel.Depth;
            menu.IsDisplay = menuInfoEditViewModel.IsDisplay;
            menu.IsMenu = menuInfoEditViewModel.IsMenu;

            data.Data = await _menuInfoProvider.Update(menu);

            return data;
        }

        /// <summary>
        /// 获取单个菜单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetMenuInfo")]
        public async Task<MenuInfoEntity> Get(int id)
        {
            return await _menuInfoProvider.Get(id);
        }

        /// <summary>
        /// 获取菜单列表
        /// </summary>
        /// <param name="menuName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetMenuInfoList")]
        public async Task<IEnumerable<MenuInfoEntity>> Get(string menuName)
        {
            var list = await _menuInfoProvider.Get(menuName);

            list = list.OrderByDescending(x => x.ID).ToList();

            return list;

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="menuControlInfoViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddMenuControlInfo")]
        public async Task<ResponseViewModel<bool>> AddMenuControlInfo(MenuControlInfoViewModel menuControlInfoViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var menuContrl = new MenuControlInfoEntity
            {
      
                CName = menuControlInfoViewModel.CName,
                EName = menuControlInfoViewModel.EName,
                MenuID = menuControlInfoViewModel.MenuID

            };

            data.Data = await _menuInfoProvider.Add(menuContrl);

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DelMenuControlInfo")]
        public async Task<ResponseViewModel<bool>> DelMenuControlInfo(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _menuInfoProvider.DelMenuControlInfo(id)
            };

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="menuControlInfoEditViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateMenuControlInfo")]
        public async Task<ResponseViewModel<bool>> UpdateMenuControlInfo(int id, MenuControlInfoEditViewModel menuControlInfoEditViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var menuControl = await _menuInfoProvider.GetMenuContrlInfo(id);

            menuControl.CName = menuControlInfoEditViewModel.CName;
            menuControl.EName = menuControlInfoEditViewModel.EName;
            menuControl.MenuID = menuControlInfoEditViewModel.MenuID;

            data.Data = await _menuInfoProvider.Update(menuControl);

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetMenuControlInfo")]
        public async Task<MenuControlInfoEntity> GetMenuControlInfo(int id)
        {
            return await _menuInfoProvider.GetMenuContrlInfo(id);
        }

        /// <summary>
        /// 获取菜单列表
        /// </summary>
        /// <param name="cName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetMenuControlInfoList")]
        public async Task<IEnumerable<MenuControlInfoEntity>> GetMenuContrlInfo(string cName)
        {
            var list = await _menuInfoProvider.GetMenuContrlInfo(cName);

            list = list.OrderByDescending(x => x.ID).ToList();

            return list;

        }





    }
}