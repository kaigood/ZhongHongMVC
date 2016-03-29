using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace ZhongHong.Core
{
    /// <summary>
    /// 数据上下文工厂
    /// </summary>
    public class ContextFactory
    {
        /// <summary>
        /// 获取当前线程的数据上下文
        /// </summary>
        /// <returns>数据上下文</returns>
        public static ZhongHongyContext CurrentContext()
        {
            ZhongHongyContext _nContext = CallContext.GetData("ZhongHongyContext") as ZhongHongyContext;
            if (_nContext == null)
            {
                _nContext = new ZhongHongyContext();
                CallContext.SetData("ZhongHongyContext", _nContext);
            }
            return _nContext;
        }
    }
}
