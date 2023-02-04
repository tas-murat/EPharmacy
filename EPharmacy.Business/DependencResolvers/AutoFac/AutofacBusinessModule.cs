using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using EPharmacy.Business.Abstract;
using EPharmacy.Business.Concrete;
using EPharmacy.Core.Utilities.Interceptors;
using EPharmacy.Core.Utilities.Security.Jwt;
using EPharmacy.DataAccess.Abstract;
using EPharmacy.DataAccess.Concrete;

namespace EPharmacy.Business.DependencResolvers.AutoFac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();


            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
