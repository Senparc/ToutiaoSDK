using System;
using System.Collections.Generic;
using System.Text;

namespace Senparc.Toutiao.Entities
{
    /// <summary>
    /// SenparcToutiaoSetting基础接口
    /// </summary>
    public interface ISenparcToutiaoSettingBase
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        string ItemKey { get; set; }
    }


    /// <summary>
    /// 小程序
    /// </summary>
    public interface ISenparcToutiaoSettingForApps : ISenparcToutiaoSettingBase
    {

        /// <summary>
        /// 小程序 AppId
        /// </summary>
        string AppId { get; set; }
        /// <summary>
        /// 小程序 AppSecret
        /// </summary>
        string AppSecret { get; set; }
    }
}
