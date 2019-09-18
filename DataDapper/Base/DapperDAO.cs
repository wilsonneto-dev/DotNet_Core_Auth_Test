using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using Dapper.Contrib;

namespace DataDapper.Base
{
    abstract class DapperDAO
    {
        internal SqlConnection Connection;
        internal DapperDAO(String connectionString)
        {
            this.Connection = new SqlConnection(connectionString);
        }
    }
}
