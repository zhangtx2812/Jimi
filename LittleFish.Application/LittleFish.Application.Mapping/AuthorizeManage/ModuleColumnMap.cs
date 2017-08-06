using LittleFish.Application.Entity.AuthorizeManage;
using System.Data.Entity.ModelConfiguration;

namespace LittleFish.Application.Mapping.AuthorizeManage
{
    /// <summary>
    /// 版 本 6.1
    /// Copyright (c) 2013-2016 小鱼科技有限公司
    /// 创建人：小鱼儿
    /// 日 期：2015.10.29 15:13
    /// 描 述：系统视图
    /// </summary>
    public class ModuleColumnMap : EntityTypeConfiguration<ModuleColumnEntity>
    {
        public ModuleColumnMap()
        {
            #region 表、主键
            //表
            this.ToTable("Base_ModuleColumn");
            //主键
            this.HasKey(t => t.ModuleColumnId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
