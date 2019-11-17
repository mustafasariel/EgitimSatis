using EntityCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesCourse
{
    public interface ICourseService
    {
        List<Course> GetCourses();
    }
}
