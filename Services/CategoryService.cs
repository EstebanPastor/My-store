using Microsoft.EntityFrameworkCore;
using My_Store.Entities;
using My_Store.Models;
using My_Store.Repositories;

namespace My_Store.Services
{
    public class CategoryService(GenericRepository<Category> _categoryRepository)

    {
        public async Task<IEnumerable<CategoryVM>> GetAllAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();

            var categoriesVM = categories.Select(item =>
           new CategoryVM
           {
               CategoryId = item.CategoryId,
               Name = item.Name
           }).ToList();

            return categoriesVM;
        }
    }
}
