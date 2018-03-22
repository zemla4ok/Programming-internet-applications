using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Lab_04
{
    public class GetPNG : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest req = context.Request;
            HttpResponse res = context.Response;

            string parm = req.Params.Get("cache-parm");

            switch (parm)
            {
                case "last-modified":   //work
                    res.Cache.SetLastModified(DateTime.MinValue);
                    break;
                case "etag":            //work
                    res.CacheControl = "public";
                    res.Cache.SetETag("zemla4ok".GetHashCode().ToString());
                    break;
                case "expired":         //work
                    res.Cache.SetExpires(DateTime.Now.AddDays(10));
                    break;
                case "max-age":         //work
                    res.Cache.SetMaxAge(TimeSpan.FromSeconds(5));
                    break;
                case "no-store":        //work
                    res.Cache.SetNoStore();
                    break;
            }

            string imagePath = "img.png";
            res.ContentType = "image/" + Path.GetExtension(imagePath).ToLower();
            res.WriteFile(imagePath);
        }
    }
}