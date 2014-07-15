using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Net;
using System.IO;
using System.Text;
namespace nms_sms
{
    public class cls_sms
    {
        public string SMSSend(string message, Int64 mobileno)
        {
            string s = "";
            WebClient client = new WebClient();
            string baseurl = @"http://208.101.14.59/api/pushsms.php?usr=8099&pwd=abc123&sndr=AKMART&ph=" + mobileno.ToString() + "&text=" + message.Trim() + "&rpt=1";
            Stream data = client.OpenRead(baseurl);
            StreamReader reader = new StreamReader(data);
            s = reader.ReadToEnd();
            data.Close();
            reader.Close();
            return s;
        }

    }
}
