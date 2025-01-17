﻿using System.Collections.Generic;
using BT.Dom.Entities;

namespace BT.Dom.DTO
{
    public class UserDTO
    {
        public string NickName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public decimal Amount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Tour> Tours { get; set; }
    }
}
