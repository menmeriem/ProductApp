using ProductApp.Interfaces;
using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Repositories
{
    public class InMemoryProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new();

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public List<Product> GetAll()
        {
            return _products.ToList();
        }

        public List<Product> Search(string name)
        {
            return _products
                .Where(p =>
                    p.Name.Contains(
                        name,
                        StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
