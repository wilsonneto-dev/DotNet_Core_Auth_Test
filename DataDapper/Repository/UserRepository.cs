using DataDapper.Base;
using Domain.Entity;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using Dapper.Contrib.Extensions;

namespace DataDapper.Repository
{
    class UserRepository : DapperDAO, IUserRepository
    {
        public UserRepository(String connectionString)
            :base(connectionString)
        {
            
        }

        public User Insert(User user)
        {
            user.Id = (int) this.Connection.Insert(user);
            return user;
        }

        public User GetByEmail(string email)
        {
            return this.Connection.QueryFirstOrDefault<User>(
                @"SELECT 
                    Id, Name, Email, password, AvatarUrl, CreatedAt
                FROM Users
                WHERE
                    Email = @Email;",
                new { Email = email }
            );
        }

        public User Login(string email, string hashPassword)
        {
            return this.Connection.QueryFirstOrDefault<User>(
                @"SELECT 
                    Id, Name, Email, password, AvatarUrl, CreatedAt
                FROM Users
                WHERE
                    Email = @Email AND Password = @Password;",
                new { Email = email, Password = hashPassword }
            );
        }
    }
}
