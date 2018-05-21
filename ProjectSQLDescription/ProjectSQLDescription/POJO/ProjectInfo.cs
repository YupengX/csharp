using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSQLDescription.POJO
{
    class ProjectInfo
    {
        private string projectId;
        private string projectName;
        private string projectDescription;
        private string createTime;
        private string userName;
        private List<SqlInfo> sqlList;
        public ProjectInfo()
        {

        }
        public ProjectInfo(string projectName, string projectDescription, string createTime, string userName)
        {
            this.projectName = projectName;
            this.projectDescription = projectDescription;
            this.createTime = createTime;
            this.userName = userName;
        }
        public string ProjectName
        {
            get
            {
                return projectName;
            }

            set
            {
                projectName = value;
            }
        }

        public string ProjectDescription
        {
            get
            {
                return projectDescription;
            }

            set
            {
                projectDescription = value;
            }
        }

        public string CreateTime
        {
            get
            {
                return createTime;
            }

            set
            {
                createTime = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public List<SqlInfo> SqlList
        {
            get
            {
                return sqlList;
            }

            set
            {
                sqlList = value;
            }
        }

        public string ProjectId
        {
            get
            {
                return projectId;
            }

            set
            {
                projectId = value;
            }
        }
    }
}
