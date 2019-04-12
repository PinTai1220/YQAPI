using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YQApi.Models
{
    /// <summary>
    /// 日志抽象工厂的基本契约
    /// </summary>
    public interface ILoggerFactory
    {
        /// <summary>
        /// 创建一个新  ILog
        /// </summary>
        /// <returns></returns>
        ILogger Create();
    }
}