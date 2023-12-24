using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Framework.Utilities.Interceptors;
using Framework.Utilities.Security.JWT;
using Persistence.Abstract;
using Persistence.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StadiumManager>().As<IStadiumService>().SingleInstance();
            builder.RegisterType<EfStadiumDal>().As<IStadiumDal>().SingleInstance();

            builder.RegisterType<CenterManager>().As<ICenterService>().SingleInstance();
            builder.RegisterType<EfCenterDal>().As<ICenterDal>().SingleInstance();

            builder.RegisterType<RentManager>().As<IRentService>().SingleInstance();
            builder.RegisterType<EfRentDal>().As<IRentDal>().SingleInstance();
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<AdminService>().As<IAdminService>();
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
