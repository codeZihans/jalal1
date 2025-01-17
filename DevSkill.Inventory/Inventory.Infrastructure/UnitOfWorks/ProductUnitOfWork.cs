﻿using DevSkill.Inventory.Application;
using DevSkill.Inventory.Domain.RepositoryContracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill.Inventory.Infrastructure.UnitOfWorks
{
    public class ProductUnitOfWork : UnitOfWork,IProductUnitOfWork
    {
        public   IProductRepository ProductRepository { get; private set; }
        public ProductUnitOfWork(ProductDbContext dbContext ,
            IProductRepository productRepository) : base(dbContext)
        {
            ProductRepository = productRepository;
            
        }
    }
}
