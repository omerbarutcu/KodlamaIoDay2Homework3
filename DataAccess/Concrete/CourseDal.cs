using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;

        public CourseDal()
        {
            Course course1 = new Course
            {
                Id = 1,
                CategoryId = 1,
                InstructorId = 1,
                Name = "C#"
            };

            Course course2 = new Course
            {
                Id = 2,
                CategoryId = 1,
                InstructorId = 1,
                Name = "Java"
            };

            Course course3 = new Course
            {
                Id = 3,
                CategoryId = 1,
                InstructorId = 1,
                Name = "SQL"
            };

            _courses = new List<Course> { course1, course2, course3 };
        }

        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(Course course)
        {
            _courses.Remove(course);
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public Course GetById(int id)
        {
            return _courses.SingleOrDefault(c => c.Id == id);
        }

        public void Update(Course course)
        {
            var courseName = _courses.FirstOrDefault(c => c.Name == course.Name);
            if (courseName != null)
            {
                courseName.Name = course.Name;
            }
        }
    }
}
