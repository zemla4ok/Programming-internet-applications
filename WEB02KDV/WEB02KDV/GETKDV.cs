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

            res.Write( "<HTML>" + 
                            "<HEAD>" +
                            "<TITLE> GETKDV </TITLE>" +
                            "<LINK rel=\"stylesheet\" type=\"text/css\" href=\"CSS1KDV.css\">" +
                            "<LINK rel=\"stylesheet\" type=\"text/css\" href=\"CSS2KDV.css\">" +
                            "<SCRIPT src=\"JS1KDV.js\"></SCRIPT>" +
                            "<SCRIPT src=\"JS2KDV.js\"></SCRIPT>" +
                            "</HEAD>" + 
                            "<H1>" + req.Params["getKDVparm"] + "</H1>" + 
                            "<A href=\"HTMLKDV.html\">my page</A>" + "<br>" +
                            "<IMG src=\"IMGKDV.jpg\">" + "<br>" + "<br>" + "<br>" +

                            "<FORM method=\"POST\" action=\"post\">" + 
                                "<input type=\"text\" name=\"text\">" + "<br>" +
                                "<input type=\"checkbox\" checked name=\"check\">" + "<br>" +
                                "<input type=\"radio\" checked name=\"radio\">" + "<br>" +
                                "<input type=\"submit\">" +
                            "</FORM>" +

                       "</HTML>");
        }
    }
}