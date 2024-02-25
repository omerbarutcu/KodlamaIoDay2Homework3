using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public CategoryDal()
        {
            Category category1 = new Category
            {
                Id = 1,
                Name = "Programlama",
            };
            Category category2 = new Category
            {
                Id = 2,
                Name = "Tasarım",
            };
            _categories = new List<Category> { category1, category2 };
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            _categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public Category GetById(int id)
        {
            return _categories.SingleOrDefault(c => c.Id == id);
        }

        public void Update(Category category)
        {
            var categoryName = _categories.FirstOrDefault(c => c.Name == category.Name);
            if (categoryName != null)
            {
                categoryName.Name = category.Name;
            }
        }
    }
}
