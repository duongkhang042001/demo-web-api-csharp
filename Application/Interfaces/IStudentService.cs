using Application.ViewModels;
using Application.ViewModels.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IStudentService
    {
        public Task<ResponseLoginModel> LoginWithEmailAsync(string email);

        public Task<ResponseLoginModel> RefreshToken(TokenModel token);
    }
}
