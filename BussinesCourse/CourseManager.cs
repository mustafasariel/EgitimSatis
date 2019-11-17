using System.Collections.Generic;
using CourseDal.Abstract;
using CourseDal.Concrete;
using EntityCourse;

namespace BussinesCourse
{
    public class CourseManager : ICourseService
    {
        ICourseDal _dal;
        public CourseManager(ICourseDal courseDal)
        {
            _dal = courseDal;
        }
        public List<Course> GetCourses()
        {
          return  _dal.GetCourses();
        }
    }
}