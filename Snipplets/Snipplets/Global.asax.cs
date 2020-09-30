using Snipplets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.IO;

namespace Snipplets
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // CleanUp UploadedFiles folder ... 

            /*
    
            string _Path = Server.MapPath("~/UploadedFiles");


            DirectoryInfo dir = new DirectoryInfo(_Path);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }

            */

            // Add one Element 
            Snipplets.Controllers.EmployeeController.EmployeeListe.Add(
            new Employee ()
            {
                Id = 1,
                Active = true,
                Age = 48,
                FileNamePicture = "",
                FirstName = "Walter",
                LastName = "Der Weise"

            });

        }
    }
}
