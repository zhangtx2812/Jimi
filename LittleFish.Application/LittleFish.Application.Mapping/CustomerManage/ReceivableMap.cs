﻿using LittleFish.Application.Entity.CustomerManage;
using System.Data.Entity.ModelConfiguration;

namespace LittleFish.Application.Mapping.CustomerManage
{
    /// <summary>
    /// 版 本
    /// Copyright (c) 2013-2016 小鱼科技有限公司
    /// 创 建：小鱼儿
    /// 日 期：2016-04-06 17:24
    /// 描 述：应收账款
    /// </summary>
    public class ReceivableMap : EntityTypeConfiguration<ReceivableEntity>
    {
        public ReceivableMap()
        {
            #region 表、主键
            //表
            this.ToTable("Client_Receivable");
            //主键
            this.HasKey(t => t.ReceivableId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}