﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Domain.Entities
{
    public class User : BaseEntity
    {
        public User(string? name, string? email)
        {
            Name = name;
            Email = email;
        }

        public string? Name { get; set; }

        public string? Email { get; set; }
    }
}
