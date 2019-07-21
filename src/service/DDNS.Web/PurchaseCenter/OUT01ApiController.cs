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
    public class OUT01ApiController:ControllerBase
    {
        private readonly OUT01Provider _oUT01Provider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<OUT01ApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public OUT01ApiController(OUT01Provider oUT01Provider, LoginLogProvider loginLogProvider, IStringLocalizer<OUT01ApiController> localizer, IOptions<TunnelConfig> config)
        {
            _oUT01Provider = oUT01Provider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 批量新增出货作业明细
        /// </summary>
        /// <param name="oUT01ViewModels"></param>
        /// <returns></returns>
        [Route("AddOUT01s")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddOUT01s(List<OUT01ViewModel> oUT01ViewModels)
        {
            var data = new ResponseViewModel<bool>();
            var dataList = new List<OUT01Entity>();
            foreach (OUT01ViewModel oUT01ViewModel in oUT01ViewModels)
            {
                dataList.Add(new OUT01Entity
                {
                    Id = oUT01ViewModel.Id,
                    SHOP_ID = oUT01ViewModel.SHOP_ID,
                    OUT_ID = oUT01ViewModel.OUT_ID,
                    SNo = oUT01ViewModel.SNo,
                    PROD_ID = oUT01ViewModel.PROD_ID,
                    QUANTITY = oUT01ViewModel.QUANTITY,
                    STD_UNIT = oUT01ViewModel.STD_UNIT,
                    STD_CONVERT = oUT01ViewModel.STD_CONVERT,
                    STD_QUAN = oUT01ViewModel.STD_QUAN,
                    STD_PRICE = oUT01ViewModel.STD_PRICE,
                    COST = oUT01ViewModel.COST,
                    QUAN1 = oUT01ViewModel.QUAN1,
                    QUAN2 = oUT01ViewModel.QUAN2,
                    Item_DISC_Amt = oUT01ViewModel.Item_DISC_Amt,
                    MEMO = oUT01ViewModel.MEMO,
                    BAT_NO = oUT01ViewModel.BAT_NO,
                    Exp_DateTime = oUT01ViewModel.Exp_DateTime
                });
            }
            data.Data = await _oUT01Provider.AddOUT01s(dataList);
            return data;
        }
        /// <summary>
        /// 删除出货作业明细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DelOUT01")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelOUT01(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _oUT01Provider.DelOUT01(id)
            };

            return data;
        }

        /// <summary>
        /// 更新出货作业明细
        /// </summary>
        /// <param name="id"></param>
        /// <param name="oUT01ViewModel"></param>
        /// <returns></returns>
        [Route("OUT01")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> OUT01(int id, OUT01ViewModel oUT01ViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var entityData = await _oUT01Provider.OUT01(id);
            entityData.Id = oUT01ViewModel.Id;
            entityData.SHOP_ID = oUT01ViewModel.SHOP_ID;
            entityData.OUT_ID = oUT01ViewModel.OUT_ID;
            entityData.SNo = oUT01ViewModel.SNo;
            entityData.PROD_ID = oUT01ViewModel.PROD_ID;
            entityData.QUANTITY = oUT01ViewModel.QUANTITY;
            entityData.STD_UNIT = oUT01ViewModel.STD_UNIT;
            entityData.STD_CONVERT = oUT01ViewModel.STD_CONVERT;
            entityData.STD_QUAN = oUT01ViewModel.STD_QUAN;
            entityData.STD_PRICE = oUT01ViewModel.STD_PRICE;
            entityData.COST = oUT01ViewModel.COST;
            entityData.QUAN1 = oUT01ViewModel.QUAN1;
            entityData.QUAN2 = oUT01ViewModel.QUAN2;
            entityData.Item_DISC_Amt = oUT01ViewModel.Item_DISC_Amt;
            entityData.MEMO = oUT01ViewModel.MEMO;
            entityData.BAT_NO = oUT01ViewModel.BAT_NO;
            entityData.Exp_DateTime = oUT01ViewModel.Exp_DateTime;

            data.Data = await _oUT01Provider.UpdateOUT01(entityData);

            return data;
        }

        /// <summary>
        /// 查询单个出货作业明细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("OUT01")]
        [HttpGet]
        public async Task<OUT01Entity> OUT01(int id)
        {
            return await _oUT01Provider.OUT01(id);
        }

        /// <summary>
        /// 查询出货作业明细
        /// </summary>
        /// <returns></returns>
        [Route("OUT01List")]
        [HttpGet]
        public async Task<IEnumerable<OUT01Entity>> OUT01List()
        {
            var list = await _oUT01Provider.OUT01List();

            list = list.OrderByDescending(x => x.Id).ToList();

            return list;

        }
    }
}
