using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private ICourseService _courseService;

        public CourseManager(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public void Add(Course course)
        {
            _courseService.Add(course);
        }

        public void Delete(Course course)
        {
            _courseService.Delete(course);
        }

        public List<Course> GetAll()
        {
            return _courseService.GetAll();
        }

        public Course GetById(int id)
        {
            return _courseService.GetById(id);
        }

        public void Update(Course course)
        {
            _courseService.Update(course);
        }
    }
}
