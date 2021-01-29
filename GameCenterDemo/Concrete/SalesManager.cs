using GameCenterDemo.Abstract;
using GameCenterDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenterDemo.Concrete
{
    public class SalesManager : ISalesService<Sales>
    {
        Customer customer;
        Campaign campaign;
        public SalesManager(Customer custom,Campaign campa)
        {
            customer = custom;
            campaign = campa;
        }
        public void Delete(Sales entity)
        {
            Console.WriteLine("{0} id sales is deleted!!", entity.Id);
        }

        public void GetAll(List<Sales> entities)
        {
            foreach (var item in entities)
            {
                item.TotalAmount =Convert.ToInt32(item.Piece-(item.Piece*campaign.Percent));
                Console.WriteLine("Id :{0},/n Product id: {1} , Piece: {2} , Total Amount: {3}",item.Id,item.ProductId,item.Piece,item.TotalAmount);
            }
        }

        public void Save(Sales entity)
        {
            entity.TotalAmount = Convert.ToInt32(entity.Piece - (entity.Piece * campaign.Percent));
            Console.WriteLine("This Sales is saved:{0},{1},{2},{3},{4}",entity.Id,entity.ProductId,entity.Piece,entity.TotalAmount,campaign.Percent);
        }

        public void Update(Sales entity)
        {
            entity.TotalAmount = Convert.ToInt32(entity.Piece - (entity.Piece * campaign.Percent));
            Console.WriteLine("This Sales is Updated:{0},{1},{2},{3},{4}", entity.Id, entity.ProductId, entity.Piece, entity.TotalAmount, campaign.Percent);
        }
    }
}
