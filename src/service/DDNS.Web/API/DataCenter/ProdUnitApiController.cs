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
    public class ProdUnitApiController : ControllerBase
    {
        private readonly ProdUnitProvider _prodUnitProvider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<ProdUnitApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public ProdUnitApiController(ProdUnitProvider prodUnitProvider, LoginLogProvider loginLogProvider, IStringLocalizer<ProdUnitApiController> localizer, IOptions<TunnelConfig> config)
        {
            _prodUnitProvider = prodUnitProvider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }
        
        /// <summary>
        /// 新增商品大类
        /// </summary>
        /// <param name="prodUnitViewModel"></param>
        /// <returns></returns>
        [Route("AddProdUnit")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddProdUnit(ProdUnitViewModel prodUnitViewModel)
        {
            var data = new ResponseViewModel<bool>();
            var produnit = new ProdUnitEntity
            {
                Id = prodUnitViewModel.Id,
                UNIT_ID = prodUnitViewModel.UNIT_ID,
                UNIT_NAME = prodUnitViewModel.UNIT_NAME,
                UNIT_MEMO = prodUnitViewModel.UNIT_MEMO,
                CRT_DATETIME = prodUnitViewModel.CRT_DATETIME,
                CRT_USER_ID = prodUnitViewModel.CRT_USER_ID,
                MOD_DATETIME = prodUnitViewModel.MOD_DATETIME,
                MOD_USER_ID = prodUnitViewModel.MOD_USER_ID,
                LAST_UPDATEp = prodUnitViewModel.LAST_UPDATEp,
                STATUS = prodUnitViewModel.STATUS
            };
            data.Data = await _prodUnitProvider.AddProdUnit(produnit);
            return data;
        }
        /// <summary>
        /// 删除主订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DelProdUnit")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelProdUnit(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _prodUnitProvider.DelProdUnit(id)
            };

            return data;
        }

        /// <summary>
        /// 更新主订单
        /// </summary>
        /// <param name="id"></param>
        /// <param name="prodUnitViewModel"></param>
        /// <returns></returns>
        [Route("UpdateProdUnit")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> UpdateProdUnit(int id, ProdUnitViewModel prodUnitViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var order = await _prodUnitProvider.ProdUnit(id);

            order.Id = prodUnitViewModel.Id;
            order.UNIT_ID = prodUnitViewModel.UNIT_ID;
            order.UNIT_NAME = prodUnitViewModel.UNIT_NAME;
            order.UNIT_MEMO = prodUnitViewModel.UNIT_MEMO;
            order.CRT_DATETIME = prodUnitViewModel.CRT_DATETIME;
            order.CRT_USER_ID = prodUnitViewModel.CRT_USER_ID;
            order.MOD_DATETIME = prodUnitViewModel.MOD_DATETIME;
            order.MOD_USER_ID = prodUnitViewModel.MOD_USER_ID;
            order.LAST_UPDATEp = prodUnitViewModel.LAST_UPDATEp;
            order.STATUS = prodUnitViewModel.STATUS;

            data.Data = await _prodUnitProvider.UpdateProdUnit(order);

            return data;
        }

        /// <summary>
        /// 查询单个主订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("ProdUnit")]
        [HttpGet]
        public async Task<ProdUnitEntity> ProdUnit(int id)
        {
            return await _prodUnitProvider.ProdUnit(id);
        }

        /// <summary>
        /// 查询主订单清单
        /// </summary>
        /// <returns></returns>
        [Route("ProdUnitList")]
        [HttpGet]
        public async Task<IEnumerable<ProdUnitEntity>> ProdUnitList()
        {
            var list = await _prodUnitProvider.ProdUnitList();

            list = list.OrderByDescending(x => x.Id).ToList();

            return list;

        }

    }
}
