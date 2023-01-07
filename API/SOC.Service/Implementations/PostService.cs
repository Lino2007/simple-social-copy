using SOC.DataContracts.Models;
using SOC.DataContracts.Request;
using SOC.Repository.Interfaces;
using SOC.Service.Interfaces;

namespace SOC.Service.Implementations
{
    public class PostService : IPostService
    {
        private readonly IPostRepository postRepository;

        public PostService(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public async Task<Post> Add(Post entity)
        {
            return await postRepository.Add(entity);
        }

        public async Task Delete(Guid id)
        {
            await postRepository.Delete(id);
        }

        public async Task<IEnumerable<Post>> GetAll()
        {
            return await postRepository.GetAll();
        }

        public async Task<Post> GetById(Guid id)
        {
            return await postRepository.GetById(id);
        }

        public async Task<Post> Update(Post entity)
        {
            return await postRepository.Update(entity);
        }

        public async Task<Post> Update(UpdatePostRequest entity)
        {
            return await postRepository.Update(entity);
        }
    }
}