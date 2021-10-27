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
        public IShopRepository ShopRepository {
            get {
                if (_shopRepository == null) {
                    _shopRepository = new ShopRepository(db);
                }
                return _shopRepository;
            }
        }

        private GenericRepository<Order> _orderRepository;
        public GenericRepository<Order> OrderRepository {
            get {
                if (_orderRepository == null) {
                    _orderRepository = new GenericRepository<Order>(db);
                }
                return _orderRepository;
            }
        }
        private IOrderRepository _order;
        public IOrderRepository Orders {
            get {
                if (_order == null) {
                    _order = new OrderRepository(db);
                }
                return _order;
            }
        }
        private IConsoleRepository _console;
        public IConsoleRepository Console {
            get {
                if (_console == null) {
                    _console = new ConsoleRepository(db);
                }
                return _console;
            }
        }
        private GenericRepository<User> _user;
        public GenericRepository<User> User {
            get {
                if (_user == null) {
                    _user = new GenericRepository<User>(db) ;
                }
                return _user;
            }
        }
        private IUserRepository _users;
        public IUserRepository Users {
            get {
                if (_users == null) {
                    _users = new UserRepository(db);
                }
                return _users;
            }
        }
        public void Save() {
            db.SaveChanges();
        }
        public void Dispose() {
            db.Dispose();
        }
    }
}

