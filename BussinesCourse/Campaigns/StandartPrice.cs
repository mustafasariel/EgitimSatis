using EntityCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesCourse.Campaigns
{
    public class StandartPrice : ICampaignService
    {
        public void AppyDiscount(List<Course> courses)
        {
            decimal price = GetStandartPrice();
            foreach (var item in courses)
            {
                item.Price = price;
            }
        }
        public decimal GetStandartPrice()
        {
            return 44;
        }
    }
}
