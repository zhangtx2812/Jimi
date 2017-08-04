﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleFish.Util.WeChat.Model.Request
{
    public class DepartmentList : OperationRequestBase<DepartmentListResult,HttpPostRequest>
    {
        protected override string Url()
        {
            return "https://qyapi.weixin.qq.com/cgi-bin/department/list?access_token=ACCESS_TOKEN";
        }
    }
}
