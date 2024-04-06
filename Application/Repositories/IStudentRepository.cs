﻿using Application.ViewModels;
using Application.ViewModels.ResponseModels;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        public Task<ResponseLoginModel> LoginStudentAsync(string email);

        public Task<ResponseLoginModel> RefreshTokenStudent(TokenModel token);
    }
}
