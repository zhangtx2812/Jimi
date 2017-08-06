﻿using LittleFish.Application.Entity.CustomerManage;
using System.Data.Entity.ModelConfiguration;

namespace LittleFish.Application.Mapping.CustomerManage
{
    /// <summary>
    /// 版 本
    /// Copyright (c) 2013-2016 小鱼科技有限公司
    /// 创 建：小鱼儿
    /// 日 期：2016-03-19 14:25
    /// 描 述：客户联系人
    /// </summary>
    public class CustomerContactMap : EntityTypeConfiguration<CustomerContactEntity>
    {
        public CustomerContactMap()
        {
            #region 表、主键
            //表
            this.ToTable("Client_CustomerContact");
            //主键
            this.HasKey(t => t.CustomerContactId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}