﻿using Blog.Application;
using Blog.Domain.RepositoryContracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.UnitOfWorks
{
    public class BlogUnitOfWork : UnitOfWork, IBlogUnitOfWork
    {
        public IBlogPostRepository BlogPostRepository { get; private set; }
        public BlogUnitOfWork(BlogDbContext dbContext, 
            IBlogPostRepository blogPostRepository) : base(dbContext)
        {
            BlogPostRepository = blogPostRepository;
        }
    }
}