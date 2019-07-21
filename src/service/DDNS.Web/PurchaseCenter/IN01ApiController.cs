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
    public class IN01ApiController
    {
        private readonly IN01Provider _IN01Provider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<IN01ApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public IN01ApiController(IN01Provider iN01Provider, LoginLogProvider loginLogProvider, IStringLocalizer<IN01ApiController> localizer, IOptions<TunnelConfig> config)
        {
            _IN01Provider = iN01Provider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 批量新增进货明细
        /// </summary>
        /// <param name="iN01ViewModels"></param>
        /// <returns></returns>
        [Route("AddIN01s")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddIN01s(List<IN01ViewModel> iN01ViewModels)
        {
            var data = new ResponseViewModel<bool>();
            var dataList = new List<IN01Entity>();
            foreach (IN01ViewModel iN01ViewModel in iN01ViewModels)
            {
                dataList.Add(new IN01Entity
                {
                    Id = iN01ViewModel.Id,
                    SHOP_ID = iN01ViewModel.SHOP_ID,
                    IN_ID = iN01ViewModel.IN_ID,
                    SNo = iN01ViewModel.SNo,
                    PROD_ID = iN01ViewModel.PROD_ID,
                    QUANTITY = iN01ViewModel.QUANTITY,
                    STD_UNIT = iN01ViewModel.STD_UNIT,
                    STD_CONVERT = iN01ViewModel.STD_CONVERT,
                    STD_QUAN = iN01ViewModel.STD_QUAN,
                    STD_PRICE = iN01ViewModel.STD_PRICE,
                    COST = iN01ViewModel.COST,
                    QUAN1 = iN01ViewModel.QUAN1,
                    QUAN2 = iN01ViewModel.QUAN2,
                    MEMO = iN01ViewModel.MEMO,
                    BAT_NO = iN01ViewModel.BAT_NO,
                    Exp_DateTime = iN01ViewModel.Exp_DateTime
                });
            }
            data.Data = await _IN01Provider.AddIN01s(dataList);
            return data;
        }
        /// <summary>
        /// 删除进货明细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DelIN01")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelIN01(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _IN01Provider.DelIN01(id)
            };

            return data;
        }

        /// <summary>
        /// 更新进货明细
        /// </summary>
        /// <param name="id"></param>
        /// <param name="iN01ViewModel"></param>
        /// <returns></returns>
        [Route("IN01")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> IN01(int id, IN01ViewModel iN01ViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var entityData = await _IN01Provider.IN01(id);

            entityData.Id = iN01ViewModel.Id;
            entityData.SHOP_ID = iN01ViewModel.SHOP_ID;
            entityData.IN_ID = iN01ViewModel.IN_ID;
            entityData.SNo = iN01ViewModel.SNo;
            entityData.PROD_ID = iN01ViewModel.PROD_ID;
            entityData.QUANTITY = iN01ViewModel.QUANTITY;
            entityData.STD_UNIT = iN01ViewModel.STD_UNIT;
            entityData.STD_CONVERT = iN01ViewModel.STD_CONVERT;
            entityData.STD_QUAN = iN01ViewModel.STD_QUAN;
            entityData.STD_PRICE = iN01ViewModel.STD_PRICE;
            entityData.COST = iN01ViewModel.COST;
            entityData.QUAN1 = iN01ViewModel.QUAN1;
            entityData.QUAN2 = iN01ViewModel.QUAN2;
            entityData.MEMO = iN01ViewModel.MEMO;
            entityData.BAT_NO = iN01ViewModel.BAT_NO;
            entityData.Exp_DateTime = iN01ViewModel.Exp_DateTime;

            data.Data = await _IN01Provider.UpdateIN01(entityData);

            return data;
        }

        /// <summary>
        /// 查询单个进货明细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("IN01")]
        [HttpGet]
        public async Task<IN01Entity> IN01(int id)
        {
            return await _IN01Provider.IN01(id);
        }

        /// <summary>
        /// 查询进货明细
        /// </summary>
        /// <returns></returns>
        [Route("IN01List")]
        [HttpGet]
        public async Task<IEnumerable<IN01Entity>> IN01List()
        {
            var list = await _IN01Provider.IN01List();

            list = list.OrderByDescending(x => x.Id).ToList();

            return list;

        }
    }
}
