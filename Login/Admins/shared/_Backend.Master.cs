using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace YingDingWebApp.Login.Admins.shared
{
    public partial class _Backend : System.Web.UI.MasterPage
    {
        public string msg = "initial";
        public int code = 0;
        private readonly SystemMenusService menuSvc = new SystemMenusService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            object ob = Session["Msg"];
            if(ob != null)
            {
                var res = ob as ReturnMsg;
                msg = res.Message;
                code = (int)res.Code;
                Session["Msg"] = null;
            }


            #region 一级菜单绑定
            //在这里我们还需要获取当前账号信息登入的权限等级
            object signIn = Session["LoginOk"];
            if (signIn != null)
            {
                Model.Users users = (Model.Users)signIn;
                Guid rid = users.User_PId; //得到我们要用的权限id

                this.RepLeftNavi.DataSource = Bind(rid, Guid.Empty);
                this.RepLeftNavi.DataBind();
                this.lblNickName.Text = users.User_NickName;
                this.Image1.ImageUrl = "../../upload/users/" + users.User_Phone;
            }
            else
            {
                Response.Write("<script>alert('登入超时,请重新登入');location.href='../Login.aspx'</script>");
            }

            #endregion
        }


        public IList<SystemMenus> Bind(Guid rid, Guid parentId)
        {
            //var data = menuSvc.GetSystemMenusByRolesIdAndParnetId(rid, parentId);
            //return (IList<SystemMenus>)data;
            return null;
        }

        protected void RepLeftNavi_OnItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            //这个是我们子级菜单绑定的位置, 因为子级菜单是在Repeater控件内部的,我们需要通过这个事件来查找到对应的控件
            //(1) 存储父级菜单id的Label控件
            //(2) 绑定子级菜单的Repeater控件
            Label lbl = (Label)e.Item.FindControl("lblParentId");
            Repeater rep = (Repeater)e.Item.FindControl("RepSonMenu");
            object signIn = Session["LoginOk"];
            if (signIn != null)
            {
                using (UsersService userSvc = new UsersService()) {
                    Model.Users users = (Model.Users)signIn;
                    Guid rid = users.User_RolesId; //得到我们要用的权限id
                    rep.DataSource = Bind(rid, Guid.Parse(lbl.Text));
                    rep.DataBind();
                }
            }
        }
    }
}