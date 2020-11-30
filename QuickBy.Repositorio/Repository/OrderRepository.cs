using QuickBy.Dominio.Contracts;
using QuickBy.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBy.Repositorio.Repository
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository()
        {
        }
    }
}
