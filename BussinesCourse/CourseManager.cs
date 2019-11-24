using System.Collections.Generic;
using BussinesCourse.Campaigns;
using CourseDal.Abstract;
using CourseDal.Concrete;
using EntityCourse;

namespace BussinesCourse
{
    public class CourseManager : ICourseService
    {
        ICourseDal _dal;
        ICampaignService _campaignService;
        public CourseManager(ICourseDal courseDal, ICampaignService campaignService)
        {
            _dal = courseDal;
            _campaignService = campaignService;
        }
        public List<Course> GetCourses()
        {
            List<Course> courses = _dal.GetCourses();
            _campaignService.AppyDiscount(courses);

            return courses;
        }

    }
}