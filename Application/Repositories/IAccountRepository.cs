using Application.ViewModels;
using Application.ViewModels.AccountViewModels;
using Application.ViewModels.ResponseModels;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IAccountRepository
    {
        Task<ResponseLoginModel> GetUserByEmailAndPassword(AccountLoginDTO account);

        Task<ResponseModel> AddAccount(AccountLoginDTO account, RoleEnums role);

        Task<Account> GetAccountByEmailAsync(string email);

        Task<ResponseLoginModel> RefreshToken(TokenModel token);

    }
}
