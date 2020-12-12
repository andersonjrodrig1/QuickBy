using QuickBy.Dominio.ObjectValue;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBy.Dominio.Entities
{
    public class Order : Entity
    {
        public int Id { get; set; }
        public DateTime DateOrder { get; set; }

        #region User
        public int UserId { get; set; }
        public virtual User User { get; set; }
        #endregion

        public DateTime PreviousDeliveryDate { get; set; }
        public string CEP { get; set; }
        public string Estate { get; set; }
        public string City { get; set; }
        public string FullAddress { get; set; }
        public string Number { get; set; }

        #region FormPayment
        public int FormPaymentId { get; set; }
        public virtual FormPayment FormPayment { get; set; }
        #endregion

        /// <summary>
        /// Order have one ou many ItemsOrder
        /// </summary>
        public virtual ICollection<ItemOrder> ItemOrders { get; set; }

        public override void Validate()
        {
            ClearMessageValidation();

            if (DateOrder.Equals(DateTime.MinValue) || DateOrder.Equals(DateTime.MaxValue))
                AddMessageCritical("Critica - Data do pedido não informada.");

            if (UserId == 0)
                AddMessageCritical("Critica - Usuário do pedido não informado.");

            if (PreviousDeliveryDate.Equals(DateTime.MinValue) || PreviousDeliveryDate.Equals(DateTime.MaxValue))
                AddMessageCritical("Critica - Data de previsão de entrega não informada.");

            if (string.IsNullOrEmpty(CEP))
                AddMessageCritical("Critica - CEP não informado.");

            if (string.IsNullOrEmpty(Estate))
                AddMessageCritical("Critica  - Estado não informado.");

            if (string.IsNullOrEmpty(City))
                AddMessageCritical("Critica - Cidade não informada.");

            if (string.IsNullOrEmpty(FullAddress))
                AddMessageCritical("Critica - Endereço completo não informado.");

            if (string.IsNullOrEmpty(Number))
                AddMessageCritical("Critica - Número não informado.");

            if (!ItemOrders.Any())
                AddMessageCritical("Critica - Pedido deve ter pelo menos um item.");

            if (FormPaymentId == 0)
                AddMessageCritical("Critica - Forma de Pagamento não informada.");
        }
    }
}
