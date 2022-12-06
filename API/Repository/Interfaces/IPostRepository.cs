using System.Threading.Tasks;
using API.Models;
using API.Models.Request;

namespace API.Repository.Interfaces
{
    public interface IPostRepository : ICrudRepository<Post>
    {
        public Task<Post?> UpdatePost(UpdatePostRequest post);
    }
}