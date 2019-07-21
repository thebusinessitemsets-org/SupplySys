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
    public class COMPONENT01ApiController : ControllerBase
    {
        private readonly COMPONENT01Provider _cOMPONENT01Provider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<COMPONENT01ApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public COMPONENT01ApiController(COMPONENT01Provider cOMPONENT01Provider, LoginLogProvider loginLogProvider, IStringLocalizer<COMPONENT01ApiController> localizer, IOptions<TunnelConfig> config)
        {
            _cOMPONENT01Provider = cOMPONENT01Provider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 批量新增配方明细
        /// </summary>
        /// <param name="cOMPONENT01ViewModels"></param>
        /// <returns></returns>
        [Route("AddCOMPONENT01s")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddCOMPONENT01s(List<COMPONENT01ViewModel> cOMPONENT01ViewModels)
        {
            var data = new ResponseViewModel<bool>();
            var dataList = new List<COMPONENT01Entity>();
            foreach (COMPONENT01ViewModel cOMPONENT01ViewModel in cOMPONENT01ViewModels)
            {
                dataList.Add(new COMPONENT01Entity
                {
                    Id= cOMPONENT01ViewModel.Id,
                    COM_ID = cOMPONENT01ViewModel.COM_ID,
                    DETAIL_ID = cOMPONENT01ViewModel.DETAIL_ID,
                    PROD_ID = cOMPONENT01ViewModel.PROD_ID,
                    QUANTITY = cOMPONENT01ViewModel.QUANTITY,
                    LQUANTITY = cOMPONENT01ViewModel.LQUANTITY,
                    New_PROD_ID = cOMPONENT01ViewModel.New_PROD_ID,
                    IsScales = cOMPONENT01ViewModel.IsScales,
                    PrtTag = cOMPONENT01ViewModel.PrtTag,
                    IsFlag = cOMPONENT01ViewModel.IsFlag,
                    Meno = cOMPONENT01ViewModel.Meno,
                    CRT_DATETIME = cOMPONENT01ViewModel.CRT_DATETIME,
                    CRT_USER_ID = cOMPONENT01ViewModel.CRT_USER_ID,
                    MOD_DATETIME = cOMPONENT01ViewModel.MOD_DATETIME,
                    MODE_USER_ID = cOMPONENT01ViewModel.MODE_USER_ID,
                    LAST_UPDATE = cOMPONENT01ViewModel.LAST_UPDATE
                });
            }
            data.Data = await _cOMPONENT01Provider.AddCOMPONENT01s(dataList);
            return data;
        }
        /// <summary>
        /// 删除配方明细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DelCOMPONENT01")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelCOMPONENT01(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _cOMPONENT01Provider.DelCOMPONENT01(id)
            };

            return data;
        }

        /// <summary>
        /// 更新配方明细
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cOMPONENT01ViewModel"></param>
        /// <returns></returns>
        [Route("COMPONENT01")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> COMPONENT01(int id, COMPONENT01ViewModel cOMPONENT01ViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var entityData = await _cOMPONENT01Provider.COMPONENT01(id);

            entityData.Id = cOMPONENT01ViewModel.Id;
            entityData.COM_ID = cOMPONENT01ViewModel.COM_ID;
            entityData.DETAIL_ID = cOMPONENT01ViewModel.DETAIL_ID;
            entityData.PROD_ID = cOMPONENT01ViewModel.PROD_ID;
            entityData.QUANTITY = cOMPONENT01ViewModel.QUANTITY;
            entityData.LQUANTITY = cOMPONENT01ViewModel.LQUANTITY;
            entityData.New_PROD_ID = cOMPONENT01ViewModel.New_PROD_ID;
            entityData.IsScales = cOMPONENT01ViewModel.IsScales;
            entityData.PrtTag = cOMPONENT01ViewModel.PrtTag;
            entityData.IsFlag = cOMPONENT01ViewModel.IsFlag;
            entityData.Meno = cOMPONENT01ViewModel.Meno;
            entityData.CRT_DATETIME = cOMPONENT01ViewModel.CRT_DATETIME;
            entityData.CRT_USER_ID = cOMPONENT01ViewModel.CRT_USER_ID;
            entityData.MOD_DATETIME = cOMPONENT01ViewModel.MOD_DATETIME;
            entityData.MODE_USER_ID = cOMPONENT01ViewModel.MODE_USER_ID;
            entityData.LAST_UPDATE = cOMPONENT01ViewModel.LAST_UPDATE;

            data.Data = await _cOMPONENT01Provider.UpdateCOMPONENT01(entityData);

            return data;
        }

        /// <summary>
        /// 查询单个配方明细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("COMPONENT01")]
        [HttpGet]
        public async Task<COMPONENT01Entity> COMPONENT01(int id)
        {
            return await _cOMPONENT01Provider.COMPONENT01(id);
        }

        /// <summary>
        /// 查询配方明细
        /// </summary>
        /// <returns></returns>
        [Route("COMPONENT01List")]
        [HttpGet]
        public async Task<IEnumerable<COMPONENT01Entity>> COMPONENT01List()
        {
            var list = await _cOMPONENT01Provider.COMPONENT01List();

            list = list.OrderByDescending(x => x.Id).ToList();

            return list;

        }
    }
}
