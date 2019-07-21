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
    public class COMPONENT00ApiController:ControllerBase
    {
        private readonly COMPONENT00Provider _cOMPONENT00Provider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<COMPONENT00ApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public COMPONENT00ApiController(COMPONENT00Provider cOMPONENT00Provider, LoginLogProvider loginLogProvider, IStringLocalizer<COMPONENT00ApiController> localizer, IOptions<TunnelConfig> config)
        {
            _cOMPONENT00Provider = cOMPONENT00Provider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 批量新增配方
        /// </summary>
        /// <param name="cOMPONENT00ViewModels"></param>
        /// <returns></returns>
        [Route("AddCOMPONENT00s")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddCOMPONENT00s(List<COMPONENT00ViewModel> cOMPONENT00ViewModels)
        {
            var data = new ResponseViewModel<bool>();
            var dataList = new List<COMPONENT00Entity>();
            foreach (COMPONENT00ViewModel cOMPONENT00ViewModel in cOMPONENT00ViewModels)
            {
                dataList.Add(new COMPONENT00Entity
                {
                     Id= cOMPONENT00ViewModel.Id,
                     COM_ID = cOMPONENT00ViewModel.COM_ID,
                     PROD_ID = cOMPONENT00ViewModel.PROD_ID,
                     Num = cOMPONENT00ViewModel.Num,
                     WEIGHT = cOMPONENT00ViewModel.WEIGHT,
                     DefaultCOM = cOMPONENT00ViewModel.DefaultCOM,
                     QUAN1 = cOMPONENT00ViewModel.QUAN1,
                     QUAN2 = cOMPONENT00ViewModel.QUAN2,
                     DefQuan = cOMPONENT00ViewModel.DefQuan,
                     BOM_Cost = cOMPONENT00ViewModel.BOM_Cost,
                     ExpDateTime = cOMPONENT00ViewModel.ExpDateTime,
                     CRT_DATETIME = cOMPONENT00ViewModel.CRT_DATETIME,
                     CRT_USER_ID = cOMPONENT00ViewModel.CRT_USER_ID,
                     MOD_DATETIME = cOMPONENT00ViewModel.MOD_DATETIME,
                     MOD_USER_ID = cOMPONENT00ViewModel.MOD_USER_ID,
                     LAST_UPDATE = cOMPONENT00ViewModel.LAST_UPDATE
                });
            }
            data.Data = await _cOMPONENT00Provider.AddCOMPONENT00s(dataList);
            return data;
        }
        /// <summary>
        /// 删除配方
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DelCOMPONENT00")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelCOMPONENT00(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _cOMPONENT00Provider.DelCOMPONENT00(id)
            };

            return data;
        }

        /// <summary>
        /// 更新配方
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cOMPONENT00ViewModel"></param>
        /// <returns></returns>
        [Route("COMPONENT00")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> COMPONENT00(int id, COMPONENT00ViewModel cOMPONENT00ViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var entityData = await _cOMPONENT00Provider.COMPONENT00(id);

            entityData.Id = cOMPONENT00ViewModel.Id;
            entityData.COM_ID = cOMPONENT00ViewModel.COM_ID;
            entityData.PROD_ID = cOMPONENT00ViewModel.PROD_ID;
            entityData.Num = cOMPONENT00ViewModel.Num;
            entityData.WEIGHT = cOMPONENT00ViewModel.WEIGHT;
            entityData.DefaultCOM = cOMPONENT00ViewModel.DefaultCOM;
            entityData.QUAN1 = cOMPONENT00ViewModel.QUAN1;
            entityData.QUAN2 = cOMPONENT00ViewModel.QUAN2;
            entityData.DefQuan = cOMPONENT00ViewModel.DefQuan;
            entityData.BOM_Cost = cOMPONENT00ViewModel.BOM_Cost;
            entityData.ExpDateTime = cOMPONENT00ViewModel.ExpDateTime;
            entityData.CRT_DATETIME = cOMPONENT00ViewModel.CRT_DATETIME;
            entityData.CRT_USER_ID = cOMPONENT00ViewModel.CRT_USER_ID;
            entityData.MOD_DATETIME = cOMPONENT00ViewModel.MOD_DATETIME;
            entityData.MOD_USER_ID = cOMPONENT00ViewModel.MOD_USER_ID;
            entityData.LAST_UPDATE = cOMPONENT00ViewModel.LAST_UPDATE;

            data.Data = await _cOMPONENT00Provider.UpdateCOMPONENT00(entityData);

            return data;
        }

        /// <summary>
        /// 查询单个配方
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("COMPONENT00")]
        [HttpGet]
        public async Task<COMPONENT00Entity> COMPONENT00(int id)
        {
            return await _cOMPONENT00Provider.COMPONENT00(id);
        }

        /// <summary>
        /// 查询配方
        /// </summary>
        /// <returns></returns>
        [Route("COMPONENT00List")]
        [HttpGet]
        public async Task<IEnumerable<COMPONENT00Entity>> COMPONENT00List()
        {
            var list = await _cOMPONENT00Provider.COMPONENT00List();

            list = list.OrderByDescending(x => x.Id).ToList();

            return list;

        }
    }
}
