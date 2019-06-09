﻿using DDNS.Entity;
using DDNS.Entity.SupplyCenter;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDNS.DataModel.SupplyCenter
{
    public class OrderDataModel
    {
        private readonly DDNSDbContext _content;

        public OrderDataModel(DDNSDbContext context)
        {
            _content = context;
        }
         
        public async Task<bool> AddOrder(OrderEntity orderEntity)
        {
            await _content.Order.AddAsync(orderEntity);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelOrder(int id)
        {
            var _order = await _content.Order.FindAsync(id);
            if (_order != null)
            {
                _order.STATUS = -1;//虚拟删除
                 return await _content.SaveChangesAsync() > 0;
            }
            else
                return false;
        }

        public async Task<bool> UpdateOrder(OrderEntity orderEntity)
        {
            var _order = await _content.Order.FindAsync(orderEntity.Id);
            if (_order != null)
            {
                _order = orderEntity;

                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<OrderEntity> Order(int id)
        {
            return await _content.Order.FindAsync(id);
        }

        public async Task<IEnumerable<OrderEntity>> OrderList(DateTime begTime, DateTime endTime)
        {
            var list = await _content.Order.Where(x => x.EXPECT_DATE >= begTime && x.EXPECT_DATE <= endTime).ToListAsync();

            list = list.OrderByDescending(x => x.EXPECT_DATE).ToList();

            return list;

        }

        public async Task<bool> AddOrder01(Order01Entity orderEntity)
        {
            await _content.Order01.AddAsync(orderEntity);
            return await _content.SaveChangesAsync() > 0;
        }

        public async Task<bool> DelOrder01(int id)
        {
            var _order = await _content.Order01.FindAsync(id);
            if (_order != null)
            {
                return await _content.SaveChangesAsync() > 0;
            }
            else
                return false;
        }

        public async Task<bool> UpdateOrder01(Order01Entity orderEntity)
        {
            var _order = await _content.Order01.FindAsync(orderEntity.Id);
            if (_order != null)
            {
                _order = orderEntity;

                return await _content.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<Order01Entity> Order01(int id)
        {
            return await _content.Order01.FindAsync(id);
        }

        public async Task<IEnumerable<Order01Entity>> Order01List(int id)
        {
            var list = await _content.Order01.Where(x => x.Id == id).ToListAsync();

            list = list.OrderByDescending(x => x.SNo).ToList();

            return list;

        }




    }
}
