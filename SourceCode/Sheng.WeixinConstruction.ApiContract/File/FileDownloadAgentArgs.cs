﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheng.WeixinConstruction.ApiContract
{
    public class FileDownloadAgentArgs
    {
        /// <summary>
        /// 文件路径
        /// </summary>
        public string Url
        {
            get;
            set;
        }

        /// <summary>
        /// 同步或异步
        /// 同步则直接返回结果，异步则在下载完后把结果post到指定的URL上
        /// </summary>
        private bool _sync = true;
        public bool Sync
        {
            get { return _sync; }
            set { _sync = value; }
        }

        /// <summary>
        /// 异步时POST结果
        /// </summary>
        public string CallbackUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 附加数据，返回结果中附带上
        /// </summary>
        public string Tag
        {
            get;
            set;
        }

        public Guid Domain
        {
            get;
            set;
        }

        public string ServerRootDir
        {
            get;
            set;
        }
    }
}
