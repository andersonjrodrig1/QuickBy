using QuickBy.Dominio.Contracts;
using QuickBy.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBy.Repositorio.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository()
        {
        }
    }
}
