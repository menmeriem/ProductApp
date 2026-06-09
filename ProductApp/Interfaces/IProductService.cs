using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Interfaces
{
    public interface IProductService
    {
        void AddProduct(string name, decimal price);

        List<Product> GetProducts();

        List<Product> SearchProducts(string name);
    }
}
