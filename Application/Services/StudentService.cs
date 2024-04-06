using Application.Interfaces;
using Application.Repositories;
using Application.ViewModels;
using Application.ViewModels.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository) 
        { 
            _studentRepository = studentRepository;
        }
        public async Task<ResponseLoginModel> LoginWithEmailAsync(string email)
        {
            return await _studentRepository.LoginStudentAsync(email);
        }

        public async Task<ResponseLoginModel> RefreshToken(TokenModel token)
        {
            return await _studentRepository.RefreshTokenStudent(token);
        }
    }
}
