using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Genaric_Interface
{
    internal class ProductRepository : IRepository<Product>
    {
        private readonly List<Product> _products = new();

        public void Add(Product item) => _products.Add(item);
        public void Delete(Product item) => _products.Remove(item);
        public List<Product> GetAll() => _products;
        public Product? GetById(int id) => _products.Find(p => p.Id == id);
        public Product Update(Product item)
        {
            var product = _products.Find(p => p.Id == item.Id);

            product.Name = item.Name;
            product.Price = item.Price;

            return product;
        }
    }
}
