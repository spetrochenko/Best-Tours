﻿using System.Collections.Generic;
using BT.Common.Enum;

namespace BT.Dom.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public ICollection<Tour> Tours { get; set; }

        public Roles Role { get; set; }
    }
}
