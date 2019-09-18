﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class User
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String AvatarUrl { get; set; }
        public DateTime CriatedAt { get; set; }
    }
}
