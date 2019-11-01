using Autofac;
using EasyLOB.Extensions.Edm;
using EasyLOB.Extensions.Ini;
using EasyLOB.Extensions.Mail;

namespace EasyLOB
{
    public static partial class AppDIAutofacHelper
    {
        public static void SetupExtensions()
        {
            //ContainerBuilder.RegisterType<EdmManagerMock>().As<IEdmManager>(); // InstancePerDependency();
            ContainerBuilder.RegisterType<EdmManagerFileSystem>().As<IEdmManager>(); // InstancePerDependency();
            //ContainerBuilder.RegisterType<EdmManagerFTP>().As<IEdmManager>(); // InstancePerDependency();

            //ContainerBuilder.RegisterType<IniManagerMock>().As<IIniManager>(); // InstancePerDependency();
            ContainerBuilder.RegisterType<IniManager>().As<IIniManager>(); // InstancePerDependency();

            //ContainerBuilder.RegisterType<MailManagerMock>().As<IMailManager>(); // InstancePerDependency();
            ContainerBuilder.RegisterType<MailManager>().As<IMailManager>(); // InstancePerDependency();
        }
    }
}