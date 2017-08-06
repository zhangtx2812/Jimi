using LittleFish.Application.Entity.PublicInfoManage;
using System.Data.Entity.ModelConfiguration;

namespace LittleFish.Application.Mapping.PublicInfoManage
{
    /// <summary>
    /// 版 本 6.1
    /// Copyright (c) 2013-2016 小鱼科技有限公司
    /// 创建人：小鱼儿
    /// 日 期：2015.12.8 11:31
    /// 描 述：邮件收件人
    /// </summary>
    public class EmailAddresseeMap : EntityTypeConfiguration<EmailAddresseeEntity>
    {
        public EmailAddresseeMap()
        {
            #region 表、主键
            //表
            this.ToTable("Email_Addressee");
            //主键
            this.HasKey(t => t.AddresseeId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
