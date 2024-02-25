using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IInstructorDal
    {
        List<Instructor> GetAll();
        Instructor GetById(int id);
        void Add(Instructor instructor);
        void Delete(Instructor instructor);
        void Update(Instructor instructor);
    }
}
