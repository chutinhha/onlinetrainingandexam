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
using System.Collections.Generic;
using localhost;

public partial class Web_QuestionManage : System.Web.UI.Page
{
    BLLWS_User userService = new BLLWS_User();
    BLLWS_SingleSelected singleSelectedService = new BLLWS_SingleSelected();
    BLLWS_QuestionProblem questionProblemService = new BLLWS_QuestionProblem();

    protected void Page_Load(object sender, EventArgs e)
    {
        this.Page.Title = "问答题管理";
        if (!IsPostBack)
        {
            if (Session["userID"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                string userId = Session["userID"].ToString();
                string userName = userService.GetUserName(userId);
                Label i1 = (Label)Page.Master.FindControl("labUser");
                i1.Text = userName;

                //展示绑定的数据并将它展示在下拉列表中
                ddlCourse.Items.Clear();
                Course course = new Course();
                Course[] list = singleSelectedService.ListCourse();

                for (int i = 0; i < list.Length; i++)
                {
                    ListItem item = new ListItem(list[i].DepartmentName.ToString(), list[i].DepartmentId.ToString());
                    ddlCourse.Items.Add(item);
                }

                string selectvalue = this.ddlCourse.SelectedValue;
                this.GridView1.DataSource = questionProblemService.GetQuestionProblem(selectvalue);
                this.GridView1.DataBind();
            }
        }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow || e.Row.RowType == DataControlRowType.Separator)
        {
            Label label1 = e.Row.FindControl("Label1") as Label;
            label1.Text = (e.Row.RowIndex + 1).ToString();
        }
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.style.backgroundColor='#D9E480'");
            if (e.Row.RowIndex % 2 == 0)
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='#F7F7DE'");
            else
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='#FFFFFF'");
        }
    }
    protected void ddlCourse_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.GridView1.DataSourceID = null;
        string selectvalue = this.ddlCourse.SelectedValue;
        this.GridView1.DataSource = questionProblemService.GetQuestionProblem(selectvalue);
        this.GridView1.DataBind();
    }
}
