using Application;
using Application.Interfaces;
using Application.Repositories;
using Application.Services;
using AutoMapper;
using Domain.Entities;
using Infrastructures.Mapper;
using Infrastructures.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructures
{
    public static class DenpendencyInjection
    {
        public static IServiceCollection AddInfrastructuresService(this IServiceCollection services, string databaseConnection)
        {

            services.AddIdentity<Account, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            services.AddDbContext<AppDbContext>(option => option.UseSqlServer(databaseConnection));

            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IAccountService, AccountService>();

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IStudentService, StudentService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddSingleton<ICurrentTime, CurrentTime>();

            services.AddAutoMapper(typeof(MapperConfigProfile).Assembly);


            return services;
        }
    }
}
