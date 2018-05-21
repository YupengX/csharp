using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSQLDescription.POJO
{
    class SqlTableInfo
    {
        private string tId;
        private string tName;
        private string tDesc;

        public string TId
        {
            get
            {
                return tId;
            }

            set
            {
                tId = value;
            }
        }

        public string TName
        {
            get
            {
                return tName;
            }

            set
            {
                tName = value;
            }
        }

        public string TDesc
        {
            get
            {
                return tDesc;
            }

            set
            {
                tDesc = value;
            }
        }
        public SqlTableInfo()
        {

        }
        public SqlTableInfo(string tId,string tName)
        {
            this.TId = tId;
            this.TName = tName;
        }
    }
}
