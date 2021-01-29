using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenterDemo.Abstract
{
    public interface ICampaignService<T>
    {
        void Save(T entity);
        void Update(T entity);
        void Delete(T entity);
        void GetAll(List<T> entities);
    }
}
