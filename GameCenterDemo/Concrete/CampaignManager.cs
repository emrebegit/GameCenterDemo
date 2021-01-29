using GameCenterDemo.Abstract;
using GameCenterDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenterDemo.Concrete
{
    public class CampaignManager : ICampaignService<Campaign>
    {     
        public void Delete(Campaign entity)
        {
            Console.WriteLine("{0} campaign is deleted!",entity.Id);
        }

        public void GetAll(List<Campaign> entities)
        {
            foreach (var item in entities)
            {
                Console.WriteLine("{0} id campaign is percent:{1}",item.Id,item.Percent);
            }
        }

        public void Save(Campaign entity)
        {
            Console.WriteLine("{0} id campaign is saved!!", entity.Id);
        }

        public void Update(Campaign entity)
        {
            Console.WriteLine("{0} id campaign is updated!!", entity.Id);
        }
    }
}
