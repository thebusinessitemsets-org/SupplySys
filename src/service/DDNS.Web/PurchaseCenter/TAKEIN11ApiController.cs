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
    public class TAKEIN11ApiController: ControllerBase
    {
        private readonly TAKEIN11Provider _tAKEIN11Provider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<TAKEIN11ApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public TAKEIN11ApiController(TAKEIN11Provider tAKEIN11Provider, LoginLogProvider loginLogProvider, IStringLocalizer<TAKEIN11ApiController> localizer, IOptions<TunnelConfig> config)
        {
            _tAKEIN11Provider = tAKEIN11Provider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 批量新增厂商验收明细
        /// </summary>
        /// <param name="tAKEIN11ViewModels"></param>
        /// <returns></returns>
        [Route("AddTAKEIN11s")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddTAKEIN11s(List<TAKEIN11ViewModel> tAKEIN11ViewModels)
        {
            var data = new ResponseViewModel<bool>();
            var dataList = new List<TAKEIN11Entity>();
            foreach (TAKEIN11ViewModel tAKEIN11ViewModel in tAKEIN11ViewModels)
            {
                dataList.Add(new TAKEIN11Entity
                {
                    Id = tAKEIN11ViewModel.Id,
                    SHOP_ID = tAKEIN11ViewModel.SHOP_ID,
                    TAKEIN_ID = tAKEIN11ViewModel.TAKEIN_ID,
                    SNo = tAKEIN11ViewModel.SNo,
                    PROD_ID = tAKEIN11ViewModel.PROD_ID,
                    QUANTITY = tAKEIN11ViewModel.QUANTITY,
                    STD_UNIT = tAKEIN11ViewModel.STD_UNIT,
                    STD_CONVERT = tAKEIN11ViewModel.STD_CONVERT,
                    STD_QUAN = tAKEIN11ViewModel.STD_QUAN,
                    STD_PRICE = tAKEIN11ViewModel.STD_PRICE,
                    Tax = tAKEIN11ViewModel.Tax,
                    QUAN1 = tAKEIN11ViewModel.QUAN1,
                    QUAN2 = tAKEIN11ViewModel.QUAN2,
                    Item_DISC_Amt = tAKEIN11ViewModel.Item_DISC_Amt,
                    MEMO = tAKEIN11ViewModel.MEMO,
                    BAT_NO= tAKEIN11ViewModel.BAT_NO,
                    Exp_DateTime=tAKEIN11ViewModel.Exp_DateTime
                });
            }
            data.Data = await _tAKEIN11Provider.AddTAKEIN11s(dataList);
            return data;
        }
        /// <summary>
        /// 删除厂商验收明细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DelTAKEIN11")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelTAKEIN11(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _tAKEIN11Provider.DelTAKEIN11(id)
            };

            return data;
        }

        /// <summary>
        /// 更新厂商验收明细
        /// </summary>
        /// <param name="id"></param>
        /// <param name="TAKEIN11ViewModel"></param>
        /// <returns></returns>
        [Route("TAKEIN11")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> TAKEIN11(int id, TAKEIN11ViewModel tAKEIN11ViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var entityData = await _tAKEIN11Provider.TAKEIN11(id);
            entityData.Id = tAKEIN11ViewModel.Id;
            entityData.SHOP_ID = tAKEIN11ViewModel.SHOP_ID;
            entityData.TAKEIN_ID = tAKEIN11ViewModel.TAKEIN_ID;
            entityData.SNo = tAKEIN11ViewModel.SNo;
            entityData.PROD_ID = tAKEIN11ViewModel.PROD_ID;
            entityData.QUANTITY = tAKEIN11ViewModel.QUANTITY;
            entityData.STD_UNIT = tAKEIN11ViewModel.STD_UNIT;
            entityData.STD_CONVERT = tAKEIN11ViewModel.STD_CONVERT;
            entityData.STD_QUAN = tAKEIN11ViewModel.STD_QUAN;
            entityData.STD_PRICE = tAKEIN11ViewModel.STD_PRICE;
            entityData.Tax = tAKEIN11ViewModel.Tax;
            entityData.QUAN1 = tAKEIN11ViewModel.QUAN1;
            entityData.QUAN2 = tAKEIN11ViewModel.QUAN2;
            entityData.Item_DISC_Amt = tAKEIN11ViewModel.Item_DISC_Amt;
            entityData.MEMO = tAKEIN11ViewModel.MEMO;
            entityData.BAT_NO = tAKEIN11ViewModel.BAT_NO;
            entityData.Exp_DateTime = tAKEIN11ViewModel.Exp_DateTime;

            data.Data = await _tAKEIN11Provider.UpdateTAKEIN11(entityData);

            return data;
        }

        /// <summary>
        /// 查询单个厂商验收明细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("TAKEIN11")]
        [HttpGet]
        public async Task<TAKEIN11Entity> TAKEIN11(int id)
        {
            return await _tAKEIN11Provider.TAKEIN11(id);
        }

        /// <summary>
        /// 查询厂商验收明细
        /// </summary>
        /// <returns></returns>
        [Route("TAKEIN11List")]
        [HttpGet]
        public async Task<IEnumerable<TAKEIN11Entity>> TAKEIN11List()
        {
            var list = await _tAKEIN11Provider.TAKEIN11List();

            list = list.OrderByDescending(x => x.Id).ToList();

            return list;

        }
    }
}
