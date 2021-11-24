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
        private GenericRepository<Shop> _shop;
        public GenericRepository<Shop> Shop
        {
            get
            {
                if (_shop == null)
                {
                    _shop = new GenericRepository<Shop>(db);
                }
                return _shop;
            }
        }
        private GenericRepository<OrderItem> _orderRepository;
        public GenericRepository<OrderItem> OrderRepository
        {
            get
            {
                if (_orderRepository == null)
                {
                    _orderRepository = new GenericRepository<OrderItem>(db);
                }
                return _orderRepository;
            }
        }
        private IOrderRepository _orders;
        public IOrderRepository Orders
        {
            get
            {
                if (_orders == null)
                {
                    _orders = new OrderRepository(db);
                }
                return _orders;
            }
        }
        private GenericRepository<Console> _console;
        public GenericRepository<Console> Console
        {
            get
            {
                if (_console == null)
                {
                    _console = new GenericRepository<Console>(db);
                }
                return _console;
            }
        }
        private IConsoleRepository _consolee;
        public IConsoleRepository Consolee
        {
            get
            {
                if (_consolee == null)
                {
                    _consolee = new ConsoleRepository(db);
                }
                return _consolee;
            }
        }

        private GenericRepository<User> _user;
        public GenericRepository<User> User
        {
            get
            {
                if (_user == null)
                {
                    _user = new GenericRepository<User>(db);
                }
                return _user;
            }
        }
        private IUserRepository _users;
        public IUserRepository Users
        {
            get
            {
                if (_users == null)
                {
                    _users = new UserRepository(db);
                }
                return _users;
            }
        }
        private GenericRepository<Customer> _customer;
        public GenericRepository<Customer> Customer
        {
            get
            {
                if (_customer == null)
                {
                    _customer = new GenericRepository<Customer>(db);
                }
                return _customer;
            }
        }
        private GenericRepository<Order> _order;
        public GenericRepository<Order> Order
        {
            get
            {
                if (_order == null)
                {
                    _order = new GenericRepository<Order>(db);
                }
                return _order;
            }
        }
        private GenericRepository<Invoice> _invoice;
        public GenericRepository<Invoice> Invoice
        {
            get
            {
                if (_invoice == null)
                {
                    _invoice = new GenericRepository<Invoice>(db);

                }
                return _invoice;

            }

        }

        private InvoiceReports _invoiceReports;
        public InvoiceReports InvoiceReports
        {
            get
            {
                if (_invoiceReports == null)
                {
                    _invoiceReports = new InvoiceReports(db);
                }
                return _invoiceReports;
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

