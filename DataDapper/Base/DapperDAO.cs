using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataDapper.Base
{
    abstract class DapperDAO
    {
        internal SqlConnection connection;
        internal DapperDAO(String connectionString)
        {
            this.connection = new SqlConnection(connectionString);
        }
    }
}
