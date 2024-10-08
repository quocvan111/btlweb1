using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLLTW_webBanQuanAo
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<User> users = (List<User>)Application["Users"];
            string tkdn = Request.Form["username"];
            string mkdn = Request.Form["passowrd"];

            if (tkdn != null && mkdn != null)
            {
                int checkdn = 0;
                int index = 0;
                for (int i = 0; i < users.Count; i++)
                {
                    if (String.Compare(users[i].Taikhoan, tkdn.ToString(), false) == 0 && String.Compare(users[i].Matkhau, mkdn.ToString(), false) == 0)
                    {
                        index = i;
                        checkdn++;
                        Response.Redirect("index.aspx");
                    }
                }
            }
        }
    }
}