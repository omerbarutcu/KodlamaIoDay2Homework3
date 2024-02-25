using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;

        public InstructorDal()
        {
            Instructor instructor1 = new Instructor
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "Demiroğ",
                Description = "Hocaların hocası"
            };
            Instructor instructor2 = new Instructor
            {
                Id = 2,
                FirstName = "Halit",
                LastName = "Kalaycı",
                Description = "Hoca"
            };
            _instructors = new List<Instructor> { instructor1, instructor2 };
        }

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructors?.Remove(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public Instructor GetById(int id)
        {
            return _instructors.SingleOrDefault(i => i.Id == id);
        }

        public void Update(Instructor instructor)
        {
            var instructorToUpdate = _instructors.FirstOrDefault(i => i.Id == instructor.Id);
            if (instructorToUpdate != null)
            {
                instructorToUpdate.FirstName = instructor.FirstName;
                instructorToUpdate.LastName = instructor.LastName;
                instructorToUpdate.Description = instructor.Description;
            }
        }
    }
}
