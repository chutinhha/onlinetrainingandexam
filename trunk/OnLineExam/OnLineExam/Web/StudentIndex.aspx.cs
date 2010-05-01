﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using localhost;

public partial class Web_StudentIndex : System.Web.UI.Page
{
    BLLWS_User userService = new BLLWS_User();
    BLLWS_Paper paperService = new BLLWS_Paper();
    BLLWS_Exam examService = new BLLWS_Exam();
    DALWS_SingleSelected singleSelectedService = new DALWS_SingleSelected();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["userID"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                InitData();
                string userId = Session["userID"].ToString();
                string userName = userService.GetUserName(userId);
                labUser.Text = userId;
                lblName.Text = userName;
                GridView1.DataSource = userService.GetselectExaminfo(userId);
                GridView1.DataBind();

                GridView2.DataSource = examService.ListUserExam(userId);
                GridView2.DataKeyNames = new string[] { "ExamId", "PaperID", "PaperName", "StartTime", "EndTime" };
                GridView2.DataBind();
            }
        }
    }

    private void InitData()
    {
        //DataSet ds = paperService.QueryPaper();  //查询所有可用试卷
        //if (ds.Tables[0].Rows.Count >= 1)
        //{
        //    ddlPaper.DataSource = ds;           //指名考试科目列表框数据源
        //    ddlPaper.DataTextField = "PaperName";   //DataTextField显示Name字段值
        //    ddlPaper.DataValueField = "PaperID";    //DataValueField显示ID字段值
        //    ddlPaper.DataBind();                //绑定数据

        //}
        //else
        //{
        //    ddlPaper.Enabled = false;
        //    Button1.Enabled = false;
        //    lblMessage.Text = "没有试卷！";
        //}
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.style.backgroundColor='#cbe2fa'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='#FFFFFF'");
        }
    }
    protected void imgBtnModifyPwd_Click1(object sender, ImageClickEventArgs e)
    {
        string userId = Session["userID"].ToString();
        string newPwd = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(this.txtNewPwd.Text.Trim(), "MD5").ToString();
        string pwdMd5 = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(this.txtOldPwd.Text.Trim(), "MD5").ToString();
        if (userService.GetSelectPwd(pwdMd5))
        {
            userService.ModifyPwd(newPwd, userId);
            this.lblPwd.Text = "修改成功！";
        }
        else
        {
            this.lblPwd.Text = "原密码不正确！";
        }
    }
    protected void imgBtnReset_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void exit_Click(object sender, EventArgs e)
    {

    }
    protected void GridView2_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        string UserID = Session["userID"].ToString();
        string examID = GridView2.DataKeys[e.NewSelectedIndex].Values[0].ToString();
        string PaperID = GridView2.DataKeys[e.NewSelectedIndex].Values[1].ToString();
        if (!(singleSelectedService.Getitem(UserID, PaperID)))
        {
            lblMessage.Text = "您已经考过";
        }
        else
        {
            Exam exam = examService.GetExam(Convert.ToInt32(Session["ExamID"]));
            DateTime start = Convert.ToDateTime(GridView2.DataKeys[e.NewSelectedIndex].Values[3]);
            DateTime end = Convert.ToDateTime(GridView2.DataKeys[e.NewSelectedIndex].Values[4]);
            DateTime now = examService.GetServerTime();
            if (now.CompareTo(start) < 0)
            {
                lblMessage.Text = "考试还没开始!";
                return;
            }
            if (now.CompareTo(end) >= 0)
            {
                lblMessage.Text = "考试已经结束!";
                return;
            }
            
            Session["PaperID"] = PaperID;
            Session["PaperName"] = GridView2.DataKeys[e.NewSelectedIndex].Values[2].ToString();
            Session["userID"] = Session["userID"].ToString();
            Session["userName"] = labUser.Text;
            Session["ExamID"] = examID;
            Response.Write("<script>window.open('UserTest.aspx?paperId=" + PaperID + "',null,'fullscreen=1')</script>");
            Response.Redirect("UserTest.aspx?paperId=" + PaperID + "");
            Response.Write("<script language=javascript>window.close('StudentIndex.aspx');</script>");
        }
    }
}