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
    public class STOCK00ApiController : ControllerBase
    {
        private readonly STOCK00Provider _sTOCK00Provider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<STOCK00ApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public STOCK00ApiController(STOCK00Provider sTOCK00Provider, LoginLogProvider loginLogProvider, IStringLocalizer<STOCK00ApiController> localizer, IOptions<TunnelConfig> config)
        {
            _sTOCK00Provider = sTOCK00Provider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 批量新增仓库
        /// </summary>
        /// <param name="sTOCK00ViewModels"></param>
        /// <returns></returns>
        [Route("AddSTOCK00s")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddSTOCK00s(List<STOCK00ViewModel> sTOCK00ViewModels)
        {
            var data = new ResponseViewModel<bool>();
            var dataList = new List<STOCK00Entity>();
            foreach (STOCK00ViewModel sTOCK00ViewModel in sTOCK00ViewModels)
            {
                dataList.Add(new STOCK00Entity
                {
                   Id= sTOCK00ViewModel.Id,
                   SHOP_ID= sTOCK00ViewModel.SHOP_ID,
                   STOCK_ID= sTOCK00ViewModel.STOCK_ID,
                   STOCK_NAME= sTOCK00ViewModel.STOCK_NAME,
                   IsDefBill= sTOCK00ViewModel.IsDefBill,
                   IsBool= sTOCK00ViewModel.IsBool,
                   Memo= sTOCK00ViewModel.Memo,
                   CRT_DATETIME= sTOCK00ViewModel.CRT_DATETIME,
                   CRT_USER_ID= sTOCK00ViewModel.CRT_USER_ID,
                   MOD_DATETIME= sTOCK00ViewModel.MOD_DATETIME,
                   MOD_USER_ID= sTOCK00ViewModel.MOD_USER_ID,
                   LAST_UPDATE= sTOCK00ViewModel.LAST_UPDATE,
                   Stock_Kind= sTOCK00ViewModel.Stock_Kind
                });
            }
            data.Data = await _sTOCK00Provider.AddSTOCK00s(dataList);
            return data;
        }
        /// <summary>
        /// 删除仓库
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DelSTOCK00")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelSTOCK00(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _sTOCK00Provider.DelSTOCK00(id)
            };

            return data;
        }

        /// <summary>
        /// 更新仓库
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sTOCK00ViewModel"></param>
        /// <returns></returns>
        [Route("UpdateSTOCK00")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> UpdateSTOCK00(int id, STOCK00ViewModel sTOCK00ViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var entityData = await _sTOCK00Provider.STOCK00(id);

            entityData.Id = sTOCK00ViewModel.Id;
            entityData.SHOP_ID = sTOCK00ViewModel.SHOP_ID;
            entityData.STOCK_ID = sTOCK00ViewModel.STOCK_ID;
            entityData.STOCK_NAME = sTOCK00ViewModel.STOCK_NAME;
            entityData.IsDefBill = sTOCK00ViewModel.IsDefBill;
            entityData.IsBool = sTOCK00ViewModel.IsBool;
            entityData.Memo = sTOCK00ViewModel.Memo;
            entityData.CRT_DATETIME = sTOCK00ViewModel.CRT_DATETIME;
            entityData.CRT_USER_ID = sTOCK00ViewModel.CRT_USER_ID;
            entityData.MOD_DATETIME = sTOCK00ViewModel.MOD_DATETIME;
            entityData.MOD_USER_ID = sTOCK00ViewModel.MOD_USER_ID;
            entityData.LAST_UPDATE = sTOCK00ViewModel.LAST_UPDATE;
            entityData.Stock_Kind = sTOCK00ViewModel.Stock_Kind;

            data.Data = await _sTOCK00Provider.UpdateSTOCK00(entityData);

            return data;
        }

        /// <summary>
        /// 查询单个仓库
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("STOCK00")]
        [HttpGet]
        public async Task<STOCK00Entity> STOCK00(int id)
        {
            return await _sTOCK00Provider.STOCK00(id);
        }

        /// <summary>
        /// 查询仓库
        /// </summary>
        /// <returns></returns>
        [Route("STOCK00List")]
        [HttpGet]
        public async Task<IEnumerable<STOCK00Entity>> STOCK00List()
        {
            var list = await _sTOCK00Provider.STOCK00List();

            list = list.OrderByDescending(x => x.Id).ToList();

            return list;

        }
    }
}
