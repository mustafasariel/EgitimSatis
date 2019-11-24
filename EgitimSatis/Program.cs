using BussinesCourse;
using BussinesCourse.Campaigns;
using CourseDal.Concrete;
using EntityCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimSatis
{
    class Program
    {
        static void Main(string[] args)
        {
            ICourseService courseService = new CourseManager(new EfCourseDal(), new PercentDiscount());

            foreach (var item in courseService.GetCourses())
            {
                Console.WriteLine(item);
            }
        }
    }

  


   

}
