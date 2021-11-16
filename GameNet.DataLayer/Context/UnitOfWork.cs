﻿using GameNet.DataLayer.Repositories;
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

        private GenericRepository<OrderItem> _orderRepository;
        public GenericRepository<OrderItem> OrderRepository {
            get {
                if (_orderRepository == null) {
                    _orderRepository = new GenericRepository<OrderItem>(db);
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
        private GenericRepository<Console> _console;
        public GenericRepository<Console> Console {
            get {
                if (_console == null) {
                    _console = new GenericRepository<Console>(db);
                }
                return _console;
            }
        }
        private IConsoleRepository _consolee;
        public IConsoleRepository Consolee {
            get {
                if (_consolee == null) {
                    _consolee = new ConsoleRepository(db);
                }
                return _consolee;
            }
        }

        private GenericRepository<User> _user;
        public GenericRepository<User> User {
            get {
                if (_user == null) {
                    _user = new GenericRepository<User>(db);
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
        private GenericRepository<Customer> _customer;
        public GenericRepository<Customer> Customer {
            get {
                if (_customer == null) {
                    _customer = new GenericRepository<Customer>(db);
                }
                return _customer;
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

