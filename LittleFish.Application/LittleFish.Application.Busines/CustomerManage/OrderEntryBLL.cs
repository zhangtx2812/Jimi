﻿using LittleFish.Application.Entity.CustomerManage;
using LittleFish.Application.IService.CustomerManage;
using LittleFish.Application.Service.CustomerManage;
using LittleFish.Util.WebControl;
using System.Collections.Generic;
using System;

namespace LittleFish.Application.Busines.CustomerManage
{
    /// <summary>
    /// 版 本 6.1
    /// Copyright (c) 2013-2016 小鱼科技有限公司
    /// 创 建：小鱼儿
    /// 日 期：2016-03-16 13:54
    /// 描 述：订单明细
    /// </summary>
    public class OrderEntryBLL
    {
        private IOrderEntryService service = new OrderEntryService();

        #region 获取数据
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="orderId">订单主键</param>
        /// <returns>返回列表</returns>
        public IEnumerable<OrderEntryEntity> GetList(string orderId)
        {
            return service.GetList(orderId);
        }
        #endregion
    }
}