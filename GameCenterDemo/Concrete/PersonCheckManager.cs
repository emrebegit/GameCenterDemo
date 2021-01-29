using GameCenterDemo.Abstract;
using GameCenterDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenterDemo.Concrete
{
    public class PersonCheckManager : IPersonCheckService<Customer>
    {
        public bool CheckIfRealPerson(Customer entity)
        {
            return true;
        }

     
    }
}
