using QuickBy.Dominio.Contracts;
using QuickBy.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBy.Repositorio.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository()
        {
        }
    }
}
