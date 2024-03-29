﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using OnLineExamModel;

namespace OnLineExamDALWS
{
    /// <summary>
    /// DALWS_JudgeProblem 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class DALWS_JudgeProblem : System.Web.Services.WebService
    {

        [WebMethod]
        public bool judgeProblemUpdate(JudgeProblem jp)
        {
            string sql = "Update JudgeProblem Set CourseID=@CourseID,Title=@Title,Answer=@Answer where ID=" + jp.ID;
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@CourseID",jp.CourseID),
                new SqlParameter("@Title",jp.Title),
                new SqlParameter("@Answer",jp.Answer),
            };
            int i = DBHelp.ExecuteCommand(sql, para);
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public bool judgeProblemInsert(JudgeProblem ji)
        {
            string sql = "Insert into JudgeProblem (CourseID,Title,Answer) values(@CourseID,@Title,@Answer)";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@CourseID",ji.CourseID),
                new SqlParameter("@Title",ji.Title),
                new SqlParameter("@Answer",ji.Answer)
            };
            int i = DBHelp.ExecuteCommand(sql, para);
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public List<JudgeProblem> GetJudgeProblemList(string selectvalues)
        {
            using (SqlConnection conn = DBHelp.GetConnection())
            {
                string sql = "select * from JudgeProblem where CourseID=" + selectvalues;
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                List<JudgeProblem> list = new List<JudgeProblem>();
                SqlDataReader DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    JudgeProblem judge = new JudgeProblem();
                    judge.ID = Convert.ToInt32(DR["ID"]);
                    judge.CourseID = Convert.ToInt32(DR["CourseID"]);
                    judge.Title = DR["Title"].ToString();
                    judge.Answer = Convert.ToBoolean(DR["Answer"]);
                    list.Add(judge);
                }
                return list;
            }
        }

        [WebMethod]
        public List<JudgeProblem> selectJudgeQuestion(string UserId, int PaperId)
        {
            using (SqlConnection con = DBHelp.GetConnection())
            {
                string sql = @"SELECT     dbo.UserAnswer.id,dbo.UserAnswer.Mark, dbo.UserAnswer.UserAnswer, dbo.UserAnswer.ExamTime, dbo.JudgeProblem.Title, dbo.JudgeProblem.Answer, 
                      dbo.Paper.PaperName
FROM         dbo.UserAnswer INNER JOIN
                      dbo.JudgeProblem ON dbo.UserAnswer.TitleID = dbo.JudgeProblem.ID AND dbo.UserAnswer.Type = '判断题' INNER JOIN
                      dbo.Paper ON dbo.UserAnswer.PaperID = dbo.Paper.PaperID AND dbo.UserAnswer.Type = '判断题' 
where 
dbo.UserAnswer.UserID='" + UserId + "' and dbo.UserAnswer.PaperID='" + PaperId + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                List<JudgeProblem> list = new List<JudgeProblem>();
                while (dr.Read())
                {
                    JudgeProblem judge = new JudgeProblem();
                    judge.ID =Convert.ToInt32(dr["id"]);
                    judge.UserAnswer = dr["UserAnswer"].ToString();
                    judge.Mark = Convert.ToInt32(dr["Mark"]);
                    judge.ExamTime = Convert.ToDateTime(dr["ExamTime"]);
                    judge.Title = dr["Title"].ToString();
                    judge.Answer = Convert.ToBoolean(dr["Answer"]);
                    judge.PaperName = dr["Papername"].ToString();
                    list.Add(judge);
                }
                return list;
            }
        }
    }
}
