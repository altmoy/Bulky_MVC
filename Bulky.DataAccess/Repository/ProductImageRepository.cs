using Bulky.DataAccess.Repository.IRepository;
using Bulky.DataAccess.Data;
using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Bulky.DataAccess.Repository
{
    public class ProductImageRepository : Repository<ProductImage>, IProductImageRepository
    {
        private ApplicationDBContext _db;
        public ProductImageRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }
 


        public void Update(ProductImage obj)
        {
            _db.ProductImages.Update(obj);
        }
    }
}
