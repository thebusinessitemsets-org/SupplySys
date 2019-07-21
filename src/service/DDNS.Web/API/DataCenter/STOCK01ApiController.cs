using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDNS.Entity.AppSettings;
using DDNS.Entity.DataCenter;
using DDNS.Provider.LoginLog;
using DDNS.Provider.DataCenter;
using DDNS.ViewModel.Response;
using DDNS.ViewModel.DataCenter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;

namespace DDNS.Web.API.DataCenter
{
    [Route("api")]
    [ApiController]
    public class STOCK01ApiController : ControllerBase
    {
        private readonly STOCK01Provider _sTOCK01Provider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<STOCK01ApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public STOCK01ApiController(STOCK01Provider sTOCK01Provider, LoginLogProvider loginLogProvider, IStringLocalizer<STOCK01ApiController> localizer, IOptions<TunnelConfig> config)
        {
            _sTOCK01Provider = sTOCK01Provider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 批量新增仓库明细
        /// </summary>
        /// <param name="sTOCK01ViewModels"></param>
        /// <returns></returns>
        [Route("AddSTOCK01s")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddSTOCK01s(List<STOCK01ViewModel> sTOCK01ViewModels)
        {
            var data = new ResponseViewModel<bool>();
            var dataList = new List<STOCK01Entity>();
            foreach (STOCK01ViewModel sTOCK01ViewModel in sTOCK01ViewModels)
            {
                dataList.Add(new STOCK01Entity
                {
                    Id = sTOCK01ViewModel.Id,
                    STOCK_ID = sTOCK01ViewModel.STOCK_ID,
                    PROD_ID = sTOCK01ViewModel.PROD_ID,
                    STOCK_UNIT_QUAN = sTOCK01ViewModel.STOCK_UNIT_QUAN,
                    STOCK_UNIT_QUAN1 = sTOCK01ViewModel.STOCK_UNIT_QUAN1,
                    STOCK_UNIT_QUAN2 = sTOCK01ViewModel.STOCK_UNIT_QUAN2,
                    USABLE= sTOCK01ViewModel.USABLE,
                    Meno= sTOCK01ViewModel.Meno,
                    CRT_DATETIME = sTOCK01ViewModel.CRT_DATETIME,
                    CRT_USER_ID = sTOCK01ViewModel.CRT_USER_ID,
                    MOD_DATETIME = sTOCK01ViewModel.MOD_DATETIME,
                    MOD_USER_ID = sTOCK01ViewModel.MOD_USER_ID,
                    LAST_UPDATE = sTOCK01ViewModel.LAST_UPDATE,
                    SHOP_ID = sTOCK01ViewModel.SHOP_ID,
                    COST= sTOCK01ViewModel.COST,
                    COST1 = sTOCK01ViewModel.COST1,
                    COST2 = sTOCK01ViewModel.COST2
                });
            }
            data.Data = await _sTOCK01Provider.AddSTOCK01s(dataList);
            return data;
        }
        /// <summary>
        /// 删除仓库明细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DelSTOCK01")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelSTOCK01(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _sTOCK01Provider.DelSTOCK01(id)
            };

            return data;
        }

        /// <summary>
        /// 更新仓库明细
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sTOCK01ViewModel"></param>
        /// <returns></returns>
        [Route("UpdateSTOCK01")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> UpdateSTOCK01(int id, STOCK01ViewModel sTOCK01ViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var entityData = await _sTOCK01Provider.STOCK01(id);

            entityData.Id = sTOCK01ViewModel.Id;
            entityData.STOCK_ID = sTOCK01ViewModel.STOCK_ID;
            entityData.PROD_ID = sTOCK01ViewModel.PROD_ID;
            entityData.STOCK_UNIT_QUAN = sTOCK01ViewModel.STOCK_UNIT_QUAN;
            entityData.STOCK_UNIT_QUAN1 = sTOCK01ViewModel.STOCK_UNIT_QUAN1;
            entityData.STOCK_UNIT_QUAN2 = sTOCK01ViewModel.STOCK_UNIT_QUAN2;
            entityData.USABLE = sTOCK01ViewModel.USABLE;
            entityData.Meno = sTOCK01ViewModel.Meno;
            entityData.CRT_DATETIME = sTOCK01ViewModel.CRT_DATETIME;
            entityData.CRT_USER_ID = sTOCK01ViewModel.CRT_USER_ID;
            entityData.MOD_DATETIME = sTOCK01ViewModel.MOD_DATETIME;
            entityData.MOD_USER_ID = sTOCK01ViewModel.MOD_USER_ID;
            entityData.LAST_UPDATE = sTOCK01ViewModel.LAST_UPDATE;
            entityData.SHOP_ID = sTOCK01ViewModel.SHOP_ID;
            entityData.COST = sTOCK01ViewModel.COST;
            entityData.COST1 = sTOCK01ViewModel.COST1;
            entityData.COST2 = sTOCK01ViewModel.COST2;

            data.Data = await _sTOCK01Provider.UpdateSTOCK01(entityData);

            return data;
        }

        /// <summary>
        /// 查询单个仓库明细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("STOCK01")]
        [HttpGet]
        public async Task<STOCK01Entity> STOCK01(int id)
        {
            return await _sTOCK01Provider.STOCK01(id);
        }

        /// <summary>
        /// 查询仓库明细
        /// </summary>
        /// <returns></returns>
        [Route("STOCK01List")]
        [HttpGet]
        public async Task<IEnumerable<STOCK01Entity>> STOCK01List()
        {
            var list = await _sTOCK01Provider.STOCK01List();

            list = list.OrderByDescending(x => x.Id).ToList();

            return list;

        }
    }
}
