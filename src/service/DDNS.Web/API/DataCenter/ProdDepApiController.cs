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
    public class ProdDepApiController : ControllerBase
    {
        private readonly ProdDepProvider _prodDepProvider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<ProdDepApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public ProdDepApiController(ProdDepProvider prodDepProvider, LoginLogProvider loginLogProvider, IStringLocalizer<ProdDepApiController> localizer, IOptions<TunnelConfig> config)
        {
            _prodDepProvider = prodDepProvider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 新增商品种类
        /// </summary>
        /// <param name="prodDepViewModel"></param>
        /// <returns></returns>
        [Route("AddProdDep")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddProdDep(ProdDepViewModel prodDepViewModel)
        {
            var data = new ResponseViewModel<bool>();
            var produnit = new ProdDepEntity
            {
                Id = prodDepViewModel.Id,
                DEP_NAME = prodDepViewModel.DEP_NAME,
                ENABLE = prodDepViewModel.ENABLE,
                KIND_ID = prodDepViewModel.KIND_ID,
                IsBool1 = prodDepViewModel.IsBool1,
                IsBool2 = prodDepViewModel.IsBool2,
                IsBool3 = prodDepViewModel.IsBool3,
                DEP_MEMO = prodDepViewModel.DEP_MEMO,
                CRT_DATETIME = prodDepViewModel.CRT_DATETIME,
                CRT_USER_ID = prodDepViewModel.CRT_USER_ID,
                MODE_DATETIME= prodDepViewModel.MODE_DATETIME,
                MODE_USER_ID = prodDepViewModel.MODE_USER_ID,
                LAST_UPDATE = prodDepViewModel.LAST_UPDATE,
                STATUS = prodDepViewModel.STATUS
            };
            data.Data = await _prodDepProvider.AddProdDep(produnit);
            return data;
        }
        /// <summary>
        /// 删除中类
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DelProdDep")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelProdDep(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _prodDepProvider.DelProdDep(id)
            };

            return data;
        }

        /// <summary>
        /// 更新中类
        /// </summary>
        /// <param name="id"></param>
        /// <param name="prodDepViewModel"></param>
        /// <returns></returns>
        [Route("UpdateProdDep")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> UpdateProdDep(int id, ProdDepViewModel prodDepViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var proddep = await _prodDepProvider.ProdDep(id);

            proddep.Id = prodDepViewModel.Id;
            proddep.DEP_NAME = prodDepViewModel.DEP_NAME;
            proddep.ENABLE = prodDepViewModel.ENABLE;
            proddep.KIND_ID = prodDepViewModel.KIND_ID;
            proddep.IsBool1 = prodDepViewModel.IsBool1;
            proddep.IsBool2 = prodDepViewModel.IsBool2;
            proddep.IsBool3 = prodDepViewModel.IsBool3;
            proddep.DEP_MEMO = prodDepViewModel.DEP_MEMO;
            proddep.CRT_DATETIME = prodDepViewModel.CRT_DATETIME;
            proddep.CRT_USER_ID = prodDepViewModel.CRT_USER_ID;
            proddep.MODE_DATETIME = prodDepViewModel.MODE_DATETIME;
            proddep.MODE_USER_ID = prodDepViewModel.MODE_USER_ID;
            proddep.LAST_UPDATE = prodDepViewModel.LAST_UPDATE;
            proddep.STATUS = prodDepViewModel.STATUS;

            data.Data = await _prodDepProvider.UpdateProdDep(proddep);

            return data;
        }

        /// <summary>
        /// 查询单个中类
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("ProdDep")]
        [HttpGet]
        public async Task<ProdDepEntity> ProdDep(int id)
        {
            return await _prodDepProvider.ProdDep(id);
        }

        /// <summary>
        /// 查询主订单清单
        /// </summary>
        /// <returns></returns>
        [Route("ProdDepList")]
        [HttpGet]
        public async Task<IEnumerable<ProdDepEntity>> ProdDepList()
        {
            var list = await _prodDepProvider.ProdDepList();

            list = list.OrderByDescending(x => x.Id).ToList();

            return list;

        }
    }
}
