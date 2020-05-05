using System;
using System.Collections.Generic;
using System.Text;

namespace Senparc.Toutiao.Entities
{
    /// <summary>
    /// SenparcToutiaoSettingItem 集合
    /// </summary>
    public class SenparcToutiaoSettingItemCollection : Dictionary<string, SenparcToutiaoSettingItem>
    {
        public SenparcToutiaoSettingItemCollection() : base(StringComparer.OrdinalIgnoreCase)
        {
        }

        /// <summary>
        /// 设置或获取 SenparcToutiaoSettingItem，key 不存在时会自动创建对象，因此不需要判断 key 是否存在
        /// </summary>
        /// <param name="key">SenparcToutiaoSettingItem 标识</param>
        /// <returns></returns>
        new public SenparcToutiaoSettingItem this[string key]
        {
            get
            {
                if (!base.ContainsKey(key))
                {
                    base[key] = new SenparcToutiaoSettingItem();
                }
                return base[key];
            }
            set
            {
                base[key] = value;
                base[key].ItemKey = key;//设置标识
            }
        }
    }
}
