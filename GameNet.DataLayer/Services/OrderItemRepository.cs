using GameNet.DataLayer.Context;
using GameNet.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNet.DataLayer.Services
{
    class OrderItemRepository : IOrderItemRepository
    {

        private readonly GameNetEntities db;

        public OrderItemRepository(GameNetEntities context)
        {
            db = context;
        }

        public decimal calAmount(int orderId)
        {

            var orderDetail = db.OrderItems.Find(orderId);

            return orderDetail.cost * orderDetail.quantity;
        }
    }
}
