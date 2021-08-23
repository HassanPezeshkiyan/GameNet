using GameNet.DataLayer.Context;
using GameNet.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNet.DataLayer.Services
{
    class OrderRepository : IOrderRepository
    {

        private readonly GameNetEntities db;

        public OrderRepository(GameNetEntities context)
        {
            db = context;
        }

        public decimal calAmount(int orderId)
        {

            var orderDetail = db.Orders.Find(orderId);

            return orderDetail.cost * orderDetail.quantity;
        }
    }
}
