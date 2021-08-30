using GameNet.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNet.DataLayer.Services
{
    class ShopRepository : IShopRepository
    {
        private readonly GameNetEntities db;

        public ShopRepository(GameNetEntities context)
        {
            db = context;
        }

        public virtual bool DeleteFood(int shopId)
        {
            try
            {
                var food = db.Shops.Find(shopId);
                DeleteFood(food);
                return true;

            }
            catch
            {

                return false;
            }
        }

        public virtual bool DeleteFood(string nameShop)
        {
            try
            {

                var foodId = db.Shops.Where(n => n.Name == nameShop).Select(n => n.Id).First();
                DeleteFood(foodId);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public virtual bool DeleteFood(Shop shop)
        {
            try
            {
                db.Entry(shop).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual List<Shop> GetAllFood()
        {
            return db.Shops.ToList();
        }

        public virtual bool InsertFood(Shop shop)
        {
            try
            {
                db.Shops.Add(shop);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public virtual bool UpdateFood(Shop shop)
        {
            var local = db.Set<Shop>().Local.FirstOrDefault(n => n.Id == shop.Id);
            if (local != null)
            {
                db.Entry(local).State = EntityState.Detached;
            }
            db.Entry(shop).State = EntityState.Modified;
            return true;
        }

        public virtual Shop GetShopById(int id)
        {
            return db.Shops.Find(id);

        }
    }
}
