#region Apache License Version 2.0
/*----------------------------------------------------------------

Copyright 2020 Suzhou Senparc Network Technology Co.,Ltd.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
either express or implied. See the License for the specific language governing permissions
and limitations under the License.

Detail: https://github.com/JeffreySu/WeiXinMPSDK/blob/master/license.md

----------------------------------------------------------------*/
#endregion Apache License Version 2.0

/*----------------------------------------------------------------
    Copyright (C) 2020 Senparc
    
    文件名：Config.cs
    文件功能描述：全局设置
    
    
    创建标识：Senparc - 20200505
    
----------------------------------------------------------------*/
using Senparc.Toutiao.Entities;
using System;

namespace Senparc.Toutiao
{
    public static class Config
    {
        /// <summary>
        /// <para>指定是否是Debug状态，如果是，系统会自动输出日志。</para>
        /// <para>如果 CO2NET.Config.IsDebug 为 true，则此参数也会为 true，否则以此参数为准。</para>
        /// </summary>
        public static bool IsDebug
        {
            get => CO2NET.Config.IsDebug || SenparcToutiaoSetting.IsDebug;

            set => SenparcToutiaoSetting.IsDebug = value;
        }


        /// <summary>
        /// <para>头条全局配置</para>
        /// <para>注意：在程序运行过程中修改 SenparcWeixinSetting.Items 中的头条配置值，并不能修改 Container 中的对应信息（如AppSecret），</para>
        /// <para>如果需要修改头条信息（如AppSecret）应该使用 xxContainer.Register() 修改，这里的值也会随之更新。</para>
        /// </summary>
        public static SenparcToutiaoSetting SenparcToutiaoSetting { get; set; }

        /// <summary>
        /// 请求超时设置（以毫秒为单位），默认为10秒。
        /// 说明：此处常量专为提供给方法的参数的默认值，不是方法内所有请求的默认超时时间。
        /// </summary>
        public const int TIME_OUT = CO2NET.Config.TIME_OUT;

        /// <summary>
        /// 网站根目录绝对路径
        /// </summary>
        public static string RootDictionaryPath
        {
            get => CO2NET.Config.RootDictionaryPath;
            set => CO2NET.Config.RootDictionaryPath = value;
        }

        /// <summary>
        /// 默认缓存键的第一级命名空间，默认值：DefaultCache
        /// </summary>
        public static string DefaultCacheNamespace
        {
            get => CO2NET.Config.DefaultCacheNamespace;
            set => CO2NET.Config.DefaultCacheNamespace = value;
        }

        /// <summary>
        /// 当 JsonResult 不为“成功”状态时，是否抛出异常，默认为 true
        /// </summary>
        public static bool ThrownWhenJsonResultFaild { get; set; }

        #region API地址（前缀）设置

        #region  小程序 API 的服务器地址（默认为：https://developer.toutiao.com）

        /// <summary>
        /// 小程序 API 的服务器地址（默认为：https://developer.toutiao.com）
        /// </summary>
        public static string ApiAppsHost { get; set; } = "https://developer.toutiao.com";

        #endregion

        #endregion

        /// <summary>
        /// 默认的AppId检查规则
        /// </summary>
        public static Func<string, PlatformType, bool> DefaultAppIdCheckFunc = (accessTokenOrAppId, platFormType) =>
        {
            if (platFormType == PlatformType.Apps)
            {
                /*
                 * AppId：xxx
                 * AccessToken：xxx
                 */
                return accessTokenOrAppId != null && accessTokenOrAppId.Length <= 32 /* xxx */
                ;
            }
            else
            {
                throw new Exception("未知的平台类型");
            }
        };

        static Config()
        {
            SenparcToutiaoSetting = new SenparcToutiaoSetting();//提供默认实例
            ThrownWhenJsonResultFaild = true;//默认接口返回不正确结果时抛出异常
        }
    }
}
