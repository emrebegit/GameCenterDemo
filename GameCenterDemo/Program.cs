using GameCenterDemo.Adapters;
using GameCenterDemo.Concrete;
using System;

namespace GameCenterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager custommanage = new CustomerManager(new MernisServiceAdapter());
            custommanage.Save(new Entities.Customer
            {
                Name="Hüseyin Emre",
                LastName="Begit",
                DateofBirth=new DateTime(1996,11,12),
                NatioalityId="3584"
            });
            SalesManager salesmang = new SalesManager(new Entities.Customer(),new Entities.Campaign());
            salesmang.Save(
                new Entities.Sales
                {
                    Id = 1,
                    ProductId = 2,
                    Piece = 100,
                    TotalAmount=300
                });
            CampaignManager campa = new CampaignManager();
            campa.Save(
                new Entities.Campaign{ 
                Id=1,
                Percent=08
                });
            Console.ReadLine();
        }
    }
}
