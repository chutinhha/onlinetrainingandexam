using System;
using System.Collections.Generic;
using System.Text;

namespace OnLineExamModel
{
    //问答题类
    [Serializable]
    public class QuestionProblem
    {
        #region 私有成员
        private int _ID;                                               //题目编号
        private int _CourseID;                                         //所属科目        
        private string _Title;                                         //题目       
        private string _Answer;                                       //答案


        private string userAnswer;

        public string UserAnswer
        {
            get { return userAnswer; }
            set { userAnswer = value; }
        }

        private DateTime examTime;

        public DateTime ExamTime
        {
            get { return examTime; }
            set { examTime = value; }
        }

        private int mark;

        public int Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        private string paperName;

        public string PaperName
        {
            get { return paperName; }
            set { paperName = value; }
        }
        #endregion 私有成员

        #region 属性

        public int ID
        {
            set
            {
                this._ID = value;
            }
            get
            {
                return this._ID;
            }
        }
        public int CourseID
        {
            set
            {
                this._CourseID = value;
            }
            get
            {
                return this._CourseID;
            }
        }
        public string Title
        {
            set
            {
                this._Title = value;
            }
            get
            {
                return this._Title;
            }
        }
        public string Answer
        {
            set
            {
                this._Answer = value;
            }
            get
            {
                return this._Answer;
            }
        }
        #endregion 属性
    }
}
