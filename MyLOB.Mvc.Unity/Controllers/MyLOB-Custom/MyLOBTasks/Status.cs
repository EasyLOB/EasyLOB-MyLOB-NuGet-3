using EasyLOB.Mvc;
using EasyLOB.Resources;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MyLOB.Mvc
{
    public partial class MyLOBTasksController
    {
        #region Methods

        // GET: MyLOBTasks/Status
        [HttpGet]
        public ActionResult Status()
        {
            StringBuilder result = new StringBuilder();

            MyLOBTenant MyLOBtenant = MyLOBMultiTenantHelper.Tenant;
            result.Append("<br /><b>Multi-Tenant MyLOB</b>");
            result.Append("<br />:: Name: " + MyLOBtenant.Name);

            HttpSessionStateBase session = Session;
            result.Append("<br />");
            result.Append("<br /><b>Session</b>");
            result.Append("<br />:: SessionID: " + session.SessionID);
            result.Append("<br />:: Key(s)");
            for (int i = 0; i < session.Contents.Count; i++)
            {
                string value = session[i].ToString();
                switch (session.Keys[i])
                {
                    case "EasyLOB.MyLOBMultiTenant":
                        //value = JsonConvert.SerializeObject((List<MyLOBTenant>)session[i]);
                        break;
                }

                //result.Append("<br />&nbsp;&nbsp;&nbsp;" + session.Keys[i] + ": " + value);
            }

            ViewBag.Status = result.ToString();

            TaskViewModel viewModel = new TaskViewModel("MyLOBTasks", "MyLOBStatus", EasyLOBPresentationResources.TaskApplicationStatus);

            return ZView(viewModel);
        }

        #endregion Methods
    }
}