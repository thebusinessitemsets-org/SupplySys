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
    public class TAKEIN10ApiController : ControllerBase
    {
        private readonly TAKEIN10Provider _tAKEIN10Provider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<TAKEIN10ApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public TAKEIN10ApiController(TAKEIN10Provider tAKEIN10Provider, LoginLogProvider loginLogProvider, IStringLocalizer<TAKEIN10ApiController> localizer, IOptions<TunnelConfig> config)
        {
            _tAKEIN10Provider = tAKEIN10Provider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 批量新增厂商进货验收主表
        /// </summary>
        /// <param name="tAKEIN10ViewModels"></param>
        /// <returns></returns>
        [Route("AddTAKEIN10s")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddTAKEIN10s(List<TAKEIN10ViewModel> tAKEIN10ViewModels)
        {
            var data = new ResponseViewModel<bool>();
            var dataList = new List<TAKEIN10Entity>();
            foreach (TAKEIN10ViewModel tAKEIN10ViewModel in tAKEIN10ViewModels)
            {
                dataList.Add(new TAKEIN10Entity
                {
                    Id = tAKEIN10ViewModel.Id,
                    SHOP_ID = tAKEIN10ViewModel.SHOP_ID,
                    TAKEIN_ID = tAKEIN10ViewModel.TAKEIN_ID,
                    STATUS = tAKEIN10ViewModel.STATUS,
                    STOCK_ID = tAKEIN10ViewModel.STOCK_ID,
                    INPUT_DATE = tAKEIN10ViewModel.INPUT_DATE,
                    SUP_ID = tAKEIN10ViewModel.SUP_ID,
                    USER_ID = tAKEIN10ViewModel.USER_ID,
                    APP_USER = tAKEIN10ViewModel.APP_USER,
                    APP_DATETIME = tAKEIN10ViewModel.APP_DATETIME,
                    TOT_AMOUNT = tAKEIN10ViewModel.TOT_AMOUNT,
                    TOT_TAX = tAKEIN10ViewModel.TOT_TAX,
                    TOT_QTY = tAKEIN10ViewModel.TOT_QTY,
                    PRE_PAY = tAKEIN10ViewModel.PRE_PAY,
                    PER_PAY_ID = tAKEIN10ViewModel.PER_PAY_ID,
                    RELATE_ID = tAKEIN10ViewModel.RELATE_ID,
                    INVOICE_ID = tAKEIN10ViewModel.INVOICE_ID,
                    TAKEIN_TYPE = tAKEIN10ViewModel.TAKEIN_TYPE,
                    Memo = tAKEIN10ViewModel.Memo,
                    LOCKED = tAKEIN10ViewModel.LOCKED,
                    CRT_DATETIME = tAKEIN10ViewModel.CRT_DATETIME,
                    CRT_USER_ID = tAKEIN10ViewModel.CRT_USER_ID,
                    MOD_DATETIME = tAKEIN10ViewModel.MOD_DATETIME,
                    MOD_USER_ID = tAKEIN10ViewModel.MOD_USER_ID,
                    LAST_UPDATE = tAKEIN10ViewModel.LAST_UPDATE,
                    Trans_STATUS = tAKEIN10ViewModel.Trans_STATUS
                });
            }
            data.Data = await _tAKEIN10Provider.AddTAKEIN10s(dataList);
            return data;
        }
        /// <summary>
        /// 删除厂商进货验收主表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DelTAKEIN10")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelTAKEIN10(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _tAKEIN10Provider.DelTAKEIN10(id)
            };

            return data;
        }

        /// <summary>
        /// 更新厂商进货验收主表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tAKEIN10ViewModel"></param>
        /// <returns></returns>
        [Route("TAKEIN10")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> TAKEIN10(int id, TAKEIN10ViewModel tAKEIN10ViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var entityData = await _tAKEIN10Provider.TAKEIN10(id);
            entityData.Id = tAKEIN10ViewModel.Id;
            entityData.SHOP_ID = tAKEIN10ViewModel.SHOP_ID;
            entityData.TAKEIN_ID = tAKEIN10ViewModel.TAKEIN_ID;
            entityData.STATUS = tAKEIN10ViewModel.STATUS;
            entityData.STOCK_ID = tAKEIN10ViewModel.STOCK_ID;
            entityData.INPUT_DATE = tAKEIN10ViewModel.INPUT_DATE;
            entityData.SUP_ID = tAKEIN10ViewModel.SUP_ID;
            entityData.USER_ID = tAKEIN10ViewModel.USER_ID;
            entityData.APP_USER = tAKEIN10ViewModel.APP_USER;
            entityData.APP_DATETIME = tAKEIN10ViewModel.APP_DATETIME;
            entityData.TOT_AMOUNT = tAKEIN10ViewModel.TOT_AMOUNT;
            entityData.TOT_TAX = tAKEIN10ViewModel.TOT_TAX;
            entityData.TOT_QTY = tAKEIN10ViewModel.TOT_QTY;
            entityData.PRE_PAY = tAKEIN10ViewModel.PRE_PAY;
            entityData.PER_PAY_ID = tAKEIN10ViewModel.PER_PAY_ID;
            entityData.RELATE_ID = tAKEIN10ViewModel.RELATE_ID;
            entityData.INVOICE_ID = tAKEIN10ViewModel.INVOICE_ID;
            entityData.TAKEIN_TYPE = tAKEIN10ViewModel.TAKEIN_TYPE;
            entityData.Memo = tAKEIN10ViewModel.Memo;
            entityData.LOCKED = tAKEIN10ViewModel.LOCKED;
            entityData.CRT_DATETIME = tAKEIN10ViewModel.CRT_DATETIME;
            entityData.CRT_USER_ID = tAKEIN10ViewModel.CRT_USER_ID;
            entityData.MOD_DATETIME = tAKEIN10ViewModel.MOD_DATETIME;
            entityData.MOD_USER_ID = tAKEIN10ViewModel.MOD_USER_ID;
            entityData.LAST_UPDATE = tAKEIN10ViewModel.LAST_UPDATE;
            entityData.Trans_STATUS = tAKEIN10ViewModel.Trans_STATUS;

            data.Data = await _tAKEIN10Provider.UpdateTAKEIN10(entityData);

            return data;
        }

        /// <summary>
        /// 查询单个厂商进货验收主表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("TAKEIN10")]
        [HttpGet]
        public async Task<TAKEIN10Entity> TAKEIN10(int id)
        {
            return await _tAKEIN10Provider.TAKEIN10(id);
        }

        /// <summary>
        /// 查询厂商进货验收主表
        /// </summary>
        /// <returns></returns>
        [Route("TAKEIN10List")]
        [HttpGet]
        public async Task<IEnumerable<TAKEIN10Entity>> TAKEIN10List()
        {
            var list = await _tAKEIN10Provider.TAKEIN10List();

            list = list.OrderByDescending(x => x.Id).ToList();

            return list;

        }
    }
}
