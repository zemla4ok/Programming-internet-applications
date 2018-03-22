using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB02KDV
{
    public class POSTKDV : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest req = context.Request;
            HttpResponse res = context.Response;

            res.Write("radio=" + req.Params["radio"] + "<br>" +
                      "check=" + req.Params["check"] + "<br>" + 
                      "text=" + req.Params["text"] + "<br>" +
                      "but2=" + req.Params["but2"] + "<br>" +
                      "button=" + req.Params["but"] + "<br>" + "<br>" );

            string[] keys = req.Headers.AllKeys;

            res.Write("<h1> HEADERS </h1><br>");
            foreach(var key in keys)
            {
                res.Write(key + " = " + req.Headers[key] + "<br>");
            }


            string[] parmKeys = req.Params.AllKeys;

            res.Write("<h1> PARAMS </h1><br>");
            foreach (var key in parmKeys)
            {
                res.Write(key + " = " + req.Params[key] + "<br>");
            }
        }
    }
}