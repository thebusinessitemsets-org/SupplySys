using DDNS.Entity.AppSettings;
using DDNS.Entity.SupplyCenter;
using DDNS.Provider.LoginLog;
using DDNS.Provider.SupplyCenter;
using DDNS.ViewModel.Response;
using DDNS.ViewModel.SupplyCenter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDNS.Web.API.SupplyCenter
{
    [Route("api")]
    [ApiController]
    public class ColOrderApiController:ControllerBase
    {
        private readonly ColOrderProvider _colorderProvider;

        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<ColOrderApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public ColOrderApiController(ColOrderProvider colorderProvider, LoginLogProvider loginLogProvider, IStringLocalizer<ColOrderApiController> localizer, IOptions<TunnelConfig> config)
        {
            _colorderProvider = colorderProvider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 添加主汇整主订单
        /// </summary>
        /// <param name="colorderEntity"></param>
        /// <returns></returns>
        [Route("AddColOrder")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddColOrder(ColOreder00ViewModel colorderEntity)
        {
            var data = new ResponseViewModel<bool>();

            var colorder = new ColOrderEntity
            {
                SHOP_ID = colorderEntity.SHOP_ID,
                COL_ID = colorderEntity.COL_ID,
                INPUT_DATE = colorderEntity.INPUT_DATE,
                ORD_USER = colorderEntity.ORD_USER,
                EXPECT_DATE = colorderEntity.EXPECT_DATE,
                STATUS = colorderEntity.STATUS,
                PROD_TYPE = colorderEntity.PROD_TYPE,
                ORD_TYPE = colorderEntity.ORD_TYPE,
                ORD_DEP_ID = colorderEntity.ORD_DEP_ID,
                COL_BeginDate = colorderEntity.COL_BeginDate,
                COL_EndDate = colorderEntity.COL_EndDate,
                APP_USER = colorderEntity.APP_USER,
                APP_DATE = colorderEntity.APP_DATE,
                Memo = colorderEntity.Memo,
                LOCKED = colorderEntity.LOCKED,
                CRT_DATETIME = colorderEntity.CRT_DATETIME,
                CRT_USER_ID = colorderEntity.CRT_USER_ID,
                MOD_DATETIME = colorderEntity.MOD_DATETIME,
                MOD_USER_ID = colorderEntity.MOD_USER_ID,
                LAST_UPDATE = colorderEntity.LAST_UPDATE,
                Trans_STATUS = colorderEntity.Trans_STATUS

            };

            data.Data = await _colorderProvider.AddColOrder(colorder);

            return data;
        }

        /// <summary>
        /// 删除主订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DelColOrder")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelColOrder(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _colorderProvider.DelColOrder(id)
            };

            return data;
        }

        /// <summary>
        /// 更新主订单
        /// </summary>
        /// <param name="id"></param>
        /// <param name="colorderEntity"></param>
        /// <returns></returns>
        [Route("UpdateColOrder")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> UpdateColOrder(int id, Order00EditViewModel colorderEntity)
        {
            var data = new ResponseViewModel<bool>();

            var colorder = await _colorderProvider.ColOrder(id);

            colorder.SHOP_ID = colorderEntity.SHOP_ID;
            colorder.COL_ID = colorderEntity.COL_ID;
            colorder.INPUT_DATE = colorderEntity.INPUT_DATE;
            colorder.ORD_USER = colorderEntity.ORD_USER;
            colorder.EXPECT_DATE = colorderEntity.EXPECT_DATE;
            colorder.STATUS = colorderEntity.STATUS;
            colorder.PROD_TYPE = colorderEntity.PROD_TYPE;
            colorder.ORD_TYPE = colorderEntity.ORD_TYPE;
            colorder.ORD_DEP_ID = colorderEntity.ORD_DEP_ID;
            colorder.COL_BeginDate = colorderEntity.COL_BeginDate;
            colorder.COL_EndDate = colorderEntity.COL_EndDate;
            colorder.APP_USER = colorderEntity.APP_USER;
            colorder.APP_DATE = colorderEntity.APP_DATE;
            colorder.Memo = colorderEntity.Memo;
            colorder.LOCKED = colorderEntity.LOCKED;
            colorder.CRT_DATETIME = colorderEntity.CRT_DATETIME;
            colorder.CRT_USER_ID = colorderEntity.CRT_USER_ID;
            colorder.MOD_DATETIME = colorderEntity.MOD_DATETIME;
            colorder.MOD_USER_ID = colorderEntity.MOD_USER_ID;
            colorder.LAST_UPDATE = colorderEntity.LAST_UPDATE;
            colorder.Trans_STATUS = colorderEntity.Trans_STATUS;

            data.Data = await _colorderProvider.UpdateColOrder(colorder);

            return data;
        }

        /// <summary>
        /// 查询单个主订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("ColOrder")]
        [HttpGet]
        public async Task<ColOrderEntity> ColOrder(int id)
        {
            return await _colorderProvider.ColOrder(id);
        }

        /// <summary>
        /// 查询主订单清单
        /// </summary>
        /// <param name="begTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        [Route("ColOrderList")]
        [HttpGet]
        public async Task<IEnumerable<ColOrderEntity>> ColOrderList(DateTime begTime, DateTime endTime)
        {
            var list = await _colorderProvider.ColOrderList(begTime, endTime);

            list = list.OrderByDescending(x => x.CRT_DATETIME).ToList();

            return list;

        }

        //添加子订单

        /// <summary>
        /// 添加子订单
        /// </summary>
        /// <param name="colorder01Entity"></param>
        /// <returns></returns>
        [Route("AddColOrder01")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddColOrder01(ColOrder01ViewModel colorder01Entity)
        {
            var data = new ResponseViewModel<bool>();

            var colorder01 = new ColOrder01Entity
            {
                SHOP_ID = colorder01Entity.SHOP_ID,
                COL_ID = colorder01Entity.COL_ID,
                SNo = colorder01Entity.SNo,
                PROD_ID = colorder01Entity.PROD_ID,
                QUANTITY = colorder01Entity.QUANTITY,
                COST_PRICE = colorder01Entity.COST_PRICE,
                STD_UNIT = colorder01Entity.STD_UNIT,
                STD_CONVERT = colorder01Entity.STD_CONVERT,
                STD_QUAN = colorder01Entity.STD_QUAN,
                STD_PRICE = colorder01Entity.STD_PRICE

            };

            data.Data = await _colorderProvider.AddColOrder01(colorder01);

            return data;
        }

        /// <summary>
        /// 更新子订单
        /// </summary>
        /// <param name="id"></param>
        /// <param name="colorder01Entity"></param>
        /// <returns></returns>
        [Route("UpdateColOrder01")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> UpdateColOrder01(int id, ColOrder01EditViewModel colorder01Entity)
        {
            var data = new ResponseViewModel<bool>();

            var colorder01 = await _colorderProvider.ColOrder01(id);

            colorder01.SHOP_ID = colorder01Entity.SHOP_ID;
            colorder01.COL_ID = colorder01Entity.COL_ID;
            colorder01.SNo = colorder01Entity.SNo;
            colorder01.PROD_ID = colorder01Entity.PROD_ID;
            colorder01.QUANTITY = colorder01Entity.QUANTITY;
            colorder01.COST_PRICE = colorder01Entity.COST_PRICE;
            colorder01.STD_UNIT = colorder01Entity.STD_UNIT;
            colorder01.STD_CONVERT = colorder01Entity.STD_CONVERT;
            colorder01.STD_QUAN = colorder01Entity.STD_QUAN;
            colorder01.STD_PRICE = colorder01Entity.STD_PRICE;

            data.Data = await _colorderProvider.UpdateColOrder01(colorder01);

            return data;
        }

        /// <summary>
        /// 查询单个子订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("ColOrder01")]
        [HttpGet]
        public async Task<ColOrder01Entity> ColOrder01(int id)
        {
            return await _colorderProvider.ColOrder01(id);
        }

        /// <summary>
        /// 查询子订单清单
        [Route("ColOrder01List")]
        [HttpGet]
        public async Task<IEnumerable<ColOrder01Entity>> ColOrder01List(int id)
        {
            var list = await _colorderProvider.ColOrder01List(id);

            list = list.OrderByDescending(x => x.SNo).ToList();

            return list;

        }

        //添加02子订单

        /// <summary>
        /// 添加子订单
        /// </summary>
        /// <param name="colorder02Entity"></param>
        /// <returns></returns>
        [Route("AddColOrder02")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddColOrder02(ColOrder02ViewModel colorder02Entity)
        {
            var data = new ResponseViewModel<bool>();

            var colorder02 = new ColOrder02Entity
            {
                SHOP_ID = colorder02Entity.SHOP_ID,
                COL_ID = colorder02Entity.COL_ID,
                SNo = colorder02Entity.SNo,
                Import_Shop = colorder02Entity.Import_Shop,
                PROD_ID = colorder02Entity.PROD_ID,
                OUT_QUAN = colorder02Entity.OUT_QUAN,
                SUP_QUAN = colorder02Entity.SUP_QUAN,
                STD_QUAN = colorder02Entity.STD_QUAN

            };

            data.Data = await _colorderProvider.AddColOrder02(colorder02);

            return data;
        }

        /// <summary>
        /// 更新子订单2
        /// </summary>
        /// <param name="id"></param>
        /// <param name="colorder02Entity"></param>
        /// <returns></returns>
        [Route("UpdateColOrder02")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> UpdateColOrder02(int id, ColOrder02EditViewModel colorder02Entity)
        {
            var data = new ResponseViewModel<bool>();

            var colorder02 = await _colorderProvider.ColOrder02(id);

            colorder02.SHOP_ID = colorder02Entity.SHOP_ID;
            colorder02.COL_ID = colorder02Entity.COL_ID;
            colorder02.SNo = colorder02Entity.SNo;
            colorder02.Import_Shop = colorder02Entity.Import_Shop;
            colorder02.PROD_ID = colorder02Entity.PROD_ID;
            colorder02.OUT_QUAN = colorder02Entity.OUT_QUAN;
            colorder02.SUP_QUAN = colorder02Entity.SUP_QUAN;
            colorder02.STD_QUAN = colorder02Entity.STD_QUAN;

            data.Data = await _colorderProvider.UpdateColOrder02(colorder02);

            return data;
        }

        /// <summary>
        /// 查询单个子订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("ColOrder02")]
        [HttpGet]
        public async Task<ColOrder02Entity> ColOrder02(int id)
        {
            return await _colorderProvider.ColOrder02(id);
        }

        /// <summary>
        /// 查询子订单清单
        [Route("ColOrder02List")]
        [HttpGet]
        public async Task<IEnumerable<ColOrder02Entity>> ColOrder02List(int id)
        {
            var list = await _colorderProvider.ColOrder02List(id);

            list = list.OrderByDescending(x => x.SNo).ToList();

            return list;

        }

    }
}
