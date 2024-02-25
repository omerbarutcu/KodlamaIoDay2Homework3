﻿using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int id);
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);
    }
}
