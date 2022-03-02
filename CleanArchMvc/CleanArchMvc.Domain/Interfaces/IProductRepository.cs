using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArchMvc.Domain.Entities;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface IProductRepository
    {
       Task<IEnumerable<Product>> GetProductsAsync();
         Task<Category> GetById(int? id);

         Task<Category> Create(Category category);
         Task<Category> Remove(Category category);
         Task<Category> Update(Category category); 
    }
}