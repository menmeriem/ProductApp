using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Interfaces
{
    public interface IProductRepository
    {
        void Add(Product product);

        List<Product> GetAll();

        List<Product> Search(string name);
    }
}
