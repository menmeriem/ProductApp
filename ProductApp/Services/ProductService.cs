using ProductApp.Interfaces;
using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public void AddProduct(string name, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Product name is required.");

            var product = new Product
            {
                Name = name,
                Price = price
            };

            _repository.Add(product);
        }

        public List<Product> GetProducts()
        {
            return _repository.GetAll();
        }

        public List<Product> SearchProducts(string name)
        {
            return _repository.Search(name);
        }
    }
}
