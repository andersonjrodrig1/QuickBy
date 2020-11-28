using QuickBy.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBy.Dominio.ObjectValue
{
    public class FormPayment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsBoleto
        {
            get { return Id == FormPaymentTypeEnum.BOLETO.GetHashCode(); }
        }

        public bool IsCreditCard
        {
            get { return Id == FormPaymentTypeEnum.CREDIT_CARD.GetHashCode(); }
        }

        public bool IsDeposit
        {
            get { return Id == FormPaymentTypeEnum.DEPOSIT.GetHashCode(); }
        }

        public bool IsNone
        {
            get { return Id == FormPaymentTypeEnum.NONE.GetHashCode(); }
        }
    }
}
