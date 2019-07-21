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
    public class OUT_BACK01ApiController : ControllerBase
    {
        private readonly OUT_BACK01Provider _OUT_BACK01Provider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<OUT_BACK01ApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public OUT_BACK01ApiController(OUT_BACK01Provider oUT_BACK01Provider, LoginLogProvider loginLogProvider, IStringLocalizer<OUT_BACK01ApiController> localizer, IOptions<TunnelConfig> config)
        {
            _OUT_BACK01Provider = oUT_BACK01Provider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 批量新增退货出货明细
        /// </summary>
        /// <param name="oUT_BACK01ViewModels"></param>
        /// <returns></returns>
        [Route("AddOUT_BACK01s")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddOUT_BACK01s(List<OUT_BACK01ViewModel> oUT_BACK01ViewModels)
        {
            var data = new ResponseViewModel<bool>();
            var dataList = new List<OUT_BACK01Entity>();
            foreach (OUT_BACK01ViewModel oUT_BACK01ViewModel in oUT_BACK01ViewModels)
            {
                dataList.Add(new OUT_BACK01Entity
                {
                    Id = oUT_BACK01ViewModel.Id,
                    SHOP_ID = oUT_BACK01ViewModel.SHOP_ID,
                    BK_ID = oUT_BACK01ViewModel.BK_ID,
                    SNo = oUT_BACK01ViewModel.SNo,
                    PROD_ID = oUT_BACK01ViewModel.PROD_ID,
                    QUANTITY = oUT_BACK01ViewModel.QUANTITY,
                    STD_UNIT = oUT_BACK01ViewModel.STD_UNIT,
                    STD_CONVERT = oUT_BACK01ViewModel.STD_CONVERT,
                    STD_QUAN = oUT_BACK01ViewModel.STD_QUAN,
                    STD_PRICE = oUT_BACK01ViewModel.STD_PRICE,
                    COST = oUT_BACK01ViewModel.COST,
                    QUAN1 = oUT_BACK01ViewModel.QUAN1,
                    QUAN2 = oUT_BACK01ViewModel.QUAN2,
                    REASON_ID = oUT_BACK01ViewModel.REASON_ID,
                    MEMO = oUT_BACK01ViewModel.MEMO,
                    BAT_NO = oUT_BACK01ViewModel.BAT_NO,
                    Exp_DateTime = oUT_BACK01ViewModel.Exp_DateTime
                });
            }
            data.Data = await _OUT_BACK01Provider.AddOUT_BACK01s(dataList);
            return data;
        }
        /// <summary>
        /// 删除退货出货明细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DelOUT_BACK01")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelOUT_BACK01(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _OUT_BACK01Provider.DelOUT_BACK01(id)
            };

            return data;
        }

        /// <summary>
        /// 更新退货出货明细
        /// </summary>
        /// <param name="id"></param>
        /// <param name="oUT_BACK01ViewModel"></param>
        /// <returns></returns>
        [Route("OUT_BACK01")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> OUT_BACK01(int id, OUT_BACK01ViewModel oUT_BACK01ViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var entityData = await _OUT_BACK01Provider.OUT_BACK01(id);
            entityData.Id = oUT_BACK01ViewModel.Id;
            entityData.SHOP_ID = oUT_BACK01ViewModel.SHOP_ID;
            entityData.BK_ID = oUT_BACK01ViewModel.BK_ID;
            entityData.SNo = oUT_BACK01ViewModel.SNo;
            entityData.PROD_ID = oUT_BACK01ViewModel.PROD_ID;
            entityData.QUANTITY = oUT_BACK01ViewModel.QUANTITY;
            entityData.STD_UNIT = oUT_BACK01ViewModel.STD_UNIT;
            entityData.STD_CONVERT = oUT_BACK01ViewModel.STD_CONVERT;
            entityData.STD_QUAN = oUT_BACK01ViewModel.STD_QUAN;
            entityData.STD_PRICE = oUT_BACK01ViewModel.STD_PRICE;
            entityData.COST = oUT_BACK01ViewModel.COST;
            entityData.QUAN1 = oUT_BACK01ViewModel.QUAN1;
            entityData.QUAN2 = oUT_BACK01ViewModel.QUAN2;
            entityData.REASON_ID = oUT_BACK01ViewModel.REASON_ID;
            entityData.MEMO = oUT_BACK01ViewModel.MEMO;
            entityData.BAT_NO = oUT_BACK01ViewModel.BAT_NO;
            entityData.Exp_DateTime = oUT_BACK01ViewModel.Exp_DateTime;

            data.Data = await _OUT_BACK01Provider.UpdateOUT_BACK01(entityData);

            return data;
        }

        /// <summary>
        /// 查询单个退货出货明细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("OUT_BACK01")]
        [HttpGet]
        public async Task<OUT_BACK01Entity> OUT_BACK01(int id)
        {
            return await _OUT_BACK01Provider.OUT_BACK01(id);
        }

        /// <summary>
        /// 查询退货出货明细
        /// </summary>
        /// <returns></returns>
        [Route("OUT_BACK01List")]
        [HttpGet]
        public async Task<IEnumerable<OUT_BACK01Entity>> OUT_BACK01List()
        {
            var list = await _OUT_BACK01Provider.OUT_BACK01List();

            list = list.OrderByDescending(x => x.Id).ToList();

            return list;

        }
    }
}
