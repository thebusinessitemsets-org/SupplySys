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
    public class OUT_BACK00ApiController:ControllerBase
    {
        private readonly OUT_BACK00Provider _OUT_BACK00Provider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<OUT_BACK00ApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public OUT_BACK00ApiController(OUT_BACK00Provider oUT_BACK00Provider, LoginLogProvider loginLogProvider, IStringLocalizer<OUT_BACK00ApiController> localizer, IOptions<TunnelConfig> config)
        {
            _OUT_BACK00Provider = oUT_BACK00Provider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 批量新增退货出货主表
        /// </summary>
        /// <param name="oUT_BACK00ViewModels"></param>
        /// <returns></returns>
        [Route("AddOUT_BACK00s")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddOUT_BACK00s(List<OUT_BACK00ViewModel> oUT_BACK00ViewModels)
        {
            var data = new ResponseViewModel<bool>();
            var dataList = new List<OUT_BACK00Entity>();
            foreach (OUT_BACK00ViewModel oUT_BACK00ViewModel in oUT_BACK00ViewModels)
            {
                dataList.Add(new OUT_BACK00Entity
                {
                    Id = oUT_BACK00ViewModel.Id,
                    SHOP_ID = oUT_BACK00ViewModel.SHOP_ID,
                    BK_ID = oUT_BACK00ViewModel.BK_ID,
                    STATUS = oUT_BACK00ViewModel.STATUS,
                    INPUT_DATE = oUT_BACK00ViewModel.INPUT_DATE,
                    IN_SHOP = oUT_BACK00ViewModel.IN_SHOP,
                    STOCK_ID = oUT_BACK00ViewModel.STOCK_ID,
                    USER_ID = oUT_BACK00ViewModel.USER_ID,
                    APP_USER = oUT_BACK00ViewModel.APP_USER,
                    APP_DATETIME = oUT_BACK00ViewModel.APP_DATETIME,
                    Exported = oUT_BACK00ViewModel.Exported,
                    Exported_ID = oUT_BACK00ViewModel.Exported_ID,
                    RELATE_ID = oUT_BACK00ViewModel.RELATE_ID,
                    Memo = oUT_BACK00ViewModel.Memo,
                    LOCKED = oUT_BACK00ViewModel.LOCKED,
                    CRT_DATETIME = oUT_BACK00ViewModel.CRT_DATETIME,
                    CRT_USER_ID = oUT_BACK00ViewModel.CRT_USER_ID,
                    MOD_DATETIME = oUT_BACK00ViewModel.MOD_DATETIME,
                    MOD_USER_ID = oUT_BACK00ViewModel.MOD_USER_ID,
                    LAST_UPDATE = oUT_BACK00ViewModel.LAST_UPDATE,
                    Trans_STATUS = oUT_BACK00ViewModel.Trans_STATUS
                });
            }
            data.Data = await _OUT_BACK00Provider.AddOUT_BACK00s(dataList);
            return data;
        }
        /// <summary>
        /// 删除退货出货主表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DelOUT_BACK00")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelOUT_BACK00(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _OUT_BACK00Provider.DelOUT_BACK00(id)
            };

            return data;
        }

        /// <summary>
        /// 更新退货出货主表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="OUT_BACK00ViewModel"></param>
        /// <returns></returns>
        [Route("OUT_BACK00")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> OUT_BACK00(int id, OUT_BACK00ViewModel oUT_BACK00ViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var entityData = await _OUT_BACK00Provider.OUT_BACK00(id);

            entityData.Id = oUT_BACK00ViewModel.Id;
            entityData.SHOP_ID = oUT_BACK00ViewModel.SHOP_ID;
            entityData.BK_ID = oUT_BACK00ViewModel.BK_ID;
            entityData.STATUS = oUT_BACK00ViewModel.STATUS;
            entityData.INPUT_DATE = oUT_BACK00ViewModel.INPUT_DATE;
            entityData.IN_SHOP = oUT_BACK00ViewModel.IN_SHOP;
            entityData.STOCK_ID = oUT_BACK00ViewModel.STOCK_ID;
            entityData.USER_ID = oUT_BACK00ViewModel.USER_ID;
            entityData.APP_USER = oUT_BACK00ViewModel.APP_USER;
            entityData.APP_DATETIME = oUT_BACK00ViewModel.APP_DATETIME;
            entityData.Exported = oUT_BACK00ViewModel.Exported;
            entityData.Exported_ID = oUT_BACK00ViewModel.Exported_ID;
            entityData.RELATE_ID = oUT_BACK00ViewModel.RELATE_ID;
            entityData.Memo = oUT_BACK00ViewModel.Memo;
            entityData.LOCKED = oUT_BACK00ViewModel.LOCKED;
            entityData.CRT_DATETIME = oUT_BACK00ViewModel.CRT_DATETIME;
            entityData.CRT_USER_ID = oUT_BACK00ViewModel.CRT_USER_ID;
            entityData.MOD_DATETIME = oUT_BACK00ViewModel.MOD_DATETIME;
            entityData.MOD_USER_ID = oUT_BACK00ViewModel.MOD_USER_ID;
            entityData.LAST_UPDATE = oUT_BACK00ViewModel.LAST_UPDATE;
            entityData.Trans_STATUS = oUT_BACK00ViewModel.Trans_STATUS;

            data.Data = await _OUT_BACK00Provider.UpdateOUT_BACK00(entityData);

            return data;
        }

        /// <summary>
        /// 查询单个退货出货主表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("OUT_BACK00")]
        [HttpGet]
        public async Task<OUT_BACK00Entity> OUT_BACK00(int id)
        {
            return await _OUT_BACK00Provider.OUT_BACK00(id);
        }

        /// <summary>
        /// 查询退货出货主表
        /// </summary>
        /// <returns></returns>
        [Route("OUT_BACK00List")]
        [HttpGet]
        public async Task<IEnumerable<OUT_BACK00Entity>> OUT_BACK00List()
        {
            var list = await _OUT_BACK00Provider.OUT_BACK00List();

            list = list.OrderByDescending(x => x.Id).ToList();

            return list;

        }
    }
}
