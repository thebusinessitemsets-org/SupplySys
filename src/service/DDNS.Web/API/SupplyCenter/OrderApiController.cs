using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDNS.Entity.AppSettings;
using DDNS.Entity.SupplyCenter;
using DDNS.Provider.LoginLog;
using DDNS.Provider.SupplyCenter;
using DDNS.ViewModel.Response;
using DDNS.ViewModel.SupplyCenter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;

namespace DDNS.Web.API.SupplyCenter
{
    [Route("api")]
    [ApiController]
    public class OrderApiController : ControllerBase
    {
        private readonly OrderProvider _orderProvider;
        private readonly LoginLogProvider _loginLogProvider;
        private readonly IStringLocalizer<OrderApiController> _localizer;
        private readonly TunnelConfig _tunnelConfig;

        public OrderApiController(OrderProvider orderProvider, LoginLogProvider loginLogProvider, IStringLocalizer<OrderApiController> localizer, IOptions<TunnelConfig> config)
        {
            _orderProvider = orderProvider;
            _loginLogProvider = loginLogProvider;
            _localizer = localizer;
            _tunnelConfig = config.Value;
        }

        /// <summary>
        /// 添加主订单
        /// </summary>
        /// <param name="orderEntity"></param>
        /// <returns></returns>
        [Route("Add")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddOrder(Order00EditViewModel orderEntity)
        {
            var data = new ResponseViewModel<bool>();

            var order = new OrderEntity
            {
                //Id = 
                SHOP_ID = orderEntity.SHOP_ID,
                ORDER_ID = orderEntity.ORDER_ID,
                INPUT_DATE = orderEntity.INPUT_DATE,
                ORD_USER = orderEntity.ORD_USER,
                EXPECT_DATE = orderEntity.EXPECT_DATE,
                STATUS = orderEntity.STATUS,
                ORD_TYPE = orderEntity.ORD_TYPE,
                OUT_SHOP = orderEntity.OUT_SHOP,
                EXPORTED_ID = orderEntity.EXPORTED_ID,
                EXPORTED = orderEntity.EXPORTED,
                APP_USER = orderEntity.APP_USER,
                APP_DATE = orderEntity.APP_DATE,
                Memo = orderEntity.Memo,
                LOCKED = 0,
                ORD_DEP_ID = "",
                CRT_DATETIME = DateTime.Now,
                CRT_USER_ID = "",
                //MOD_DATETIME = null,
                MOD_USER_ID = "",
                //LAST_UPDATE = null,
                Trans_STATUS = 0

            };

            data.Data = await _orderProvider.AddOrder(order);

            return data;
        }

        /// <summary>
        /// 删除主订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("Del")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelOrder(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _orderProvider.DelOrder(id)
            };

            return data;
        }

        /// <summary>
        /// 更新主订单
        /// </summary>
        /// <param name="id"></param>
        /// <param name="orderEntity"></param>
        /// <returns></returns>
        [Route("Update")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> UpdateOrder(int id,Order00EditViewModel orderEntity)
        {
            var data = new ResponseViewModel<bool>();

            var order = await _orderProvider.Order(id);

            order.SHOP_ID = orderEntity.SHOP_ID;
            order.ORDER_ID = orderEntity.ORDER_ID;
            order.INPUT_DATE = orderEntity.INPUT_DATE;
            order.ORD_USER = orderEntity.ORD_USER;
            order.EXPECT_DATE = orderEntity.EXPECT_DATE;
            order.STATUS = orderEntity.STATUS;
            order.ORD_TYPE = orderEntity.ORD_TYPE;
            order.OUT_SHOP = orderEntity.OUT_SHOP;
            order.EXPORTED_ID = orderEntity.EXPORTED_ID;
            order.EXPORTED = orderEntity.EXPORTED;
            order.APP_USER = orderEntity.APP_USER;
            order.APP_DATE = orderEntity.APP_DATE;
            order.Memo = orderEntity.Memo;

            data.Data = await _orderProvider.UpdateOrder(order);

            return data;
        }

        /// <summary>
        /// 查询单个主订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("Order")]
        [HttpGet]
        public async Task<OrderEntity> Order(int id)
        {
            return await _orderProvider.Order(id);
        }

        /// <summary>
        /// 查询主订单清单
        /// </summary>
        /// <param name="begTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        [Route("OrderList")]
        [HttpGet]
        public async Task<IEnumerable<OrderEntity>> OrderList(DateTime begTime, DateTime endTime)
        {
            var list = await _orderProvider.OrderList(begTime,endTime);

            list = list.OrderByDescending(x => x.EXPECT_DATE).ToList();

            return list;

        }


    }
}