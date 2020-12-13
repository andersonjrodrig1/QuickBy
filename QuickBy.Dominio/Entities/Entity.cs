using System.Collections.Generic;
using System.Linq;

namespace QuickBy.Dominio.Entities
{
    public abstract class Entity
    {
        private List<string> _messagesValidation { get; set; }

        private List<string> messagesValidation
        {
            get
            {
                return _messagesValidation ?? (_messagesValidation = new List<string>());
            }
        }

        protected void ClearMessageValidation() => _messagesValidation.Clear();

        protected void AddMessageCritical(string message) => messagesValidation.Add(message);

        public abstract void Validate();

        protected bool IsValid
        {
            get
            {
                return !messagesValidation.Any();
            }
        }
    }
}
