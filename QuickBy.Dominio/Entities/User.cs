using System.Collections.Generic;

namespace QuickBy.Dominio.Entities
{
    public class User : Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        /// <summary>
        /// User have one or many Orders
        /// </summary>
        public virtual ICollection<Order> Orders { get; set; }

        public override void Validate()
        {
            ClearMessageValidation();

            if (string.IsNullOrEmpty(Email))
                AddMessageCritical("Email não informado.");

            if (string.IsNullOrEmpty(Password))
                AddMessageCritical("Senha não informada.");

            if (string.IsNullOrEmpty(Name))
                AddMessageCritical("Nome não informado.");

            if (string.IsNullOrEmpty(Surname))
                AddMessageCritical("Sobrenome não informado.");
        }
    }
}
