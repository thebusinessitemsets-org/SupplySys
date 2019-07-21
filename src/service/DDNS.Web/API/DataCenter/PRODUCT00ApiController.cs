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
    public class PRODUCT00ApiController:ControllerBase
    {
        private readonly PRODUCT00Provider _pRODUCT00Provider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<PRODUCT00ApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public PRODUCT00ApiController(PRODUCT00Provider pRODUCT00Provider, LoginLogProvider loginLogProvider, IStringLocalizer<PRODUCT00ApiController> localizer, IOptions<TunnelConfig> config)
        {
            _pRODUCT00Provider = pRODUCT00Provider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 批量新增商品
        /// </summary>
        /// <param name="pRODUCT00ViewModels"></param>
        /// <returns></returns>
        [Route("AddPRODUCT00s")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddPRODUCT00s(List<PRODUCT00ViewModel> pRODUCT00ViewModels)
        {
            var data = new ResponseViewModel<bool>();
            var dataList = new List<PRODUCT00Entity>();
            foreach (PRODUCT00ViewModel pRODUCT00ViewModel in pRODUCT00ViewModels)
            {
                dataList.Add(new PRODUCT00Entity
                {
                    Id = pRODUCT00ViewModel.Id,
                  PROD_ID = pRODUCT00ViewModel.PROD_ID,
                  PROD_NAME1 = pRODUCT00ViewModel.PROD_NAME1,
                  PROD_NAME2 = pRODUCT00ViewModel.PROD_NAME2,
                  PROD_KIND = pRODUCT00ViewModel.PROD_KIND,
                  PROD_DEP = pRODUCT00ViewModel.PROD_DEP,
                  PROD_CATE = pRODUCT00ViewModel.PROD_CATE,
                  DIV_ID = pRODUCT00ViewModel.DIV_ID,
                  PROD_TYPE = pRODUCT00ViewModel.PROD_TYPE,
                  PROD_Source = pRODUCT00ViewModel.PROD_Source,
                  INV_TYPE = pRODUCT00ViewModel.INV_TYPE,
                  STOCK_TYPE = pRODUCT00ViewModel.STOCK_TYPE,
                  BOM_TYPE = pRODUCT00ViewModel.BOM_TYPE,
                  MarginControl = pRODUCT00ViewModel.MarginControl,
                  PROD_RangTYPE = pRODUCT00ViewModel.PROD_RangTYPE,
                  PROD_iRang = pRODUCT00ViewModel.PROD_iRang,
                  SPEC = pRODUCT00ViewModel.SPEC,
                  PROD_Margin = pRODUCT00ViewModel.PROD_Margin,
                  PROD_BARCODE = pRODUCT00ViewModel.PROD_BARCODE,
                  PROD_UNIT = pRODUCT00ViewModel.PROD_UNIT,
                  PROD_UNIT1 = pRODUCT00ViewModel.PROD_UNIT1,
                  PROD_CONVERT1 = pRODUCT00ViewModel.PROD_CONVERT1,
                  PROD_UNIT2 = pRODUCT00ViewModel.PROD_UNIT2,
                  PROD_CONVERT2 = pRODUCT00ViewModel.PROD_CONVERT2,
                  Report_UNIT = pRODUCT00ViewModel.Report_UNIT,
                  IsBool1 = pRODUCT00ViewModel.IsBool1,
                  IsBool2 = pRODUCT00ViewModel.IsBool2,
                  ISBool3 = pRODUCT00ViewModel.ISBool3,
                  PROD_MEMO = pRODUCT00ViewModel.PROD_MEMO,
                  CRT_DATETIME = pRODUCT00ViewModel.CRT_DATETIME,
                  CRT_USER_ID = pRODUCT00ViewModel.CRT_USER_ID,
                  MOD_DATETIME = pRODUCT00ViewModel.MOD_DATETIME,
                  MOD_USER_ID = pRODUCT00ViewModel.MOD_USER_ID,
                  LAST_UPDATE = pRODUCT00ViewModel.LAST_UPDATE,
                  STATUS = pRODUCT00ViewModel.STATUS
                });
            }
            data.Data = await _pRODUCT00Provider.AddPRODUCT00s(dataList);
            return data;
        }
        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DelPRODUCT00")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelPRODUCT00(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _pRODUCT00Provider.DelPRODUCT00(id)
            };

            return data;
        }

        /// <summary>
        /// 更新商品
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pRODUCT00ViewModel"></param>
        /// <returns></returns>
        [Route("PRODUCT00")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> PRODUCT00(int id, PRODUCT00ViewModel pRODUCT00ViewModel)
        {
            var data = new ResponseViewModel<bool>();

            var entityData = await _pRODUCT00Provider.PRODUCT00(id);

            entityData.Id = pRODUCT00ViewModel.Id;
            entityData.PROD_ID = pRODUCT00ViewModel.PROD_ID;
            entityData.PROD_NAME1 = pRODUCT00ViewModel.PROD_NAME1;
            entityData.PROD_NAME2 = pRODUCT00ViewModel.PROD_NAME2;
            entityData.PROD_KIND = pRODUCT00ViewModel.PROD_KIND;
            entityData.PROD_DEP = pRODUCT00ViewModel.PROD_DEP;
            entityData.PROD_CATE = pRODUCT00ViewModel.PROD_CATE;
            entityData.DIV_ID = pRODUCT00ViewModel.DIV_ID;
            entityData.PROD_TYPE = pRODUCT00ViewModel.PROD_TYPE;
            entityData.PROD_Source = pRODUCT00ViewModel.PROD_Source;
            entityData.INV_TYPE = pRODUCT00ViewModel.INV_TYPE;
            entityData.STOCK_TYPE = pRODUCT00ViewModel.STOCK_TYPE;
            entityData.BOM_TYPE = pRODUCT00ViewModel.BOM_TYPE;
            entityData.MarginControl = pRODUCT00ViewModel.MarginControl;
            entityData.PROD_RangTYPE = pRODUCT00ViewModel.PROD_RangTYPE;
            entityData.PROD_iRang = pRODUCT00ViewModel.PROD_iRang;
            entityData.SPEC = pRODUCT00ViewModel.SPEC;
            entityData.PROD_Margin = pRODUCT00ViewModel.PROD_Margin;
            entityData.PROD_BARCODE = pRODUCT00ViewModel.PROD_BARCODE;
            entityData.PROD_UNIT = pRODUCT00ViewModel.PROD_UNIT;
            entityData.PROD_UNIT1 = pRODUCT00ViewModel.PROD_UNIT1;
            entityData.PROD_CONVERT1 = pRODUCT00ViewModel.PROD_CONVERT1;
            entityData.PROD_UNIT2 = pRODUCT00ViewModel.PROD_UNIT2;
            entityData.PROD_CONVERT2 = pRODUCT00ViewModel.PROD_CONVERT2;
            entityData.Report_UNIT = pRODUCT00ViewModel.Report_UNIT;
            entityData.IsBool1 = pRODUCT00ViewModel.IsBool1;
            entityData.IsBool2 = pRODUCT00ViewModel.IsBool2;
            entityData.ISBool3 = pRODUCT00ViewModel.ISBool3;
            entityData.PROD_MEMO = pRODUCT00ViewModel.PROD_MEMO;
            entityData.CRT_DATETIME = pRODUCT00ViewModel.CRT_DATETIME;
            entityData.CRT_USER_ID = pRODUCT00ViewModel.CRT_USER_ID;
            entityData.MOD_DATETIME = pRODUCT00ViewModel.MOD_DATETIME;
            entityData.MOD_USER_ID = pRODUCT00ViewModel.MOD_USER_ID;
            entityData.LAST_UPDATE = pRODUCT00ViewModel.LAST_UPDATE;
            entityData.STATUS = pRODUCT00ViewModel.STATUS;

            data.Data = await _pRODUCT00Provider.UpdatePRODUCT00(entityData);

            return data;
        }

        /// <summary>
        /// 查询单个商品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("PRODUCT00")]
        [HttpGet]
        public async Task<PRODUCT00Entity> PRODUCT00(int id)
        {
            return await _pRODUCT00Provider.PRODUCT00(id);
        }

        /// <summary>
        /// 查询商品列表
        /// </summary>
        /// <returns></returns>
        [Route("PRODUCT00List")]
        [HttpGet]
        public async Task<IEnumerable<PRODUCT00Entity>> PRODUCT00List()
        {
            var list = await _pRODUCT00Provider.PRODUCT00List();

            list = list.OrderByDescending(x => x.Id).ToList();

            return list;

        }
    }
}
