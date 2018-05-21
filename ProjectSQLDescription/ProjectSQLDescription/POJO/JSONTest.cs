using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSQLDescription.POJO
{
    class JSONTest
    {
        private string id;
        private string name;
        private List<string> list;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public List<string> List
        {
            get
            {
                return list;
            }

            set
            {
                list = value;
            }
        }
        public JSONTest()
        {

        }
        public JSONTest(string id,string name,List<string> list)
        {
            this.id = id;
            this.name = name;
            this.list = list;
        }
    }
}
