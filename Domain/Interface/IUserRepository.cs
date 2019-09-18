using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interface
{
    public interface IUserRepository
    {
        public User Insert(User user);

        public User GetByEmail(String email);
        
        public User Login(String email, String hashPassword);
        
    }
}
