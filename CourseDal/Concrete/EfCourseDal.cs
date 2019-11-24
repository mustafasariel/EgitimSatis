using CourseDal.Abstract;
using EntityCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDal.Concrete
{
    public class EfCourseDal : ICourseDal
    {
        public List<Course> GetCourses()
        {
            List<Course> courses = new List<Course>()
            {
                new Course(){Id=1,Name="C#",Price=100},
                new Course(){Id=2,Name="Sql",Price=100},
                new Course(){Id=3,Name="net core",Price=100}
            };
            return courses;
        }
    }
}
