using GameCenterDemo.Abstract;
using GameCenterDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenterDemo.Concrete
{
    public class CustomerManager : ICustomerService<Customer>
    {
        IPersonCheckService<Customer> _personcheckservice;
        public CustomerManager(IPersonCheckService<Customer> personcheckservice)
        {
            _personcheckservice = personcheckservice;
        }
        public void Delete(Customer entity)
        {
            Console.WriteLine("User is deleted!" + entity.Name);
        }

        public void GetAll(List<Customer> entities)
        {
            foreach (var item in entities)
            {
                Console.WriteLine("{0} , {1} , {2} , {3}"+item.Name+item.LastName+item.NatioalityId);
            }
        }

        public void Save(Customer entity)
        {
            
            if (_personcheckservice.CheckIfRealPerson(entity))
            {
                Console.WriteLine("User is Added!" + entity.Name);
            }
            else
            {
                Console.WriteLine("This person is not found in Mernis!");
            }
            
        }

        public void Update(Customer entity)
        {
            Console.WriteLine("User is Updated!" + entity.Name);
        }
    }
}
