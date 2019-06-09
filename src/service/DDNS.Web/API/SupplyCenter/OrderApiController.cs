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
        [Route("AddOrder")]
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
        [Route("DelOrder")]
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
        [Route("UpdateOrder")]
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

        //添加子订单

        /// <summary>
        /// 添加子订单
        /// </summary>
        /// <param name="order01Entity"></param>
        /// <returns></returns>
        [Route("AddOrder01")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> AddOrder01(Order01EditViewModel order01Entity)
        {
            var data = new ResponseViewModel<bool>();

            var order01 = new Order01Entity
            {
                //order01.Id = 
                SHOP_ID = order01Entity.SHOP_ID,
                ORDER_ID = order01Entity.ORDER_ID,
                SNo = order01Entity.SNo,
                PROD_ID = order01Entity.PROD_ID,
                QUANTITY = order01Entity.QUANTITY,
                ON_QUAN = order01Entity.ON_QUAN,
                QUAN1 = order01Entity.QUAN1,
                QUAN2 = order01Entity.QUAN2,
                COST_PRICE = order01Entity.COST_PRICE,
                STD_UNIT = order01Entity.STD_UNIT,
                STD_CONVERT = order01Entity.STD_CONVERT,
                STD_QUAN = order01Entity.STD_QUAN,
                STD_PRICE = order01Entity.STD_PRICE,
                Memo = order01Entity.Memo,
                CRT_DATETIME = order01Entity.CRT_DATETIME,
                CRT_USER_ID = order01Entity.CRT_USER_ID,
                MOD_DATETIME = order01Entity.MOD_DATETIME,
                MOD_USER_ID = order01Entity.MOD_USER_ID

            };

            data.Data = await _orderProvider.AddOrder01(order01);

            return data;
        }

        /// <summary>
        /// 删除子订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DelOrder01")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> DelOrder01(int id)
        {
            var data = new ResponseViewModel<bool>
            {
                Data = await _orderProvider.DelOrder01(id)
            };

            return data;
        }

        /// <summary>
        /// 更新子订单
        /// </summary>
        /// <param name="id"></param>
        /// <param name="orderEntity"></param>
        /// <returns></returns>
        [Route("UpdateOrder01")]
        [HttpPost]
        public async Task<ResponseViewModel<bool>> UpdateOrder01(int id, Order01EditViewModel orderEntity)
        {
            var data = new ResponseViewModel<bool>();

            var order = await _orderProvider.Order01(id);
             
            order.PROD_ID = orderEntity.PROD_ID;
            order.QUANTITY = orderEntity.QUANTITY;
            order.ON_QUAN = orderEntity.ON_QUAN;
            order.QUAN1 = orderEntity.QUAN1;
            order.QUAN2 = orderEntity.QUAN2;
            order.COST_PRICE = orderEntity.COST_PRICE;
            order.STD_UNIT = orderEntity.STD_UNIT;
            order.STD_CONVERT = orderEntity.STD_CONVERT;
            order.STD_QUAN = orderEntity.STD_QUAN;
            order.STD_PRICE = orderEntity.STD_PRICE;
            order.Memo = orderEntity.Memo;
            order.CRT_DATETIME = orderEntity.CRT_DATETIME;
            order.CRT_USER_ID = orderEntity.CRT_USER_ID;
            order.MOD_DATETIME = orderEntity.MOD_DATETIME;
            order.MOD_USER_ID = orderEntity.MOD_USER_ID;

            data.Data = await _orderProvider.UpdateOrder01(order);

            return data;
        }

        /// <summary>
        /// 查询单个子订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("Order01")]
        [HttpGet]
        public async Task<Order01Entity> Order01(int id)
        {
            return await _orderProvider.Order01(id);
        }

        /// <summary>
        /// 查询子订单清单
        [Route("Order01List")]
        [HttpGet]
        public async Task<IEnumerable<Order01Entity>> Order01List(int id)
        {
            var list = await _orderProvider.Order01List(id);

            list = list.OrderByDescending(x => x.SNo).ToList();

            return list;

        }
         
    }
}