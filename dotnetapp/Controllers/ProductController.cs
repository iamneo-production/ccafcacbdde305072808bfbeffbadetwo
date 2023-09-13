using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnetapp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace dotnetapp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
    private readonly IProductService productService;

    public ProductController(IProductService _productService)
    {
      this.productService = _productService;
    }

    [HttpGet]
    public IQueryable<Product> GetProductList()
    {
        return _productServices.GetAll();
    }

    [HttpPost]
    public bool AddProduct(Product newProduct)
    {         
      if (_productService.AddProduct(product))
      return Ok("Product added sucessfully");
      return BadRequest("Failed to add product");            
    } 

    [HttpDelete("{id}")]
    public bool DeleteProduct (int id)
    {
      if (_productService.DeleteProduct(id))
      return Ok("Product deleted sucessfully");
      return NotFound("Product not f") 
    }
    }
}
