using Castle.DynamicProxy;
using MYAZ201.nTier.Business.Utilities.Interceptors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ201.nTier.Business.Utilities.Aspects
{
    public class CommonAspect : MethodInterception
    {
        public override void OnBefore(IInvocation invocation)
        {
            Debug.WriteLine($"Before invocation : {invocation.Method.Name}");
        }

        public override void OnException(IInvocation invocation, Exception ex)
        {
            Debug.WriteLine($"{invocation.Method.Name} : {ex.Message}");
        }

        public override void OnAfter(IInvocation invocation)
        {
            Debug.WriteLine($"After invocation : {invocation.Method.Name}");
        }
    }
}
