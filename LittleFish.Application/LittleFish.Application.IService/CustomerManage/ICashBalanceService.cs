using LittleFish.Application.Entity.CustomerManage;
using LittleFish.Data.Repository;
using LittleFish.Util.WebControl;
using System.Collections.Generic;

namespace LittleFish.Application.IService.CustomerManage
{
    /// <summary>
    /// �� �� 6.1
    /// Copyright (c) 2013-2016 С��Ƽ����޹�˾
    /// �� ����С���
    /// �� �ڣ�2016-04-28 16:48
    /// �� �����ֽ����
    /// </summary>
    public interface ICashBalanceService
    {
        #region ��ȡ����
        /// <summary>
        /// ��ȡ�б�
        /// </summary>
        /// <param name="queryJson">��ѯ����</param>
        /// <returns>�����б�</returns>
        IEnumerable<CashBalanceEntity> GetList(string queryJson);
        #endregion

        #region �ύ����
        /// <summary>
        /// �����֧���
        /// </summary>
        /// <param name="db"></param>
        /// <param name="cashBalanceEntity"></param>
        void AddBalance(IRepository db, CashBalanceEntity cashBalanceEntity);
        #endregion
    }
}
