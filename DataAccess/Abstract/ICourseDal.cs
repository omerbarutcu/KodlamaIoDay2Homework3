using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICourseDal
    {
        List<Course> GetAll();
        Course GetById(int id);
        void Add(Course course);
        void Delete(Course course);
        void Update(Course course);
    }
}
