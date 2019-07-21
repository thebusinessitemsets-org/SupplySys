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
    public class PRODUCT01ApiController : ControllerBase
    {
        private readonly PRODUCT01Provider _pRODUCT01Provider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<PRODUCT01ApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public PRODUCT01ApiController(PRODUCT01Provider pRODUCT01Provider, LoginLogProvider loginLogProvider, IStringLocalizer<PRODUCT01ApiController> localizer, IOptions<TunnelConfig> config)
        {
            _pRODUCT01Provider = pRODUCT01Provider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 批量新增商品明细
        /// </summary>
        /// <param name="pRODUCT01ViewModels"></param>
        /// <returns></returns>
        [Route("AddPRODUCT01s")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddPRODUCT01s(List<PRODUCT01ViewModel> pRODUCT01ViewModels)
        {
            var data = new ResponseViewModel<bool>();
            var dataList = new List<PRODUCT01Entity>();
            foreach (PRODUCT01ViewModel pRODUCT01ViewModel in pRODUCT01ViewModels)
            {
                dataList.Add(new PRODUCT01Entity
                {
                    Id= pRODUCT01ViewModel.Id,
                    PRCAREA_ID = pRODUCT01ViewModel.PRCAREA_ID,
                    SUP_ID = pRODUCT01ViewModel.SUP_ID,
                    SEND_TYPE = pRODUCT01ViewModel.SEND_TYPE,
                    TAX_TYPE = pRODUCT01ViewModel.TAX_TYPE,
                    Tax = pRODUCT01ViewModel.Tax,
                    SUP_COST = pRODUCT01ViewModel.SUP_COST,
                    SUP_COST1 = pRODUCT01ViewModel.SUP_COST1,
                    SUP_COST2 = pRODUCT01ViewModel.SUP_COST2,
                    SUP_Return = pRODUCT01ViewModel.SUP_Return,
                    SUP_Return1 = pRODUCT01ViewModel.SUP_Return1,
                    SUP_Return2 = pRODUCT01ViewModel.SUP_Return2,
                    U_Cost = pRODUCT01ViewModel.U_Cost,
                    U_Cost1 = pRODUCT01ViewModel.U_Cost1,
                    U_Cost2 = pRODUCT01ViewModel.U_Cost2,
                    U_Ret_COST = pRODUCT01ViewModel.U_Ret_COST,
                    U_Ret_COST1 = pRODUCT01ViewModel.U_Ret_COST1,
                    U_Ret_COST2 = pRODUCT01ViewModel.U_Ret_COST2,
                    T_Cost = pRODUCT01ViewModel.T_Cost,
                    T_Cost1 = pRODUCT01ViewModel.T_Cost1,
                    T_Cost2 = pRODUCT01ViewModel.T_Cost2,
                    T_Ret_Cost = pRODUCT01ViewModel.T_Ret_Cost,
                    T_Ret_Cost1 = pRODUCT01ViewModel.T_Ret_Cost1,
                    T_Ret_Cost2 = pRODUCT01ViewModel.T_Ret_Cost2,
                    COST = pRODUCT01ViewModel.COST,
                    COST1 = pRODUCT01ViewModel.COST1,
                    COST2 = pRODUCT01ViewModel.COST2,
                    ENABLE = pRODUCT01ViewModel.ENABLE,
                    VISIBLE = pRODUCT01ViewModel.VISIBLE,
                    BOM_ID = pRODUCT01ViewModel.BOM_ID,
                    CRT_DATETIME = pRODUCT01ViewModel.CRT_DATETIME,
                    CRT_USER_ID = pRODUCT01ViewModel.CRT_USER_ID,
                    MOD_DATETIME = pRODUCT01ViewModel.MOD_DATETIME,
                    MOD_USER_ID = pRODUCT01ViewModel.MOD_USER_ID,
                    LAST_UPDATE = pRODUCT01ViewModel.LAST_UPDATE,
                    STATUS = pRODUCT01ViewModel.STATUS,
                    ORDER_UNIT = pRODUCT01ViewModel.ORDER_UNIT,
                    ORDER_QUAN = pRODUCT01ViewModel.ORDER_QUAN,
                    Purchase_UNIT = pRODUCT01ViewModel.Purchase_UNIT,
                    Purchase_QUAN = pRODUCT01ViewModel.Purchase_QUAN,
                    SAFE_QUAN = pRODUCT01ViewModel.SAFE_QUAN,
                    PROD_PRICE = pRODUCT01ViewModel.PROD_PRICE
                });
            }
            data.Data = await _pRODUCT01Provider.AddPRODUCT01s(dataList);
            return data;
        }
        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DelPRODUCT01")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelPRODUCT01(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _pRODUCT01Provider.DelPRODUCT01(id)
            };

            return data;
        }

        /// <summary>
        /// 更新商品明细
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pRODUCT01ViewModel"></param>
        /// <returns></returns>
        [Route("PRODUCT01")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> PRODUCT00(int id, PRODUCT01ViewModel pRODUCT01ViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var entityData = await _pRODUCT01Provider.PRODUCT01(id);

            entityData.Id = pRODUCT01ViewModel.Id;
            entityData.PRCAREA_ID = pRODUCT01ViewModel.PRCAREA_ID;
            entityData.SUP_ID = pRODUCT01ViewModel.SUP_ID;
            entityData.SEND_TYPE = pRODUCT01ViewModel.SEND_TYPE;
            entityData.TAX_TYPE = pRODUCT01ViewModel.TAX_TYPE;
            entityData.Tax = pRODUCT01ViewModel.Tax;
            entityData.SUP_COST = pRODUCT01ViewModel.SUP_COST;
            entityData.SUP_COST1 = pRODUCT01ViewModel.SUP_COST1;
            entityData.SUP_COST2 = pRODUCT01ViewModel.SUP_COST2;
            entityData.SUP_Return = pRODUCT01ViewModel.SUP_Return;
            entityData.SUP_Return1 = pRODUCT01ViewModel.SUP_Return1;
            entityData.SUP_Return2 = pRODUCT01ViewModel.SUP_Return2;
            entityData.U_Cost = pRODUCT01ViewModel.U_Cost;
            entityData.U_Cost1 = pRODUCT01ViewModel.U_Cost1;
            entityData.U_Cost2 = pRODUCT01ViewModel.U_Cost2;
            entityData.U_Ret_COST = pRODUCT01ViewModel.U_Ret_COST;
            entityData.U_Ret_COST1 = pRODUCT01ViewModel.U_Ret_COST1;
            entityData.U_Ret_COST2 = pRODUCT01ViewModel.U_Ret_COST2;
            entityData.T_Cost = pRODUCT01ViewModel.T_Cost;
            entityData.T_Cost1 = pRODUCT01ViewModel.T_Cost1;
            entityData.T_Cost2 = pRODUCT01ViewModel.T_Cost2;
            entityData.T_Ret_Cost = pRODUCT01ViewModel.T_Ret_Cost;
            entityData.T_Ret_Cost1 = pRODUCT01ViewModel.T_Ret_Cost1;
            entityData.T_Ret_Cost2 = pRODUCT01ViewModel.T_Ret_Cost2;
            entityData.COST = pRODUCT01ViewModel.COST;
            entityData.COST1 = pRODUCT01ViewModel.COST1;
            entityData.COST2 = pRODUCT01ViewModel.COST2;
            entityData.ENABLE = pRODUCT01ViewModel.ENABLE;
            entityData.VISIBLE = pRODUCT01ViewModel.VISIBLE;
            entityData.BOM_ID = pRODUCT01ViewModel.BOM_ID;
            entityData.CRT_DATETIME = pRODUCT01ViewModel.CRT_DATETIME;
            entityData.CRT_USER_ID = pRODUCT01ViewModel.CRT_USER_ID;
            entityData.MOD_DATETIME = pRODUCT01ViewModel.MOD_DATETIME;
            entityData.MOD_USER_ID = pRODUCT01ViewModel.MOD_USER_ID;
            entityData.LAST_UPDATE = pRODUCT01ViewModel.LAST_UPDATE;
            entityData.STATUS = pRODUCT01ViewModel.STATUS;
            entityData.ORDER_UNIT = pRODUCT01ViewModel.ORDER_UNIT;
            entityData.ORDER_QUAN = pRODUCT01ViewModel.ORDER_QUAN;
            entityData.Purchase_UNIT = pRODUCT01ViewModel.Purchase_UNIT;
            entityData.Purchase_QUAN = pRODUCT01ViewModel.Purchase_QUAN;
            entityData.SAFE_QUAN = pRODUCT01ViewModel.SAFE_QUAN;
            entityData.PROD_PRICE = pRODUCT01ViewModel.PROD_PRICE;

            data.Data = await _pRODUCT01Provider.UpdatePRODUCT01(entityData);

            return data;
        }

        /// <summary>
        /// 查询单个商品明细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("PRODUCT01")]
        [HttpGet]
        public async Task<PRODUCT01Entity> PRODUCT01(int id)
        {
            return await _pRODUCT01Provider.PRODUCT01(id);
        }

        /// <summary>
        /// 查询商品明细
        /// </summary>
        /// <returns></returns>
        [Route("PRODUCT01List")]
        [HttpGet]
        public async Task<IEnumerable<PRODUCT01Entity>> PRODUCT01List()
        {
            var list = await _pRODUCT01Provider.PRODUCT01List();

            list = list.OrderByDescending(x => x.Id).ToList();

            return list;

        }
    }
}
