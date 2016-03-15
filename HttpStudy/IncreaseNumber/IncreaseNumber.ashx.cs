using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IncreaseNumber
{
    /// <summary>
    /// Summary description for IncreaseNumber
    /// </summary>
    public class IncreaseNumber : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string number = context.Request["number"];
            string isPostBack = context.Request["isPostBack"];
            if (isPostBack == "true")
            {
                int numberInt = Convert.ToInt32(number);
                numberInt++;
                number = numberInt.ToString();
            }
            else
            {
                number = "0";
            }
            string fullPath = context.Server.MapPath("IncreaseNumber.html");
            string content = File.ReadAllText(fullPath);
            content = content.Replace("@number", number);
            context.Response.ContentType = "text/html";
            context.Response.Write(content);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}