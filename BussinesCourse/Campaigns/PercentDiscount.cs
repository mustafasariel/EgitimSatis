using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityCourse;

namespace BussinesCourse.Campaigns
{
    public class PercentDiscount : ICampaignService
    {
        public void AppyDiscount(List<Course> courses)
        {
            decimal discount = GetDisCount();
            foreach (var item in courses)
            {
                item.Price = (item.Price * (100 - discount))/100;
            }
        }
        public decimal GetDisCount()
        {
            return 25;
        }
    }

   
    
}
