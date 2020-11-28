﻿using System.Collections.Generic;

namespace QuickBy.Dominio.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        /// <summary>
        /// User have one or many Orders
        /// </summary>
        public ICollection<Order> Orders { get; set; }
    }
}
