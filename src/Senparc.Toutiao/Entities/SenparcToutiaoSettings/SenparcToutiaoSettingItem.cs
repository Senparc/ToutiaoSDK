using System;
using System.Collections.Generic;
using System.Text;

namespace Senparc.Toutiao.Entities
{
    public class SenparcToutiaoSettingItem: ISenparcToutiaoSettingForApps
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        public virtual string ItemKey { get; set; }

        #region 小程序

        public string AppId { get; set; }
        public string AppSecret { get; set; }

        #endregion

        #region 构造函数

        public SenparcToutiaoSettingItem()
        {
        }

        public SenparcToutiaoSettingItem(ISenparcToutiaoSettingForApps setting)
        {
            ItemKey = setting.ItemKey;

            AppId = setting.AppId;
            AppSecret = setting.AppSecret;
        }

        #endregion

    }
}
