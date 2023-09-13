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
           return _dbContext.Products.ToList();
        }
        public bool AddProduct(Product product)
        {
           
                _dbContext.Products.Add(Product);
                if(_dbContext.SaveChanges()>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            
            
        }

        public bool DeleteProduct(int Id)
        {
            var product = _dbContext.Products.Find(id);
            if(product !=null)
            {
                _dbContext.Products.Remove(product);
                if(_dbContext.SaveChanges()>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            return false;
        }
    }
}