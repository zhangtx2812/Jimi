﻿using LittleFish.Application.Entity.AuthorizeManage;
using System.Data.Entity.ModelConfiguration;

namespace LittleFish.Application.Mapping.AuthorizeManage
{
    /// <summary>
    /// 版 本 6.1
    /// Copyright (c) 2013-2016 小鱼科技有限公司
    /// 创建人：小鱼儿
    /// 日 期：2015.11.20 13:32
    /// 描 述：过滤IP
    /// </summary>
    public class FilterTimeMap : EntityTypeConfiguration<FilterTimeEntity>
    {
        public FilterTimeMap()
        {
            #region 表、主键
            //表
            this.ToTable("Base_FilterTime");
            //主键
            this.HasKey(t => t.FilterTimeId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
