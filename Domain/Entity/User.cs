using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    class User
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public DateTime CriatedAt { get; set; }
    }
}
