﻿using LittleFish.Application.Entity.CustomerManage;
using System.Data.Entity.ModelConfiguration;

namespace LittleFish.Application.Mapping.CustomerManage
{
    /// <summary>
    /// 版 本
    /// Copyright (c) 2013-2016 小鱼科技有限公司
    /// 创 建：小鱼儿
    /// 日 期：2016-03-16 13:54
    /// 描 述：订单明细
    /// </summary>
    public class OrderEntryMap : EntityTypeConfiguration<OrderEntryEntity>
    {
        public OrderEntryMap()
        {
            #region 表、主键
            //表
            this.ToTable("Client_OrderEntry");
            //主键
            this.HasKey(t => t.OrderEntryId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}