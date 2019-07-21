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
    public class PROD_CateApiController: ControllerBase
    {
        private readonly PROD_CateProvider _pROD_CateProvider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<PROD_CateApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public PROD_CateApiController(PROD_CateProvider pROD_CateProvider, LoginLogProvider loginLogProvider, IStringLocalizer<PROD_CateApiController> localizer, IOptions<TunnelConfig> config)
        {
            _pROD_CateProvider = pROD_CateProvider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 新增商品小类
        /// </summary>
        /// <param name="pROD_CateViewModel"></param>
        /// <returns></returns>
        [Route("AddPROD_Cate")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddPROD_Cate(PROD_CateViewModel pROD_CateViewModel)
        {
            var data = new ResponseViewModel<bool>();
            var prodcate = new PROD_CateEntity
            {
                Id = pROD_CateViewModel.Id,
                CATE_NAME = pROD_CateViewModel.CATE_NAME,
                ENABLE = pROD_CateViewModel.ENABLE,
                CATE_ID = pROD_CateViewModel.CATE_ID,
                IsBool1 = pROD_CateViewModel.IsBool1,
                IsBool2 = pROD_CateViewModel.IsBool2,
                IsBool3 = pROD_CateViewModel.IsBool3,
                CATE_MEMO = pROD_CateViewModel.CATE_MEMO,
                CRT_DATETIME = pROD_CateViewModel.CRT_DATETIME,
                CRT_USER_ID = pROD_CateViewModel.CRT_USER_ID,
                MODE_DATETIME = pROD_CateViewModel.MODE_DATETIME,
                MODE_USER_ID = pROD_CateViewModel.MODE_USER_ID,
                LAST_UPDATE = pROD_CateViewModel.LAST_UPDATE,
                STATUS = pROD_CateViewModel.STATUS
            };
            data.Data = await _pROD_CateProvider.AddPROD_Cate(prodcate);
            return data;
        }
        /// <summary>
        /// 批量新增小类
        /// </summary>
        /// <param name="pROD_CateViewModels"></param>
        /// <returns></returns>
        [Route("AddPROD_Cates")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddPROD_Cates(List<PROD_CateViewModel> pROD_CateViewModels)
        {
            var data = new ResponseViewModel<bool>();
            var prodcate = new List<PROD_CateEntity>();
            foreach (PROD_CateViewModel pROD_CateViewModel in pROD_CateViewModels)
            {
                prodcate.Add(new PROD_CateEntity
                {
                    Id = pROD_CateViewModel.Id,
                    CATE_NAME = pROD_CateViewModel.CATE_NAME,
                    ENABLE = pROD_CateViewModel.ENABLE,
                    CATE_ID = pROD_CateViewModel.CATE_ID,
                    IsBool1 = pROD_CateViewModel.IsBool1,
                    IsBool2 = pROD_CateViewModel.IsBool2,
                    IsBool3 = pROD_CateViewModel.IsBool3,
                    CATE_MEMO = pROD_CateViewModel.CATE_MEMO,
                    CRT_DATETIME = pROD_CateViewModel.CRT_DATETIME,
                    CRT_USER_ID = pROD_CateViewModel.CRT_USER_ID,
                    MODE_DATETIME = pROD_CateViewModel.MODE_DATETIME,
                    MODE_USER_ID = pROD_CateViewModel.MODE_USER_ID,
                    LAST_UPDATE = pROD_CateViewModel.LAST_UPDATE,
                    STATUS = pROD_CateViewModel.STATUS
                });
            }
            data.Data = await _pROD_CateProvider.AddPROD_Cates(prodcate);
            return data;
        }
        /// <summary>
        /// 删除小类
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DelPROD_Cate")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelPROD_Cate(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _pROD_CateProvider.DelPROD_Cate(id)
            };

            return data;
        }

        /// <summary>
        /// 更新小类
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pROD_CateViewModel"></param>
        /// <returns></returns>
        [Route("UpdatePROD_Cate")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> UpdatePROD_Cate(int id, PROD_CateViewModel pROD_CateViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var prodcate = await _pROD_CateProvider.PROD_Cate(id);

            prodcate.Id = pROD_CateViewModel.Id;
            prodcate.CATE_NAME = pROD_CateViewModel.CATE_NAME;
            prodcate.ENABLE = pROD_CateViewModel.ENABLE;
            prodcate.CATE_ID = pROD_CateViewModel.CATE_ID;
            prodcate.IsBool1 = pROD_CateViewModel.IsBool1;
            prodcate.IsBool2 = pROD_CateViewModel.IsBool2;
            prodcate.IsBool3 = pROD_CateViewModel.IsBool3;
            prodcate.CATE_MEMO = pROD_CateViewModel.CATE_MEMO;
            prodcate.CRT_DATETIME = pROD_CateViewModel.CRT_DATETIME;
            prodcate.CRT_USER_ID = pROD_CateViewModel.CRT_USER_ID;
            prodcate.MODE_DATETIME = pROD_CateViewModel.MODE_DATETIME;
            prodcate.MODE_USER_ID = pROD_CateViewModel.MODE_USER_ID;
            prodcate.LAST_UPDATE = pROD_CateViewModel.LAST_UPDATE;
            prodcate.STATUS = pROD_CateViewModel.STATUS;

            data.Data = await _pROD_CateProvider.UpdatePROD_Cate(prodcate);

            return data;
        }

        /// <summary>
        /// 查询单个小类
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("PROD_Cate")]
        [HttpGet]
        public async Task<PROD_CateEntity> PROD_Cate(int id)
        {
            return await _pROD_CateProvider.PROD_Cate(id);
        }

        /// <summary>
        /// 查询大类
        /// </summary>
        /// <returns></returns>
        [Route("PROD_CateList")]
        [HttpGet]
        public async Task<IEnumerable<PROD_CateEntity>> PROD_CateList()
        {
            var list = await _pROD_CateProvider.PROD_CateList();

            list = list.OrderByDescending(x => x.Id).ToList();

            return list;

        }
    }
}
