﻿using BookManager.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Application.Queries.GetDevolutionById
{
    public class GetDevolutionByIdQuery : IRequest<List<DevolutionViewModel>>
    {
        public GetDevolutionByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
