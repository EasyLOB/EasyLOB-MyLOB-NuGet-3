using EasyLOB;
using EasyLOB.Environment;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace MyLOB
{
    public static class MyLOBMultiTenantHelper
    {
        #region Properties

        private static string SessionName = "EasyLOB.MyLOBMultiTenant";

        public static MyLOBTenant Tenant
        {
            get { return GetTenant(MultiTenantHelper.Tenant.Name); }
        }

        public static List<MyLOBTenant> Tenants
        {
            get
            {
                List<MyLOBTenant> tenants = (List<MyLOBTenant>)ManagerHelper.EnvironmentManager.SessionRead(SessionName);
                if (tenants == null || tenants.Count == 0)
                {
                    try
                    {
                        string filePath = Path.Combine(ManagerHelper.EnvironmentManager.ApplicationPath(ConfigurationHelper.AppSettings<string>("EasyLOB.Directory.Configuration")),
                            "JSON/MyLOBMultiTenant.json");
                        string json = File.ReadAllText(filePath);
                        tenants = JsonConvert.DeserializeObject<List<MyLOBTenant>>(json);
                    }
                    catch { }
                    tenants = tenants ?? new List<MyLOBTenant>();

                    ManagerHelper.EnvironmentManager.SessionWrite(SessionName, tenants);
                }

                return tenants;
            }
        }

        #endregion Properties

        #region Methods

        public static MyLOBTenant GetTenant(string name)
        {
            MyLOBTenant MyLOBTenant = null;

            if (Tenants.Count > 0)
            {
                foreach (MyLOBTenant t in Tenants)
                {
                    if (t.Name.Equals(name, System.StringComparison.CurrentCultureIgnoreCase))
                    {
                        MyLOBTenant = t;
                        break;
                    }
                }
            }

            if (MyLOBTenant == null && Tenants.Count > 0)
            {
                MyLOBTenant = Tenants[0];
            }

            MyLOBTenant = MyLOBTenant ?? new MyLOBTenant();

            return MyLOBTenant;
        }

        #endregion
    }
}