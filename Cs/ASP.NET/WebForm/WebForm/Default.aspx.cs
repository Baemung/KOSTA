using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Xml;

namespace WebForm
{
    public partial class _Default : Page
    {
        public static string skey = "3ALdT05j7OIH13Yqz5elfARolLZV9VbO3HL0jtidu7Jdbjn64g%2BTosh%2Bm0zMjXwwHbmRnPCc8lwPc5uU1vgobg%3D%3D"; // Service Key
        static HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            string url = "http://apis.data.go.kr/9710000/NationalAssemblyInfoService/"; // URL
            url += "getMemberCurrStateList";
            url += "?ServiceKey=" + skey;
            url += "&numOfRows=300";

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            string results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                results = reader.ReadToEnd();
            }

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(results);
            XmlNodeList xnlist = xml.GetElementsByTagName("item");
            foreach (XmlNode xn in xnlist)
            {
                string empNm = xn["empNm"].InnerText;

            }
        }
    }
}