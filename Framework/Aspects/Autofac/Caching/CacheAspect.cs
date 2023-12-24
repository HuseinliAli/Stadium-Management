using Castle.DynamicProxy;
using Framework.CrossCuttingConcerns.Caching;
using Framework.Utilities.Interceptors;
using Framework.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Framework.Aspects.Autofac.Caching
{
    public class CacheAspect : MethodInterception
    {
        private int _duration;
        private ICacheManager _cacheManager;
        public CacheAspect(int duration = 1)
        {
            _duration = duration;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        public override void Intercept(IInvocation invocation)
        {
            var methodName = string.Format($"{invocation.Method.ReflectedType}.{invocation.Method.Name}");
            var arguments = invocation.Arguments.ToList();
            var key = $"{methodName}({string.Join(",",arguments.Select(i=>i.ToString()??"<Null>"))})";

            if (_cacheManager.IsAdded(key))
            {
                invocation.ReturnValue = _cacheManager.Get(key);
                return;
            }
            invocation.Proceed();
            _cacheManager.Add(key, invocation.ReturnValue, _duration);
        }
    }
}
