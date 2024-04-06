using Application.Interfaces;
using Application.Repositories;
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

namespace Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository) 
        {
            _accountRepository = accountRepository;
        }

        public async Task<Account> GetAccountByEmailAsync(string email)
        {
            return await _accountRepository.GetAccountByEmailAsync(email);
        }

        public async Task<ResponseLoginModel> LoginAsync(AccountLoginDTO account)
        {
            return await _accountRepository.GetUserByEmailAndPassword(account);
        }

        public async Task<ResponseLoginModel> RefreshToken(TokenModel token)
        {
            return await _accountRepository.RefreshToken(token);
        }

        public async Task<ResponseModel> ResigerAsync(AccountLoginDTO account, RoleEnums role)
        {
            return await _accountRepository.AddAccount(account, role);
        }
    }
}
