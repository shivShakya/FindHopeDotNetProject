using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shivamProject
{
    internal class Connection
    {
        public string ConnectionString { get; private set; }

        public Connection()
        {
            this.ConnectionString = "Data Source=DESKTOP-UR174K2;Initial Catalog=FindHope;Integrated Security=True;";
        }


    }
}
