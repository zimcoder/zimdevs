using System.Collections.Generic;
using System.Threading.Tasks;
using zimdevsapi.Models.Entities;

namespace zimdevsapi.Repositories.Interfaces
{
    public interface IBlogRepository
    {
        Task<IEnumerable<Blog>> GetBlogs();
        Task<IEnumerable<Blog>> GetDeveloperBlogs(int developerId);
        Task<IEnumerable<BlogPost>> GetBlogPosts(int blogId);
        Task<BlogPost> GetBlogPostAsync(BlogPost blogPost);
        void AddBlogPost(BlogPost blogPost);
        Task<BlogPost> UpdateBlogPost(BlogPost blogPost);


    }
}
