﻿using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using localhost;

public partial class _Default : System.Web.UI.Page
{
    BLLWS_User userService = new BLLWS_User();

    protected void Page_Load(object sender, EventArgs e)
    {
        this.txtUserID.Focus();
        if (!IsPostBack)
        {
            try
            {
                HttpCookie readcookie = Request.Cookies["UsersID"];
                this.txtUserID.Text = readcookie.Value;
            }
            catch (Exception)
            {
                this.txtUserID.Text = string.Empty;
            }
        }
    }
    protected void imgBtnLogin_Click(object sender, ImageClickEventArgs e)
    {
        string usersId = txtUserID.Text.Trim();
        string pwdMd5 = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(txtPwd.Text.Trim(), "MD5").ToString();

        Users u = new Users();
        u.UserID = usersId;
        u.UserPwd = pwdMd5;

        if (String.Compare(Request.Cookies["yzmcode"].Value, Validator.Text, true) != 0)
        {
            lblMessage.Text = "验证码错误！";
            return;
        }

        bool success = userService.Login(ref u);
        if (success)
        {
            if (u.UserPwd == pwdMd5)//输入密码与用户密码相同
            {
                if (this.cbxRemeberUser.Checked)
                {
                    if (object.Equals(Request.Cookies["UsersID"], null))
                    {
                        CreateCookie();
                    }
                    else
                    {
                        CreateCookie();
                    }
                }
                Session["userID"] = txtUserID.Text.Trim();//存储用户编号
                Session["roleID"] = u.RoleId.ToString();
                Response.Redirect("Default.aspx");//转向管理员操作界面                      
            }
            else//密码错误，给出提示
            {
                lblMessage.Text = "您输入的密码错误！";
            }
        }
        else//用户不存在，给出提示
        {
            lblMessage.Text = "用户不存在或密码错误！";
        }
    }

    protected void ChangeCode_Click(object sender, EventArgs e)
    {

    }
    
    private void CreateCookie()
    {
        HttpCookie cookie = new HttpCookie("UsersID");
        if (this.cbxRemeberUser.Checked)
        {
            cookie.Value = txtUserID.Text;
        }
        cookie.Expires = DateTime.MaxValue;
        Response.AppendCookie(cookie);
    }
}
