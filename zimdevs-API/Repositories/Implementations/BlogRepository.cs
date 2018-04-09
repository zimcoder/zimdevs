using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using zimdevsapi.Models.Entities;
using zimdevsapi.Repositories.Interfaces;

namespace zimdevsapi.Repositories.Implementations
{
    public class BlogRepository : IBlogRepository
    {
        public BlogRepository(ZimDevsDbContext context)
        {
            Context = context;
        }

        public ZimDevsDbContext Context { get; }

        public void AddBlogPost(BlogPost blogPost)
        {
            Context.BlogPosts.Add(blogPost);
        }

        public async Task<BlogPost> GetBlogPostAsync(BlogPost blogPost)
        {
            return await Context.BlogPosts.FindAsync(blogPost);
            //await Context.BlogPosts.FindAsync(); //TODO: Learn to use this method effectively
        }

        public Task<IEnumerable<BlogPost>> GetBlogPosts(int blogId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Blog>> GetBlogs()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Blog>> GetDeveloperBlogs(int developerId)
        {
            throw new NotImplementedException();
        }

        public Task<BlogPost> UpdateBlogPost(BlogPost blogPost)
        {
            throw new NotImplementedException();
        }
    }
}
