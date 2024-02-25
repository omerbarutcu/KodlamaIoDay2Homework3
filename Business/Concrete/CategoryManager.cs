using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryService _categoryService;

        public CategoryManager(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public void Add(Category category)
        {
            _categoryService.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryService?.Delete(category);
        }

        public List<Category> GetAll()
        {
            return _categoryService.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryService.GetById(id);
        }

        public void Update(Category category)
        {
            _categoryService.Update(category);
        }
    }
}
