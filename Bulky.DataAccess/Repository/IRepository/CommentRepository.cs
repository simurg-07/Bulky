using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        private readonly ApplicationDbContext _db;

        public CommentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        // Comment objesini günceller.
        public void Update(Comment obj)
        {
            _db.Comments.Update(obj);
        }

        // Belirli bir ürün için tüm yorumları getirir.
        public IEnumerable<Comment> GetCommentsByProductId(int productId)
        {
            return _db.Comments.Where(c => c.ProductId == productId).ToList();
        }
    }
}
