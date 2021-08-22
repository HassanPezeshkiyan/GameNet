using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNet.DataLayer.Repositories
{
    public interface IShopRepository
    {
        List<Shop> GetAllFood();
        bool UpdateFood(Shop shop);
        bool InsertFood(Shop shop);
        bool DeleteFood(Shop shop);
        bool DeleteFood(int shopId);
        bool DeleteFood(string nameShop);
        Shop GetShopById(int id);
     }
}
