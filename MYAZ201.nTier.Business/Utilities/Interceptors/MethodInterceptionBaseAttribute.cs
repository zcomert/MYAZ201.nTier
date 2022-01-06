using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ201.nTier.Business.Utilities.Interceptors
{
    [AttributeUsage(
        AttributeTargets.Class |
        AttributeTargets.Method |
        AttributeTargets.Assembly,
        AllowMultiple = true,
        Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; }
        public virtual void Intercept(IInvocation invocation)
        {
            
        }
    }
}
