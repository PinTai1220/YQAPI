using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Security;

namespace YQApi.Filters
{
    public class ApiSecurityFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            // 获得请求信息
            var request = actionContext.Request;

            // 获得请求的方法
            var method = request.Method.Method;

            // 私钥
            var staffId = "^***********************************$";

            string timestamp = string.Empty, nonce = string.Empty, signature = string.Empty;

            // 获得时间戳
            if (request.Headers.Contains("timestamp"))
                timestamp = request.Headers.GetValues("timestamp").FirstOrDefault();

            // 随机数
            if (request.Headers.Contains("nonce"))
                nonce = request.Headers.GetValues("nonce").FirstOrDefault();

            // 签名
            if (request.Headers.Contains("signature"))
                signature = request.Headers.GetValues("signature").FirstOrDefault();

            // 不符合规范报错
            if (string.IsNullOrEmpty(timestamp) || string.IsNullOrEmpty(nonce) || string.IsNullOrEmpty(signature))
                throw new SecurityException();

            #region 请求是否过期
            {
                double ts = 0;

                // 将字符串转换为数字格式
                bool timespanvalidate = double.TryParse(timestamp, out ts);

                // 判断当前请求是否再
                bool falg = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalMilliseconds - ts > 60 * 1000;

                if (falg || (!timespanvalidate))
                    throw new SecurityException("timeSpanValidate");
            }
            #endregion



            var data = string.Empty;
            IDictionary<string, string> sortedParams = null;

            switch (method.ToUpper())
            {
                case "POST":
                case "PUT":
                case "DELETE":
                    // Post 、Put 、Delete 方法提取参数
                    {
                        Stream stream = HttpContext.Current.Request.InputStream;
                        StreamReader streamReader = new StreamReader(stream);
                        sortedParams = new SortedDictionary<string, string>(new JsonSerializer().Deserialize<Dictionary<string, string>>(new JsonTextReader(streamReader)));
                    }
                    break;

                case "GET":
                    // Get 方法提取参数
                    {
                        IDictionary<string, string> parameters = new Dictionary<string, string>();

                        foreach (string key in HttpContext.Current.Request.QueryString)
                        {
                            if (!string.IsNullOrEmpty(key))
                            {
                                parameters.Add(key, HttpContext.Current.Request.QueryString[key]);
                            }
                        }

                        sortedParams = new SortedDictionary<string, string>(parameters);
                    }
                    break;

                default:
                    throw new SecurityException("defaultOptions");
            }

            // 排序参数拼接成约定公式。
            #region 拼接字符串
            {
                StringBuilder query = new StringBuilder();

                if (sortedParams != null)
                {
                    foreach (var sort in sortedParams.OrderBy(k => k.Key))
                    {
                        if (!string.IsNullOrEmpty(sort.Key))
                        {
                            query.Append(sort.Key).Append(sort.Value);
                        }
                    }

                    data = query.ToString().Replace(" ", "");
                }
            }
            #endregion

            #region 与传递过来的作比对
            {
                var md5Staff = FormsAuthentication.HashPasswordForStoringInConfigFile(timestamp + nonce + staffId + data, "MD5").ToUpper();
                if (!md5Staff.Equals(signature))
                    throw new SecurityException("无权访问");
            }
            #endregion
            base.OnActionExecuting(actionContext);
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            base.OnActionExecuted(actionExecutedContext);
        }
    }
}