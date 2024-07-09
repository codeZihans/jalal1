using Blog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Services
{
    public class BlogPostManagementService : IBlogPostManagementService
    {
        private readonly IBlogUnitOfWork _blogUnitOfWork;
        public BlogPostManagementService(IBlogUnitOfWork blogUnitOfWork)
        {
            _blogUnitOfWork = blogUnitOfWork;
        }

        public void CreateBlogPost(BlogPost blogPost)
        {
            _blogUnitOfWork.BlogPostRepository.Add(blogPost);
            _blogUnitOfWork.Save();
        }
    }
}
