<%@ Page Language="C#" AutoEventWireup="true"%>
<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        foreach (var r in System.Web.Routing.RouteTable.Routes)
        {
            var route = r as System.Web.Routing.Route;
            if (route != null)
            {
                Response.Write(string.Format("{0}: {1}<br>", route.Url, route.RouteHandler));
                continue;
            }
            Response.Write(string.Format("{0}<br>", r));
        }
    }
</script>