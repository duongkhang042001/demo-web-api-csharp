using Application;
using Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructures
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;
        private readonly IProductRepository _productRepository;

        public UnitOfWork(AppDbContext dbContext, IProductRepository productRepository) 
        { 
            _dbContext = dbContext;
            _productRepository = productRepository;
        }
        public IProductRepository ProductRepository => _productRepository;

        public async Task<int> SaveChangeAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
