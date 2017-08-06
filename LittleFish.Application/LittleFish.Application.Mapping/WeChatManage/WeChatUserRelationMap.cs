using LittleFish.Application.Entity.WeChatManage;
using System.Data.Entity.ModelConfiguration;

namespace LittleFish.Application.Mapping.WeChatManage
{
    /// <summary>
    /// 版 本 6.1
    /// Copyright (c) 2013-2016 小鱼科技有限公司
    /// 创建人：小鱼儿
    /// 日 期：2015.12.23 11:31
    /// 描 述：企业号成员
    /// </summary>
    public class WeChatUserRelationMap : EntityTypeConfiguration<WeChatUserRelationEntity>
    {
        public WeChatUserRelationMap()
        {
            #region 表、主键
            //表
            this.ToTable("WeChat_UserRelation");
            //主键
            this.HasKey(t => t.UserRelationId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
