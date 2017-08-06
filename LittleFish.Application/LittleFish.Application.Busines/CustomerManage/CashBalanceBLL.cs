using LittleFish.Application.Entity.CustomerManage;
using LittleFish.Application.IService.CustomerManage;
using LittleFish.Application.Service.CustomerManage;
using LittleFish.Util.WebControl;
using System.Collections.Generic;
using System;

namespace LittleFish.Application.Busines.CustomerManage
{
    /// <summary>
    /// �� �� 6.1
    /// Copyright (c) 2013-2016 С��Ƽ����޹�˾
    /// �� ����С���
    /// �� �ڣ�2016-04-28 16:48
    /// �� �����ֽ����
    /// </summary>
    public class CashBalanceBLL
    {
        private ICashBalanceService service = new CashBalanceService();

        #region ��ȡ����
        /// <summary>
        /// ��ȡ�б�
        /// </summary>
        /// <param name="queryJson">��ѯ����</param>
        /// <returns>�����б�</returns>
        public IEnumerable<CashBalanceEntity> GetList(string queryJson)
        {
            return service.GetList(queryJson);
        }
        #endregion

        #region �ύ����
        #endregion
    }
}
