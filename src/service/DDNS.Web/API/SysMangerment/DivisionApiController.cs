using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDNS.Entity.AppSettings;
using DDNS.Entity.SysMangerment;
using DDNS.Provider.LoginLog;
using DDNS.Provider.SysMangerment;
using DDNS.ViewModel.Response;
using DDNS.ViewModel.SysMangerment;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;

namespace DDNS.Web.API.SysMangerment
{
    [Route("api")]
    [ApiController]
    public class DivisionApiController : ControllerBase
    {
        private readonly DIVISIONProvider _dIVISIONProvider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<DivisionApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public DivisionApiController(DIVISIONProvider dIVISIONProvider, LoginLogProvider loginLogProvider, IStringLocalizer<DivisionApiController> localizer, IOptions<TunnelConfig> config)
        {
            _dIVISIONProvider = dIVISIONProvider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dIVISIONViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("addDivision")]
        public async Task<ResponseViewModel<bool>> AddDivision(DIVISIONViewModel dIVISIONViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var division = new DIVISIONEntity
            {
                DIV_ID = dIVISIONViewModel.DIV_ID,
                DIV_NAME = dIVISIONViewModel.DIV_NAME,
                DIV_TYPE = dIVISIONViewModel.DIV_TYPE,
                STOCK_ID = dIVISIONViewModel.STOCK_ID,
                DIV_MEMO = dIVISIONViewModel.DIV_MEMO,
                CRT_DATETIME = dIVISIONViewModel.CRT_DATETIME,
                CRT_USER_ID = dIVISIONViewModel.CRT_USER_ID,
                MOD_DATETIME = dIVISIONViewModel.MOD_DATETIME,
                MOD_USER_ID = dIVISIONViewModel.MOD_USER_ID,
                LAST_UPDATE = dIVISIONViewModel.LAST_UPDATE,
                STATUS = dIVISIONViewModel.STATUS

            };

            data.Data = await _dIVISIONProvider.Add(division);

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("delDivision")]
        public async Task<ResponseViewModel<bool>> DelDivision(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _dIVISIONProvider.Del(id)
            };

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dIVISIONEditViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("updateDivision")]
        public async Task<ResponseViewModel<bool>> UpdateDivision(int id, DIVISIONEditViewModel dIVISIONEditViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var division = await _dIVISIONProvider.Get(id);

            division.DIV_ID = dIVISIONEditViewModel.DIV_ID;
            division.DIV_NAME = dIVISIONEditViewModel.DIV_NAME;
            division.DIV_TYPE = dIVISIONEditViewModel.DIV_TYPE;
            division.STOCK_ID = dIVISIONEditViewModel.STOCK_ID;
            division.DIV_MEMO = dIVISIONEditViewModel.DIV_MEMO;
            division.CRT_DATETIME = dIVISIONEditViewModel.CRT_DATETIME;
            division.CRT_USER_ID = dIVISIONEditViewModel.CRT_USER_ID;
            division.MOD_DATETIME = dIVISIONEditViewModel.MOD_DATETIME;
            division.MOD_USER_ID = dIVISIONEditViewModel.MOD_USER_ID;
            division.LAST_UPDATE = dIVISIONEditViewModel.LAST_UPDATE;
            division.STATUS = dIVISIONEditViewModel.STATUS;

            data.Data = await _dIVISIONProvider.Update(division);

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetDivision")]
        public async Task<DIVISIONEntity> Get(int id)
        {
            return await _dIVISIONProvider.Get(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="divName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetDivisionList")]
        public async Task<IEnumerable<DIVISIONEntity>> Get(string divName)
        {
            var list = await _dIVISIONProvider.Get(divName);

            list = list.OrderByDescending(x => x.ID).ToList();

            return list;

        }
    }
}