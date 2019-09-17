using DataDapper.Base;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataDapper.Repository
{
    class UserRepository : DapperDAO, IUserRepository
    {
        public UserRepository(String connectionString)
            :base(connectionString)
        {
            
        }
    }
}
