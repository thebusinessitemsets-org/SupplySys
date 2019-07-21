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
    public class Purchase01ApiController
    {
        private readonly Purchase01Provider  _purchase01Provider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<Purchase01ApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public Purchase01ApiController(Purchase01Provider purchase01Provider, LoginLogProvider loginLogProvider, IStringLocalizer<Purchase01ApiController> localizer, IOptions<TunnelConfig> config)
        {
            _purchase01Provider = purchase01Provider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 批量新增采购订单明细
        /// </summary>
        /// <param name="purchase01ViewModels"></param>
        /// <returns></returns>
        [Route("AddPurchase01s")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddPurchase01s(List<Purchase01ViewModel> purchase01ViewModels)
        {
            var data = new ResponseViewModel<bool>();
            var dataList = new List<Purchase01Entity>();
            foreach (Purchase01ViewModel purchase01ViewModel in purchase01ViewModels)
            {
                dataList.Add(new Purchase01Entity
                {
                    Id = purchase01ViewModel.Id,
                    SHOP_ID = purchase01ViewModel.SHOP_ID,
                    Purchase_ID = purchase01ViewModel.Purchase_ID,
                    SNo = purchase01ViewModel.SNo,
                    PROD_ID = purchase01ViewModel.PROD_ID,
                    QUANTITY = purchase01ViewModel.QUANTITY,
                    STD_UNIT = purchase01ViewModel.STD_UNIT,
                    STD_CONVERT = purchase01ViewModel.STD_CONVERT,
                    STD_QUAN = purchase01ViewModel.STD_QUAN,
                    STD_PRICE = purchase01ViewModel.STD_PRICE,
                    Tax = purchase01ViewModel.Tax,
                    QUAN1 = purchase01ViewModel.QUAN1,
                    QUAN2 = purchase01ViewModel.QUAN2,
                    Item_DISC_Amt = purchase01ViewModel.Item_DISC_Amt,
                    MEMO = purchase01ViewModel.MEMO
                });
            }
            data.Data = await _purchase01Provider.AddPurchase01s(dataList);
            return data;
        }
        /// <summary>
        /// 删除采购订单明细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DelPurchase01")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelPurchase01(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _purchase01Provider.DelPurchase01(id)
            };

            return data;
        }

        /// <summary>
        /// 更新采购订单明细
        /// </summary>
        /// <param name="id"></param>
        /// <param name="purchase01ViewModel"></param>
        /// <returns></returns>
        [Route("Purchase01")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> Purchase01(int id, Purchase01ViewModel purchase01ViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var entityData = await _purchase01Provider.Purchase01(id);
            entityData.Id = purchase01ViewModel.Id;
            entityData.SHOP_ID = purchase01ViewModel.SHOP_ID;
            entityData.Purchase_ID = purchase01ViewModel.Purchase_ID;
            entityData.SNo = purchase01ViewModel.SNo;
            entityData.PROD_ID = purchase01ViewModel.PROD_ID;
            entityData.QUANTITY = purchase01ViewModel.QUANTITY;
            entityData.STD_UNIT = purchase01ViewModel.STD_UNIT;
            entityData.STD_CONVERT = purchase01ViewModel.STD_CONVERT;
            entityData.STD_QUAN = purchase01ViewModel.STD_QUAN;
            entityData.STD_PRICE = purchase01ViewModel.STD_PRICE;
            entityData.Tax = purchase01ViewModel.Tax;
            entityData.QUAN1 = purchase01ViewModel.QUAN1;
            entityData.QUAN2 = purchase01ViewModel.QUAN2;
            entityData.Item_DISC_Amt = purchase01ViewModel.Item_DISC_Amt;
            entityData.MEMO = purchase01ViewModel.MEMO;

            data.Data = await _purchase01Provider.UpdatePurchase01(entityData);

            return data;
        }

        /// <summary>
        /// 查询单个采购订单明细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("Purchase01")]
        [HttpGet]
        public async Task<Purchase01Entity> Purchase01(int id)
        {
            return await _purchase01Provider.Purchase01(id);
        }

        /// <summary>
        /// 查询采购订单明细
        /// </summary>
        /// <returns></returns>
        [Route("Purchase01List")]
        [HttpGet]
        public async Task<IEnumerable<Purchase01Entity>> Purchase01List()
        {
            var list = await _purchase01Provider.Purchase01List();

            list = list.OrderByDescending(x => x.Id).ToList();

            return list;

        }
    }
}
