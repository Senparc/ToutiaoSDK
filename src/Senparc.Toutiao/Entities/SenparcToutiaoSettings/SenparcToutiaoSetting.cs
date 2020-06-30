using System;
using System.Collections.Generic;
using System.Text;

namespace Senparc.Toutiao.Entities
{
    public class SenparcToutiaoSetting: SenparcToutiaoSettingItem//继承 SenparcToutiaoSettingItem 是为了可以得到一组默认的参数，方便访问
    {
        #region 头条全局

        /// <summary>
        /// 是否处于 Debug 状态（仅限头条范围）
        /// </summary>
        public bool IsDebug { get; set; }

        #endregion


        /// <summary>
        /// 系统中所有头条设置的参数，默认已经添加一个 Key 为“Default”的对象
        /// </summary>
        public SenparcToutiaoSettingItemCollection Items { get; set; }

        /// <summary>
        /// 从 Items 中获取对应键的参数
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public SenparcToutiaoSettingItem this[string key]
        {
            get
            {
                return Items[key];
            }
            set
            {
                Items[key] = value;
            }
        }

        public ISenparcToutiaoSettingForApps AppsSetting => this;


        /// <summary>
        /// SenparcToutiaoSetting 构造函数
        /// </summary>
        public SenparcToutiaoSetting() : this(false)
        { }

        /// <summary>
        /// SenparcToutiaoSetting 构造函数
        /// </summary>
        /// <param name="isDebug">是否开启 Debug 模式</param>
        /// <param name="isRoot">是否是根节点，如果是，将创建下级 Items 节点</param>
        public SenparcToutiaoSetting(bool isDebug)
        {
            IsDebug = isDebug;

            Items = new SenparcToutiaoSettingItemCollection();
            Items["Default"] = this;//储存第一个默认参数
        }
    }
}
