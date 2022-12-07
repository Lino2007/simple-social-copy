using System.Threading.Tasks;
using SOC.DataContracts.Models;
using SOC.DataContracts.Request;

namespace SOC.Repository.Interfaces
{
    public interface IPostRepository : ICrudRepository<Post>
    {
        public Task<Post?> UpdatePost(UpdatePostRequest post);
    }
}