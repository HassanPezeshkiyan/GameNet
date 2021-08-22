using GameNet.DataLayer.Repositories;
using GameNet.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNet.DataLayer.Context
{
    public class UnitOfWork : IDisposable

    {
        readonly GameNetEntities db = new GameNetEntities();
       
        private IShopRepository _shopRepository;
        public IShopRepository ShopRepository
        {
            get
            {
                if (_shopRepository == null)
                {
                    _shopRepository = new ShopRepository(db);
                }
                return _shopRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}

