﻿using LittleFish.Application.Entity.BaseManage;
using System.Data.Entity.ModelConfiguration;

namespace LittleFish.Application.Mapping.BaseManage
{
    /// <summary>
    /// 版 本 6.1
    /// Copyright (c) 2013-2016 小鱼科技有限公司
    /// 创建人：小鱼儿
    /// 日 期：2015.11.02 14:27
    /// 描 述：部门管理
    /// </summary>
    public class DepartmentMap : EntityTypeConfiguration<DepartmentEntity>
    {
        public DepartmentMap()
        {
            #region 表、主键
            //表
            this.ToTable("Base_Department");
            //主键
            this.HasKey(t => t.DepartmentId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
