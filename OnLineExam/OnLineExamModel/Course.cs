using System;
using System.Collections.Generic;
using System.Text;

namespace OnLineExamModel
{
    //���Կ�Ŀ��
    [Serializable]
    public class Course
    {
        #region ˽�г�Ա

        private int _departmentId;		
        private string _departmentName;		//����ID

        public int DepartmentId
        {
            get { return _departmentId; }
            set { _departmentId = value; }
        }
       	//������       

        public string DepartmentName
        {
            get { return _departmentName; }
            set { _departmentName = value; }
        }

        #endregion ˽�г�Ա
    }
}
