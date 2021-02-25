using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Programsss
{
    class DatabaseContext
    {
        //Add a property
        public int Id
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
    }
}
