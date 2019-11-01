using AutoMapper;
using EasyLOB.Activity.Data;
using EasyLOB.AuditTrail.Data;
using EasyLOB.Data;
using EasyLOB.Identity.Data;
using MyLOB.Data;

namespace EasyLOB
{
    public static partial class AppHelper
    {
        #region Properties

        public static string[] AppPath // !!!
        {
            get
            {
                return new string[] {
                    "MyLOB", // !!!
                    "MyLOB-Custom", // !!!
                    "Activity",
                    "Activity-Custom",
                    "AuditTrail",
                    "AuditTrail-Custom",
                    "Authentication",
                    "Dashboards",
                    "Identity",
                    "Identity-Custom",
                    "Reports",
                    "Tasks"
                };
            }
        }

        #endregion

        #region Methods

        public static void Setup()
        {
            // AutoMapper
            SetupMappers();

            // Profile
            SetupProfiles();
        }

        public static void SetupMappers()
        {
            Mapper.Initialize(cfg => {
                // ZDataModel <-> ZDTOModel
                // Activity
                cfg.AddProfile<ActivityDataAutoMapper>();
                // Audit Trail
                cfg.AddProfile<AuditTrailDataAutoMapper>();
                // Identity
                cfg.AddProfile<IdentityDataAutoMapper>();
                // MyLOB
                cfg.AddProfile<MyLOBDataAutoMapper>(); // !!!
            });
        }

        public static void SetupProfiles()
        {
            // ZDataModel
            // Activity
            DataHelper.SetupDataProfile("EasyLOB.Activity.Data");
            // Audit Trail
            DataHelper.SetupDataProfile("EasyLOB.AuditTrail.Data");
            // Identity
            DataHelper.SetupDataProfile("EasyLOB.Identity.Data");
            // MyLOB
            DataHelper.SetupDataProfile("MyLOB.Data"); // !!!
        }

        #endregion Methods
    }
}