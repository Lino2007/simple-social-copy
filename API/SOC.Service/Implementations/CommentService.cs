using SOC.DataContracts.Models;
using SOC.DataContracts.Request;
using SOC.Repository.Interfaces;
using SOC.Service.Interfaces;

namespace SOC.Service.Implementations
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            this.commentRepository = commentRepository;
        }

        public async Task<Comment> Add(Comment entity)
        {
            return await commentRepository.Add(entity);
        }

        public async Task Delete(Guid id)
        {
            await commentRepository.Delete(id);
        }

        public async Task<IEnumerable<Comment>> GetAll()
        {
            return await commentRepository.GetAll();
        }

        public async Task<Comment> GetById(Guid id)
        {
            return await commentRepository.GetById(id);
        }

        public async Task<Comment> Update(Comment entity)
        {
            return await commentRepository.Update(entity);
        }

        public async Task<Comment> Update(UpdateCommentRequest entity)
        {
            return await commentRepository.Update(entity);
        }
    }
}