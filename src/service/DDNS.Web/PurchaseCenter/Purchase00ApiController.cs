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
    public class Purchase00ApiController : ControllerBase
    {
        private readonly Purchase00Provider _Purchase00Provider;
                       
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<Purchase00ApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public Purchase00ApiController(Purchase00Provider purchase00Provider, LoginLogProvider loginLogProvider, IStringLocalizer<Purchase00ApiController> localizer, IOptions<TunnelConfig> config)
        {
            _Purchase00Provider = purchase00Provider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 批量新增采购订单
        /// </summary>
        /// <param name="purchase00ViewModels"></param>
        /// <returns></returns>
        [Route("AddPurchase00s")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddPurchase00s(List<Purchase00ViewModel> purchase00ViewModels)
        {
            var data = new ResponseViewModel<bool>();
            var dataList = new List<Purchase00Entity>();
            foreach (Purchase00ViewModel purchase00ViewModel in purchase00ViewModels)
            {
                dataList.Add(new Purchase00Entity
                {
                    Id= purchase00ViewModel.Id,
                    SHOP_ID = purchase00ViewModel.SHOP_ID,
                    Purchase_ID = purchase00ViewModel.Purchase_ID,
                    STATUS = purchase00ViewModel.STATUS,
                    PAT_STATUS = purchase00ViewModel.PAT_STATUS,
                    INPUT_DATE = purchase00ViewModel.INPUT_DATE,
                    SUP_ID = purchase00ViewModel.SUP_ID,
                    EXPECT_DATE = purchase00ViewModel.EXPECT_DATE,
                    USER_ID = purchase00ViewModel.USER_ID,
                    APP_USER = purchase00ViewModel.APP_USER,
                    APP_DATETIME = purchase00ViewModel.APP_DATETIME,
                    TOT_AMOUNT = purchase00ViewModel.TOT_AMOUNT,
                    TOT_TAX = purchase00ViewModel.TOT_TAX,
                    TOT_QTY = purchase00ViewModel.TOT_QTY,
                    PRE_PAY = purchase00ViewModel.PRE_PAY,
                    PER_PAY_ID = purchase00ViewModel.PER_PAY_ID,
                    EXPORTED = purchase00ViewModel.EXPORTED,
                    EXPORTED_ID = purchase00ViewModel.EXPORTED_ID,
                    Memo = purchase00ViewModel.Memo,
                    LOCKED = purchase00ViewModel.LOCKED,
                    CRT_DATETIME = purchase00ViewModel.CRT_DATETIME,
                    CRT_USER_ID = purchase00ViewModel.CRT_USER_ID,
                    MOD_DATETIME = purchase00ViewModel.MOD_DATETIME,
                    MOD_USER_ID = purchase00ViewModel.MOD_USER_ID,
                    LAST_UPDATE = purchase00ViewModel.LAST_UPDATE,
                    Trans_STATUS = purchase00ViewModel.Trans_STATUS
                });
            }
            data.Data = await _Purchase00Provider.AddPurchase00s(dataList);
            return data;
        }
        /// <summary>
        /// 删除采购订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DelPurchase00")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelPurchase00(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _Purchase00Provider.DelPurchase00(id)
            };

            return data;
        }

        /// <summary>
        /// 更新采购订单
        /// </summary>
        /// <param name="id"></param>
        /// <param name="purchase00ViewModel"></param>
        /// <returns></returns>
        [Route("Purchase00")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> Purchase00(int id, Purchase00ViewModel purchase00ViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var entityData = await _Purchase00Provider.Purchase00(id);

            entityData.Id = purchase00ViewModel.Id;
            entityData.SHOP_ID = purchase00ViewModel.SHOP_ID;
            entityData.Purchase_ID = purchase00ViewModel.Purchase_ID;
            entityData.STATUS = purchase00ViewModel.STATUS;
            entityData.PAT_STATUS = purchase00ViewModel.PAT_STATUS;
            entityData.INPUT_DATE = purchase00ViewModel.INPUT_DATE;
            entityData.SUP_ID = purchase00ViewModel.SUP_ID;
            entityData.EXPECT_DATE = purchase00ViewModel.EXPECT_DATE;
            entityData.USER_ID = purchase00ViewModel.USER_ID;
            entityData.APP_USER = purchase00ViewModel.APP_USER;
            entityData.APP_DATETIME = purchase00ViewModel.APP_DATETIME;
            entityData.TOT_AMOUNT = purchase00ViewModel.TOT_AMOUNT;
            entityData.TOT_TAX = purchase00ViewModel.TOT_TAX;
            entityData.TOT_QTY = purchase00ViewModel.TOT_QTY;
            entityData.PRE_PAY = purchase00ViewModel.PRE_PAY;
            entityData.PER_PAY_ID = purchase00ViewModel.PER_PAY_ID;
            entityData.EXPORTED = purchase00ViewModel.EXPORTED;
            entityData.EXPORTED_ID = purchase00ViewModel.EXPORTED_ID;
            entityData.Memo = purchase00ViewModel.Memo;
            entityData.LOCKED = purchase00ViewModel.LOCKED;
            entityData.CRT_DATETIME = purchase00ViewModel.CRT_DATETIME;
            entityData.CRT_USER_ID = purchase00ViewModel.CRT_USER_ID;
            entityData.MOD_DATETIME = purchase00ViewModel.MOD_DATETIME;
            entityData.MOD_USER_ID = purchase00ViewModel.MOD_USER_ID;
            entityData.LAST_UPDATE = purchase00ViewModel.LAST_UPDATE;
            entityData.Trans_STATUS = purchase00ViewModel.Trans_STATUS;

            data.Data = await _Purchase00Provider.UpdatePurchase00(entityData);

            return data;
        }

        /// <summary>
        /// 查询单个采购订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("Purchase00")]
        [HttpGet]
        public async Task<Purchase00Entity> Purchase00(int id)
        {
            return await _Purchase00Provider.Purchase00(id);
        }

        /// <summary>
        /// 查询采购订单
        /// </summary>
        /// <returns></returns>
        [Route("Purchase00List")]
        [HttpGet]
        public async Task<IEnumerable<Purchase00Entity>> Purchase00List()
        {
            var list = await _Purchase00Provider.Purchase00List();

            list = list.OrderByDescending(x => x.Id).ToList();

            return list;

        }
    }
}
