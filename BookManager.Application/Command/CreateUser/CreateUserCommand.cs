﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Application.Command.CreateUser
{
    public class CreateUserCommand : IRequest<int>
    {
        public CreateUserCommand(string? name, string? email)
        {
            Name = name;
            Email = email;
        }

        public string? Name { get; set; }

        public string? Email { get; set; }
    }
}
