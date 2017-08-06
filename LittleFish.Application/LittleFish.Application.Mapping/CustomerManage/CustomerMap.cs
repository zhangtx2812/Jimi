using LittleFish.Application.Entity.CustomerManage;
using System.Data.Entity.ModelConfiguration;

namespace LittleFish.Application.Mapping.CustomerManage
{
    /// <summary>
    /// �� ��
    /// Copyright (c) 2013-2016 С��Ƽ����޹�˾
    /// �� ����С���
    /// �� �ڣ�2016-03-14 09:47
    /// �� �����ͻ���Ϣ
    /// </summary>
    public class CustomerMap : EntityTypeConfiguration<CustomerEntity>
    {
        public CustomerMap()
        {
            #region ��������
            //��
            this.ToTable("Client_Customer");
            //����
            this.HasKey(t => t.CustomerId);
            #endregion

            #region ���ù�ϵ
            #endregion
        }
    }
}