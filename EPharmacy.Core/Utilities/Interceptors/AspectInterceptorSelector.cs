using Castle.DynamicProxy;
using EPharmacy.Core.Aspects.Autofac.Exception;
using EPharmacy.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EPharmacy.Core.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>(true).ToList();
            var methodAttributes = type.GetMethod(method.Name).GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);
            classAttributes.Add(new ExceptionLogAspect(typeof(FileLogger)));
            return classAttributes.OrderBy(x => x.Priority).ToArray();
        }
    }
}
