using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorService _instructorService;

        public InstructorManager(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        public void Add(Instructor instructor)
        {
            _instructorService.Add(instructor);
        }

        public void Delete(Instructor ınstructor)
        {
            _instructorService.Delete(ınstructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructorService.GetAll();
        }

        public Instructor GetById(int id)
        {
            return _instructorService.GetById(id);
        }

        public void Update(Instructor instructor)
        {
            _instructorService.Update(instructor);
        }
    }
}
