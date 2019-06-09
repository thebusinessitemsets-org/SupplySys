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
    public class ProdKindApiController:ControllerBase
    {
        private readonly ProdKindProvider _prodKindProvider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<ProdKindApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public ProdKindApiController(ProdKindProvider prodKindProvider, LoginLogProvider loginLogProvider, IStringLocalizer<ProdKindApiController> localizer, IOptions<TunnelConfig> config)
        {
            _prodKindProvider = prodKindProvider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 新增商品大类
        /// </summary>
        /// <param name="prodKindViewModel"></param>
        /// <returns></returns>
        [Route("AddProdKind")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddProdKind(ProdKindViewModel prodKindViewModel)
        {
            var data = new ResponseViewModel<bool>();
            var produnit = new ProdKindEntity
            {
                Id = prodKindViewModel.Id,
                KIND_NAME = prodKindViewModel.KIND_NAME,
                ENABLE = prodKindViewModel.ENABLE,
                KIND_ID = prodKindViewModel.KIND_ID,
                IsBool = prodKindViewModel.IsBool,
                KIND_MEMO = prodKindViewModel.KIND_MEMO,
                CRT_DATETIME = prodKindViewModel.CRT_DATETIME,
                CRT_USER_ID = prodKindViewModel.CRT_USER_ID,
                MODE_DATETIME = prodKindViewModel.MODE_DATETIME,
                MODE_USER_ID = prodKindViewModel.MODE_USER_ID,
                LAST_UPDATE = prodKindViewModel.LAST_UPDATE,
                STATUS = prodKindViewModel.STATUS
            };
            data.Data = await _prodKindProvider.AddProdKind(produnit);
            return data;
        }
        /// <summary>
        /// 批量新增大类
        /// </summary>
        /// <param name="prodKindViewModels"></param>
        /// <returns></returns>
        [Route("AddProdKinds")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddProdKinds(List<ProdKindViewModel> prodKindViewModels)
        {
            var data = new ResponseViewModel<bool>();
            var produnit = new List<ProdKindEntity>();
            foreach (ProdKindViewModel prodKindViewModel in prodKindViewModels)
            {
                produnit.Add(new ProdKindEntity
                {
                    Id = prodKindViewModel.Id,
                    KIND_NAME = prodKindViewModel.KIND_NAME,
                    ENABLE = prodKindViewModel.ENABLE,
                    KIND_ID = prodKindViewModel.KIND_ID,
                    IsBool = prodKindViewModel.IsBool,
                    KIND_MEMO = prodKindViewModel.KIND_MEMO,
                    CRT_DATETIME = prodKindViewModel.CRT_DATETIME,
                    CRT_USER_ID = prodKindViewModel.CRT_USER_ID,
                    MODE_DATETIME = prodKindViewModel.MODE_DATETIME,
                    MODE_USER_ID = prodKindViewModel.MODE_USER_ID,
                    LAST_UPDATE = prodKindViewModel.LAST_UPDATE,
                    STATUS = prodKindViewModel.STATUS
                });
            }
            data.Data = await _prodKindProvider.AddProdKinds(produnit);
            return data;
        }
        /// <summary>
        /// 删除大类
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DelProdKind")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelProdKind(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _prodKindProvider.DelProdKind(id)
            };

            return data;
        }

        /// <summary>
        /// 更新大类
        /// </summary>
        /// <param name="id"></param>
        /// <param name="prodKindViewModel"></param>
        /// <returns></returns>
        [Route("UpdateProdKind")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> UpdateProdKind(int id, ProdKindViewModel prodKindViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var prodKind = await _prodKindProvider.ProdKind(id);

            prodKind.Id = prodKindViewModel.Id;
            prodKind.KIND_NAME = prodKindViewModel.KIND_NAME;
            prodKind.ENABLE = prodKindViewModel.ENABLE;
            prodKind.KIND_ID = prodKindViewModel.KIND_ID;
            prodKind.IsBool = prodKindViewModel.IsBool;
            prodKind.KIND_MEMO = prodKindViewModel.KIND_MEMO;
            prodKind.CRT_DATETIME = prodKindViewModel.CRT_DATETIME;
            prodKind.CRT_USER_ID = prodKindViewModel.CRT_USER_ID;
            prodKind.MODE_DATETIME = prodKindViewModel.MODE_DATETIME;
            prodKind.MODE_USER_ID = prodKindViewModel.MODE_USER_ID;
            prodKind.LAST_UPDATE = prodKindViewModel.LAST_UPDATE;
            prodKind.STATUS = prodKindViewModel.STATUS;

            data.Data = await _prodKindProvider.UpdateProdKind(prodKind);

            return data;
        }

        /// <summary>
        /// 查询单个大类
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("ProdKind")]
        [HttpGet]
        public async Task<ProdKindEntity> ProdKind(int id)
        {
            return await _prodKindProvider.ProdKind(id);
        }

        /// <summary>
        /// 查询大类
        /// </summary>
        /// <returns></returns>
        [Route("ProdKindList")]
        [HttpGet]
        public async Task<IEnumerable<ProdKindEntity>> ProdKindList()
        {
            var list = await _prodKindProvider.ProdKindList();

            list = list.OrderByDescending(x => x.Id).ToList();

            return list;

        }
    }
}
