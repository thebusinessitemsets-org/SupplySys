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
    public class IN00ApiController
    {
        private readonly IN00Provider _IN00Provider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<IN00ApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public IN00ApiController(IN00Provider iN00Provider, LoginLogProvider loginLogProvider, IStringLocalizer<IN00ApiController> localizer, IOptions<TunnelConfig> config)
        {
            _IN00Provider = iN00Provider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 批量新增进货主表
        /// </summary>
        /// <param name="iN00ViewModels"></param>
        /// <returns></returns>
        [Route("AddIN00s")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddIN00s(List<IN00ViewModel> iN00ViewModels)
        {
            var data = new ResponseViewModel<bool>();
            var dataList = new List<IN00Entity>();
            foreach (IN00ViewModel iN00ViewModel in iN00ViewModels)
            {
                dataList.Add(new IN00Entity
                {
                    Id = iN00ViewModel.Id,
                    SHOP_ID = iN00ViewModel.SHOP_ID,
                    IN_ID = iN00ViewModel.IN_ID,
                    STATUS = iN00ViewModel.STATUS,
                    INPUT_DATE = iN00ViewModel.INPUT_DATE,
                    OUT_SHOP = iN00ViewModel.OUT_SHOP,
                    STOCK_ID = iN00ViewModel.STOCK_ID,
                    USER_ID = iN00ViewModel.USER_ID,
                    APP_USER = iN00ViewModel.APP_USER,
                    APP_DATETIME = iN00ViewModel.APP_DATETIME,
                    RELATE_ID = iN00ViewModel.RELATE_ID,
                    Memo = iN00ViewModel.Memo,
                    LOCKED = iN00ViewModel.LOCKED,
                    CRT_DATETIME = iN00ViewModel.CRT_DATETIME,
                    CRT_USER_ID = iN00ViewModel.CRT_USER_ID,
                    MOD_DATETIME = iN00ViewModel.MOD_DATETIME,
                    MOD_USER_ID = iN00ViewModel.MOD_USER_ID,
                    LAST_UPDATE = iN00ViewModel.LAST_UPDATE,
                    Trans_STATUS = iN00ViewModel.Trans_STATUS
                });
            }
            data.Data = await _IN00Provider.AddIN00s(dataList);
            return data;
        }
        /// <summary>
        /// 删除进货主表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DelIN00")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelIN00(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _IN00Provider.DelIN00(id)
            };

            return data;
        }

        /// <summary>
        /// 更新进货主表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="IN00ViewModel"></param>
        /// <returns></returns>
        [Route("IN00")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> IN00(int id, IN00ViewModel iN00ViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var entityData = await _IN00Provider.IN00(id);

            entityData.Id = iN00ViewModel.Id;
            entityData.SHOP_ID = iN00ViewModel.SHOP_ID;
            entityData.IN_ID = iN00ViewModel.IN_ID;
            entityData.STATUS = iN00ViewModel.STATUS;
            entityData.INPUT_DATE = iN00ViewModel.INPUT_DATE;
            entityData.OUT_SHOP = iN00ViewModel.OUT_SHOP;
            entityData.STOCK_ID = iN00ViewModel.STOCK_ID;
            entityData.USER_ID = iN00ViewModel.USER_ID;
            entityData.APP_USER = iN00ViewModel.APP_USER;
            entityData.APP_DATETIME = iN00ViewModel.APP_DATETIME;
            entityData.RELATE_ID = iN00ViewModel.RELATE_ID;
            entityData.Memo = iN00ViewModel.Memo;
            entityData.LOCKED = iN00ViewModel.LOCKED;
            entityData.CRT_DATETIME = iN00ViewModel.CRT_DATETIME;
            entityData.CRT_USER_ID = iN00ViewModel.CRT_USER_ID;
            entityData.MOD_DATETIME = iN00ViewModel.MOD_DATETIME;
            entityData.MOD_USER_ID = iN00ViewModel.MOD_USER_ID;
            entityData.LAST_UPDATE = iN00ViewModel.LAST_UPDATE;
            entityData.Trans_STATUS = iN00ViewModel.Trans_STATUS;

            data.Data = await _IN00Provider.UpdateIN00(entityData);

            return data;
        }

        /// <summary>
        /// 查询单个进货主表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("IN00")]
        [HttpGet]
        public async Task<IN00Entity> IN00(int id)
        {
            return await _IN00Provider.IN00(id);
        }

        /// <summary>
        /// 查询进货主表
        /// </summary>
        /// <returns></returns>
        [Route("IN00List")]
        [HttpGet]
        public async Task<IEnumerable<IN00Entity>> IN00List()
        {
            var list = await _IN00Provider.IN00List();

            list = list.OrderByDescending(x => x.Id).ToList();

            return list;

        }
    }
}
