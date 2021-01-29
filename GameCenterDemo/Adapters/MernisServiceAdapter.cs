using GameCenterDemo.Abstract;
using GameCenterDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ServiceReference1;
using System.Threading.Tasks;

namespace GameCenterDemo.Adapters
{
    public class MernisServiceAdapter : IPersonCheckService<Customer>
    {
        public bool CheckIfRealPerson(Customer entity)
        {
            return TaskAsync(entity).Result;
        }
        public static async Task<bool> TaskAsync(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var state = await (client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NatioalityId), customer.Name.ToUpper(),
                customer.Name.ToUpper(), customer.DateofBirth.Year));

            Console.WriteLine("{0} id,login is successfull!!Person is found",customer.NatioalityId);
            return state.Body.TCKimlikNoDogrulaResult;
        }
    }
}
