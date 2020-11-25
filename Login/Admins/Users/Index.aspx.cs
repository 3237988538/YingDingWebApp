using BLL;
using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YingDingWebApp.Login.Admins.Users
{
    public partial class Index : System.Web.UI.Page
    {
        Model.Users data;
        private SystemMenusService MenuSvc = new SystemMenusService();
        protected void Page_Load(object sender, EventArgs e)
        {
            data = (Model.Users)Session["LoginOk"];
            if (data == null || data.User_RolesId == Guid.Empty)
            {
                Response.Write("<script>alert('登录超时!');location.href='../Login.aspx';</script>");
            }
            Bind();
        }

        private void Bind()
        {
            List<SystemMenus> list = (List<SystemMenus>)MenuSvc.GetSystemMenusByRolesIdAndParnetId(data.User_RolesId, Guid.Empty);
            this.Repeater1.DataSource = new List<Model.Users> { data };
            this.Repeater1.DataBind();
            Response.Write(list);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
    }
}