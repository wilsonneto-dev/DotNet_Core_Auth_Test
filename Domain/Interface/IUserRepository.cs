using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interface
{
    interface IUserRepository
    {
        Boolean EmailExists(String email);
        
        User Login(String email, String hashPassword);
        
        User Insert(User user);
    }
}
