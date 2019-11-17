using EntityCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDal.Abstract
{
   public interface ICourseDal
    {
        List<Course> GetCourses();
    }
}
