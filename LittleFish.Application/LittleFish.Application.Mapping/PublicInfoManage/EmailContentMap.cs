using LittleFish.Application.Entity.PublicInfoManage;
using System.Data.Entity.ModelConfiguration;

namespace LittleFish.Application.Mapping.PublicInfoManage
{
    /// <summary>
    /// 版 本 6.1
    /// Copyright (c) 2013-2016 小鱼科技有限公司
    /// 创建人：小鱼儿
    /// 日 期：2015.12.8 11:31
    /// 描 述：邮件内容
    /// </summary>
    public class EmailContentMap : EntityTypeConfiguration<EmailContentEntity>
    {
        public EmailContentMap()
        {
            #region 表、主键
            //表
            this.ToTable("Email_Content");
            //主键
            this.HasKey(t => t.ContentId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
