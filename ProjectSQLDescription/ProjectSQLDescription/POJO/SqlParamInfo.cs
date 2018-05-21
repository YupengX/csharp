using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSQLDescription.POJO
{
    class SqlParamInfo
    {
        private string pId;
        private string pName;
        private string pDesc;

        public string PId
        {
            get
            {
                return pId;
            }

            set
            {
                pId = value;
            }
        }

        public string PName
        {
            get
            {
                return pName;
            }

            set
            {
                pName = value;
            }
        }

        public string PDesc
        {
            get
            {
                return pDesc;
            }

            set
            {
                pDesc = value;
            }
        }
        public SqlParamInfo()
        {

        }
        public SqlParamInfo(string pId,string pName)
        {
            this.PId = pId;
            this.PName = pName;
        }
    }
}
