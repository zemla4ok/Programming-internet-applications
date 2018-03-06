using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WEB5B
{
    public class POST5B : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            Random rand = new Random();
            HttpRequest req = context.Request;
            HttpResponse res = context.Response;

            int n = Convert.ToInt32(req.Headers["X-Rand-N"]);
            int amount = rand.Next(5, 10);
            List<int> list = new List<int>();
            for (int i = 0; i < amount; i++)
            {
                list.Add(rand.Next((-1) * n, n));
            }

            string result = "";
            result += "<?xml version='1.0'?><numbers>";
            for (int i = 0; i < list.Count; i++)
            {
                result += "<number>";
                result += list[i];
                result += "</number>";
            }
            result += "</numbers>";
            //res.ContentType = "text/xml";
            //res.Write(result);
            res.Headers.Add("qwe", result);
        }
    }
}