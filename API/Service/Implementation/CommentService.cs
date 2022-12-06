using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.Models.Request;
using API.Repository.Interfaces;
using API.Service.Interfaces;

namespace API.Service.Implementation
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

        public async Task<Comment?> GetById(Guid id)
        {
            return await commentRepository.GetById(id);
        }

        public async Task<Comment> Update(Comment entity)
        {
            return await commentRepository.Update(entity);
        }

        public async Task<Comment?> Update(UpdateCommentRequest entity)
        {
            return await commentRepository.UpdateComment(entity);
        }
    }
}