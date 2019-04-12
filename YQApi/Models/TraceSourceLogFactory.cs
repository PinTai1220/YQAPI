using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YQApi.Models
{
    public class TraceSourceLogFactory : ILoggerFactory
    {
        public ILogger Create()
        {
            return new TraceSourceLog();
        }
    }
}