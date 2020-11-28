using QuickBy.Dominio.ObjectValue;
using System;
using System.Collections.Generic;

namespace QuickBy.Dominio.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateOrder { get; set; }
        public int UserId { get; set; }
        public DateTime PreviousDeliveryDate { get; set; }
        public string CEP { get; set; }
        public string Estate { get; set; }
        public string City { get; set; }
        public string FullAddress { get; set; }
        public string Number { get; set; }
        public int FormPaymentId { get; set; }
        public FormPayment FormPayment { get; set; }

        /// <summary>
        /// Order have one ou many ItemsOrder
        /// </summary>
        public ICollection<ItemOrder> ItemOrders { get; set; }
    }
}
