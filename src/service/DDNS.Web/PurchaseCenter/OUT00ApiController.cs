using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDNS.Entity.AppSettings;
using DDNS.Entity.PurchaseCenter;
using DDNS.Provider.LoginLog;
using DDNS.Provider.PurchaseCenter;
using DDNS.ViewModel.Response;
using DDNS.ViewModel.PurchaseCenter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;

namespace DDNS.Web.PurchaseCenter
{
    [Route("api")]
    [ApiController]
    public class OUT00ApiController:ControllerBase
    {
        private readonly OUT00Provider  _oUT00Provider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<OUT00ApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public OUT00ApiController(OUT00Provider  oUT00Provider, LoginLogProvider loginLogProvider, IStringLocalizer<OUT00ApiController> localizer, IOptions<TunnelConfig> config)
        {
            _oUT00Provider = oUT00Provider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 批量新增出货主表
        /// </summary>
        /// <param name="oUT00ViewModels"></param>
        /// <returns></returns>
        [Route("AddOUT00s")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddOUT00s(List<OUT00ViewModel> oUT00ViewModels)
        {
            var data = new ResponseViewModel<bool>();
            var dataList = new List<OUT00Entity>();
            foreach (OUT00ViewModel oUT00ViewModel in oUT00ViewModels)
            {
                dataList.Add(new OUT00Entity
                {
                    Id= oUT00ViewModel.Id,
                    SHOP_ID = oUT00ViewModel.SHOP_ID,
                    OUT_ID = oUT00ViewModel.OUT_ID,
                    STATUS = oUT00ViewModel.STATUS,
                    INPUT_DATE = oUT00ViewModel.INPUT_DATE,
                    IN_SHOP = oUT00ViewModel.IN_SHOP,
                    STOCK_ID = oUT00ViewModel.STOCK_ID,
                    USER_ID = oUT00ViewModel.USER_ID,
                    APP_USER = oUT00ViewModel.APP_USER,
                    APP_DATETIME = oUT00ViewModel.APP_DATETIME,
                    EXPECT_DATE = oUT00ViewModel.EXPECT_DATE,
                    Exported = oUT00ViewModel.Exported,
                    Exported_ID = oUT00ViewModel.Exported_ID,
                    RELATE_ID = oUT00ViewModel.RELATE_ID,
                    Memo = oUT00ViewModel.Memo,
                    LOCKED = oUT00ViewModel.LOCKED,
                    CRT_DATETIME = oUT00ViewModel.CRT_DATETIME,
                    CRT_USER_ID = oUT00ViewModel.CRT_USER_ID,
                    MOD_DATETIME = oUT00ViewModel.MOD_DATETIME,
                    MOD_USER_ID = oUT00ViewModel.MOD_USER_ID,
                    LAST_UPDATE = oUT00ViewModel.LAST_UPDATE,
                    Trans_STATUS = oUT00ViewModel.Trans_STATUS
                });
            }
            data.Data = await _oUT00Provider.AddOUT00s(dataList);
            return data;
        }
        /// <summary>
        /// 删除出货主表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DelOUT00")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelOUT00(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _oUT00Provider.DelOUT00(id)
            };

            return data;
        }

        /// <summary>
        /// 更新出货主表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="oUT00ViewModel"></param>
        /// <returns></returns>
        [Route("OUT00")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> OUT00(int id, OUT00ViewModel oUT00ViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var entityData = await _oUT00Provider.OUT00(id);

            entityData.Id = oUT00ViewModel.Id;
            entityData.SHOP_ID = oUT00ViewModel.SHOP_ID;
            entityData.OUT_ID = oUT00ViewModel.OUT_ID;
            entityData.STATUS = oUT00ViewModel.STATUS;
            entityData.INPUT_DATE = oUT00ViewModel.INPUT_DATE;
            entityData.IN_SHOP = oUT00ViewModel.IN_SHOP;
            entityData.STOCK_ID = oUT00ViewModel.STOCK_ID;
            entityData.USER_ID = oUT00ViewModel.USER_ID;
            entityData.APP_USER = oUT00ViewModel.APP_USER;
            entityData.APP_DATETIME = oUT00ViewModel.APP_DATETIME;
            entityData.EXPECT_DATE = oUT00ViewModel.EXPECT_DATE;
            entityData.Exported = oUT00ViewModel.Exported;
            entityData.Exported_ID = oUT00ViewModel.Exported_ID;
            entityData.RELATE_ID = oUT00ViewModel.RELATE_ID;
            entityData.Memo = oUT00ViewModel.Memo;
            entityData.LOCKED = oUT00ViewModel.LOCKED;
            entityData.CRT_DATETIME = oUT00ViewModel.CRT_DATETIME;
            entityData.CRT_USER_ID = oUT00ViewModel.CRT_USER_ID;
            entityData.MOD_DATETIME = oUT00ViewModel.MOD_DATETIME;
            entityData.MOD_USER_ID = oUT00ViewModel.MOD_USER_ID;
            entityData.LAST_UPDATE = oUT00ViewModel.LAST_UPDATE;
            entityData.Trans_STATUS = oUT00ViewModel.Trans_STATUS;

            data.Data = await _oUT00Provider.UpdateOUT00(entityData);

            return data;
        }

        /// <summary>
        /// 查询单个出货主表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("OUT00")]
        [HttpGet]
        public async Task<OUT00Entity> OUT00(int id)
        {
            return await _oUT00Provider.OUT00(id);
        }

        /// <summary>
        /// 查询出货主表
        /// </summary>
        /// <returns></returns>
        [Route("OUT00List")]
        [HttpGet]
        public async Task<IEnumerable<OUT00Entity>> OUT00List()
        {
            var list = await _oUT00Provider.OUT00List();

            list = list.OrderByDescending(x => x.Id).ToList();

            return list;

        }
    }
}
