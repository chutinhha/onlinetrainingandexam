﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Configuration;
using OnLineExamModel;

namespace OnLineExamDALWS
{
    /// <summary>
    /// DALWS_SingleSelected 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class DALWS_SingleSelected : System.Web.Services.WebService
    {

        [WebMethod]
        public bool Getitem(string a, string b)
        {
            using (SqlConnection conn = DBHelp.GetConnection())
            {
                string sql = @"select * from UserAnswer where UserID = '" + a + "'and PaperID = '" + b + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (!dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        [WebMethod]
        public List<Course> ListCourse()
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Select * from Course";
                conn.Open();
                SqlDataReader DR = cmd.ExecuteReader();
                List<Course> list = new List<Course>();

                while (DR.Read())
                {
                    Course c = new Course();
                    c.DepartmentId = (int)DR[0];
                    c.DepartmentName = DR[1].ToString();
                    list.Add(c);
                }
                DR.Close();
                conn.Close();
                return list;
            }
        }

        [WebMethod]
        public bool InsertQuestion(SingleProblem iq)
        {
            string sql = @"INSERT INTO SingleProblem
(CourseID,Title,AnswerA,AnswerB,AnswerC,AnswerD,Answer)
VALUES
(@CourseID,@Title,@AnswerA,@AnswerB,@AnswerC,@AnswerD,@Answer)";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@CourseID",iq.CourseID),
                new SqlParameter("@Title",iq.Title),
                new SqlParameter("@AnswerA",iq.AnswerA),
                new SqlParameter("@AnswerB",iq.AnswerB),
                new SqlParameter("@AnswerC",iq.AnswerC),
                new SqlParameter("@AnswerD",iq.AnswerD),
                new SqlParameter("@Answer",iq.Answer)   
            };
            int db = DBHelp.ExecuteCommand(sql, para);
            if (db > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public bool UpdateQuestion(SingleProblem uq)
        {
            string sql = @"UPDATE SingleProblem
SET CourseID =@CourseID, Title =@Title, AnswerA =@AnswerA, AnswerB =@AnswerB, 
AnswerC =@AnswerC, AnswerD =@AnswerD, Answer =@Answer where ID=@ID";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseID",uq.CourseID),
                new SqlParameter("@Title",uq.Title),
                new SqlParameter("@AnswerA",uq.AnswerA),
                new SqlParameter("@AnswerB",uq.AnswerB),
                new SqlParameter("@AnswerC",uq.AnswerC),
                new SqlParameter("@AnswerD",uq.AnswerD),
                new SqlParameter("@Answer",uq.Answer),  
                new SqlParameter("@ID",uq.ID)
            };
            int i = DBHelp.ExecuteCommand(sql, param);
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
        public List<SingleProblem> GetSingleProblemList(string selectvalue)
        {
            using (SqlConnection con = DBHelp.GetConnection())
            {
                string sql = "select * from SingleProblem where CourseID=" + selectvalue;
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                List<SingleProblem> list = new List<SingleProblem>();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SingleProblem sing = new SingleProblem();
                    sing.ID = Convert.ToInt32(dr["ID"]);
                    sing.CourseID = Convert.ToInt32(dr["CourseID"]);
                    sing.Title = dr["Title"].ToString();
                    sing.AnswerA = dr["AnswerA"].ToString();
                    sing.AnswerB = dr["AnswerB"].ToString();
                    sing.AnswerC = dr["AnswerC"].ToString();
                    sing.AnswerD = dr["AnswerD"].ToString();
                    sing.Answer = dr["Answer"].ToString();
                    list.Add(sing);
                }
                return list;
            }
        }

        [WebMethod]
        public List<SingleProblem> selectSingQuestion(string UserId, int PaperId)
        {
            using (SqlConnection con = DBHelp.GetConnection())
            {
                string sql = @"SELECT     dbo.UserAnswer.id,dbo.UserAnswer.Mark, dbo.UserAnswer.UserAnswer, dbo.UserAnswer.ExamTime, dbo.SingleProblem.Title, dbo.SingleProblem.AnswerB, 
                      dbo.SingleProblem.AnswerA, dbo.SingleProblem.AnswerC, dbo.SingleProblem.AnswerD, dbo.SingleProblem.Answer, dbo.Paper.PaperName
FROM         dbo.UserAnswer INNER JOIN
                      dbo.SingleProblem ON dbo.UserAnswer.TitleID = dbo.SingleProblem.ID AND dbo.UserAnswer.Type = '单选题' INNER JOIN
                      dbo.Paper ON dbo.UserAnswer.PaperID = dbo.Paper.PaperID
where 
dbo.UserAnswer.UserID='" + UserId + "' and dbo.UserAnswer.PaperID='" + PaperId + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                List<SingleProblem> list = new List<SingleProblem>();
                while (dr.Read())
                {
                    SingleProblem Sing = new SingleProblem();
                    Sing.ID = Convert.ToInt32(dr["id"]);
                    Sing.Mark = Convert.ToInt32(dr["Mark"]);
                    Sing.UserAnswer = dr["UserAnswer"].ToString();
                    Sing.ExamTime = Convert.ToDateTime(dr["ExamTime"]);
                    Sing.Title = dr["Title"].ToString();
                    Sing.AnswerA = dr["AnswerA"].ToString();
                    Sing.AnswerB = dr["AnswerB"].ToString();
                    Sing.AnswerC = dr["AnswerC"].ToString();
                    Sing.AnswerD = dr["AnswerD"].ToString();
                    Sing.Answer = dr["Answer"].ToString();
                    Sing.PaperName = dr["PaperName"].ToString();
                    list.Add(Sing);
                }
                return list;
            }
        }
    }
}
