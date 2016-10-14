﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCloud.WeApp.SDK
{
    /// <summary>
    /// 表示 SDK 配置
    /// </summary>
    [JsonObject]
    public class Configuration
    {

        /// <summary>
        /// 当前使用 SDK 服务器的主机，该主机需要外网可访问
        /// </summary>
        [JsonProperty("serverHost")]
        public string ServerHost { get; set; }

        /// <summary>
        /// 鉴权服务器服务地址
        /// </summary>
        [JsonProperty("authServerUrl")]
        public string AuthServerUrl { get; set; }

        /// <summary>
        /// 信道服务器服务地址
        /// </summary>
        [JsonProperty("tunnelServerUrl")]
        public string TunnelServerUrl { get; set; }

        /// <summary>
        /// 与信道服务器通信时签名使用的密钥
        /// </summary>
        [JsonProperty("tunnelSignatureKey")]
        public string TunnelSignatureKey { get; set; }

        /// <summary>
        /// 网络请求代理地址
        /// </summary>
        [JsonProperty("networkProxy")]
        public string NetworkProxy { get; set; }
    }
}