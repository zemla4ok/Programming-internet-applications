using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB02KDV
{
    public class GETKDV : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest req = context.Request;
            HttpResponse res = context.Response;

            res.AddHeader("X-KDV", "Kotovich Dmitry");

            res.WriteFile("response_page.html");
            res.Write("<H1>" + req.Params["getKDVparm"] + "</H1>");
        }
    }
}