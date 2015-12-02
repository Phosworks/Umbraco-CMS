using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;
using Umbraco.Core;

namespace ATG.Moet.Cms.debug
{
    public partial class routes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (var r in RouteTable.Routes)
            {
                var route = r as System.Web.Routing.Route;
                if (route != null)
                {
                    Response.Write(string.Format("{0}: {1}<br>", route.Url, route.RouteHandler));
                    continue;
                }
                //var httpWebRoute = r as System.Web.Http.WebHost.Routing.HttpWebRoute;
                Response.Write(string.Format("{0}<br>", r));
            }
        }
    }
}