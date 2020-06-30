using System;
using System.Collections.Generic;
using System.Text;

namespace Senparc.Toutiao
{
    /// <summary>
    /// 平台类型
    /// </summary>
    public enum PlatformType
    {
        /// <summary>
        /// 头条小程序
        /// </summary>
        Apps
    }

    /// <summary>
    /// 公众号返回码（JSON）
    /// 应该更名为ReturnCode_MP，但为减少项目中的修改，此处依旧用ReturnCode命名
    /// </summary>
    public enum ReturnCode
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        SenparcWeixinSDK配置错误 = -99,

        系统错误 = -1,
        请求成功 = 0,
        appid错误 = 40015,
        secret错误 = 40017,
        grant_type不是client_credential = 40020,

        //获取access_token时AppSecret错误或者access_token无效 = 40001,
       
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}
