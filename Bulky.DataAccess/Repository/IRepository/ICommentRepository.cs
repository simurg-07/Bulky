using Bulky.Models.Models.Concrete;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface ICommentRepository : IRepository<Comment>
    {
        void Update(Comment obj);
    }
}