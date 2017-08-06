﻿using LittleFish.Application.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace LittleFish.Application.Mapping.SystemManage
{
    /// <summary>
    /// 版 本 6.1
    /// Copyright (c) 2013-2016 小鱼科技有限公司
    /// 创建人：小鱼儿
    /// 日 期：2015.11.17 9:56
    /// 描 述：数据字典明细
    /// </summary>
    public class DataItemDetailMap : EntityTypeConfiguration<DataItemDetailEntity>
    {
        public DataItemDetailMap()
        {
            #region 表、主键
            //表
            this.ToTable("Base_DataItemDetail");
            //主键
            this.HasKey(t => t.ItemDetailId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
