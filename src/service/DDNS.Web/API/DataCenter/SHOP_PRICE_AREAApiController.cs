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
    public class SHOP_PRICE_AREAApiController : ControllerBase
    {
        private readonly SHOP_PRICE_AREAProvider  _sHOP_PRICE_AREAProvider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<SHOP_PRICE_AREAApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public SHOP_PRICE_AREAApiController(SHOP_PRICE_AREAProvider sHOP_PRICE_AREAProvider, LoginLogProvider loginLogProvider, IStringLocalizer<SHOP_PRICE_AREAApiController> localizer, IOptions<TunnelConfig> config)
        {
            _sHOP_PRICE_AREAProvider = sHOP_PRICE_AREAProvider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 批量新增价格区域
        /// </summary>
        /// <param name="sHOP_PRICE_AREAViewModels"></param>
        /// <returns></returns>
        [Route("AddSHOP_PRICE_AREAs")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddSHOP_PRICE_AREAs(List<SHOP_PRICE_AREAViewModel> sHOP_PRICE_AREAViewModels)
        {
            var data = new ResponseViewModel<bool>();
            var dataList = new List<SHOP_PRICE_AREAEntity>();
            foreach (SHOP_PRICE_AREAViewModel sHOP_PRICE_AREAViewModel in sHOP_PRICE_AREAViewModels)
            {
                dataList.Add(new SHOP_PRICE_AREAEntity
                {
                    Id = sHOP_PRICE_AREAViewModel.Id,
                    PRCAREA_ID = sHOP_PRICE_AREAViewModel.PRCAREA_ID,
                    PRCAREA_NAME= sHOP_PRICE_AREAViewModel.PRCAREA_NAME,
                    ENABLE= sHOP_PRICE_AREAViewModel.ENABLE,
                    PRCAREA_MEMO= sHOP_PRICE_AREAViewModel.PRCAREA_MEMO,
                    CRT_DATETIME= sHOP_PRICE_AREAViewModel.CRT_DATETIME,
                    CRT_USER_ID= sHOP_PRICE_AREAViewModel.CRT_USER_ID,
                    MOD_DATETIME= sHOP_PRICE_AREAViewModel.MOD_DATETIME,
                    MODE_USER_ID= sHOP_PRICE_AREAViewModel.MODE_USER_ID,
                    LAST_UPDATE= sHOP_PRICE_AREAViewModel.LAST_UPDATE,
                    STATUS= sHOP_PRICE_AREAViewModel.STATUS
                });
            }
            data.Data = await _sHOP_PRICE_AREAProvider.AddSHOP_PRICE_AREAs(dataList);
            return data;
        }
        /// <summary>
        /// 删除价格区域
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DelSHOP_PRICE_AREA")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelSHOP_PRICE_AREA(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _sHOP_PRICE_AREAProvider.DelSHOP_PRICE_AREA(id)
            };

            return data;
        }

        /// <summary>
        /// 更新价格区域
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sHOP_PRICE_AREAViewModel"></param>
        /// <returns></returns>
        [Route("UpdateSHOP_PRICE_AREA")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> UpdateSHOP_PRICE_AREA(int id, SHOP_PRICE_AREAViewModel sHOP_PRICE_AREAViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var entityData = await _sHOP_PRICE_AREAProvider.SHOP_PRICE_AREA(id);

            entityData.Id = sHOP_PRICE_AREAViewModel.Id;
            entityData.PRCAREA_ID = sHOP_PRICE_AREAViewModel.PRCAREA_ID;
            entityData.PRCAREA_NAME = sHOP_PRICE_AREAViewModel.PRCAREA_NAME;
            entityData.ENABLE = sHOP_PRICE_AREAViewModel.ENABLE;
            entityData.PRCAREA_MEMO = sHOP_PRICE_AREAViewModel.PRCAREA_MEMO;
            entityData.CRT_DATETIME = sHOP_PRICE_AREAViewModel.CRT_DATETIME;
            entityData.CRT_USER_ID = sHOP_PRICE_AREAViewModel.CRT_USER_ID;
            entityData.MOD_DATETIME = sHOP_PRICE_AREAViewModel.MOD_DATETIME;
            entityData.MODE_USER_ID = sHOP_PRICE_AREAViewModel.MODE_USER_ID;
            entityData.LAST_UPDATE = sHOP_PRICE_AREAViewModel.LAST_UPDATE;
            entityData.STATUS = sHOP_PRICE_AREAViewModel.STATUS;

            data.Data = await _sHOP_PRICE_AREAProvider.UpdateSHOP_PRICE_AREA(entityData);

            return data;
        }

        /// <summary>
        /// 查询单个价格区域
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("SHOP_PRICE_AREA")]
        [HttpGet]
        public async Task<SHOP_PRICE_AREAEntity> SHOP_PRICE_AREA(int id)
        {
            return await _sHOP_PRICE_AREAProvider.SHOP_PRICE_AREA(id);
        }

        /// <summary>
        /// 查询价格区域
        /// </summary>
        /// <returns></returns>
        [Route("SHOP_PRICE_AREAList")]
        [HttpGet]
        public async Task<IEnumerable<SHOP_PRICE_AREAEntity>> SHOP_PRICE_AREAList()
        {
            var list = await _sHOP_PRICE_AREAProvider.SHOP_PRICE_AREAList();

            list = list.OrderByDescending(x => x.Id).ToList();

            return list;

        }
    }
}
