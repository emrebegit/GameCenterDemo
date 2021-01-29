using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenterDemo.Abstract
{
    public interface IPersonCheckService<T>
    {
        public bool CheckIfRealPerson(T entity);
    }
}
