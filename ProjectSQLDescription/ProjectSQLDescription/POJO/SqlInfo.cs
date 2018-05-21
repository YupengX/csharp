using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSQLDescription.POJO
{
    class SqlInfo
    {
        private string sqlId;
        private string sql;
        private string sqlName;
        private string sqlDesc;
        private string createTime;
        private string userName;
        private List<SqlTableInfo> sqlTableList;
        private List<SqlParamInfo> sqlParamList;

        public string SqlId
        {
            get
            {
                return sqlId;
            }

            set
            {
                sqlId = value;
            }
        }

        public string Sql
        {
            get
            {
                return sql;
            }

            set
            {
                sql = value;
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

        public List<SqlTableInfo> SqlTableList
        {
            get
            {
                return sqlTableList;
            }

            set
            {
                sqlTableList = value;
            }
        }

        public List<SqlParamInfo> SqlParamList
        {
            get
            {
                return sqlParamList;
            }

            set
            {
                sqlParamList = value;
            }
        }

        public string SqlName
        {
            get
            {
                return sqlName;
            }

            set
            {
                sqlName = value;
            }
        }

        public string SqlDesc
        {
            get
            {
                return sqlDesc;
            }

            set
            {
                sqlDesc = value;
            }
        }

        public SqlInfo()
        {
                
        }
        public SqlInfo(string sqlId,string sql, string createTime,string userName)
        {
            this.SqlId = sqlId;
            this.Sql = sql;
            this.CreateTime = createTime;
            this.UserName = userName;
        }
    }
}
