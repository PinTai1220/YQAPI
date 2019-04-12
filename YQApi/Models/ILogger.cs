using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YQApi.Models
{
    public interface ILogger
    {
        /// <summary>
        /// 记录调试信息
        /// </summary>
        /// <param name="message">调试信息</param>
        /// <param name="args">消息参数值</param>
        void Debug(string message, params object[] args);

        /// <summary>
        /// 记录调试信息
        /// </summary>
        /// <param name="message">消息</param>
        /// <param name="exception">异常发生写入调试信息中</param>
        /// <param name="args">消息参数值</param>
        void Debug(string message, Exception exception, params object[] args);

        /// <summary>
        /// 记录调试信息
        /// </summary>
        /// <param name="item">包含要在调试中写入的信息的项</param>
        void Debug(object item);

        /// <summary>
        /// 记录致命错误
        /// </summary>
        /// <param name="message">致命错误的信息</param>
        /// <param name="args">消息的参数值</param>
        void Fatal(string message, params object[] args);

        /// <summary>
        /// 记录致命错误
        /// </summary>
        /// <param name="message">致命错误信息</param>
        /// <param name="exception">异常写入致命信息中</param>
        /// <param name="args"></param>
        void Fatal(string message, Exception exception, params object[] args);

        /// <summary>
        /// 记录信息详情
        /// </summary>
        /// <param name="message">写入详细信息</param>
        /// <param name="args">消息参数的值</param>
        void LogInfo(string message, params object[] args);

        /// <summary>
        /// 记录警告信息
        /// </summary>
        /// <param name="message">写入警告信息</param>
        /// <param name="args">消息参数的值</param>
        void LogWarning(string message, params object[] args);

        /// <summary>
        /// 记录错误信息
        /// </summary>
        /// <param name="message">写入错误信息</param>
        /// <param name="args"></param>
        void LogError(string message, params object[] args);

        /// <summary>
        /// 记录错误信息
        /// </summary>
        /// <param name="message">写入错误信息</param>
        /// <param name="exception">异常信息写入错误信息中</param>
        /// <param name="args"></param>
        void LogError(string message, Exception exception, params object[] args);
    }
}