using dotnetapp.Models;
using System.Linq;

namespace dotnetapp.Models
{
    public interface IProductService
    {
        public IQueryable<Product> GetProductList();
        public bool AddProduct(Product product);
        public bool DeleteProduct(int Id);
    }
    //Fill ur code
    public class ProductService : IProductService
    {
       private readonly ProductDBContext _dbContext;

        public ProductService(ProductDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IQueryable<Product> GetProductList()
        {
           return_dbContext.Products.ToList();
        }
        public bool AddProduct(Product product)
        {
            try
            {
                _dbContext.Products.Add(Product);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public bool DeleteProduct(int Id)
        {
            return false;
        }
    }
}