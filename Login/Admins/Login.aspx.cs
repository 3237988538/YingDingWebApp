using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YingDingWebApp.Login.Admins
{
    public partial class Login : System.Web.UI.Page
    {
        private readonly UsersService userSvc = new UsersService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            var data = userSvc.Login(this.txtEmail.Text, MD5Helper.Md5(this.txtPwd.Text));
            if (data != null)
            {
                Session["LoginOk"] = data;
                Response.Write("<script>location.href='Users/Index.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('账号或者密码错误,请重新输入');</script>");
            }
        }
    }
}