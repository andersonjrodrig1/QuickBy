namespace QuickBy.Dominio.Entities
{
    public class ItemOrder : Entity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public override void Validate()
        {
            ClearMessageValidation();

            if (ProductId == 0)
                AddMessageCritical("Critica - Item de Produto não possui produto.");

            if (Quantity == 0)
                AddMessageCritical("Critica - Quantidade de Produto não informada.");
        }
    }
}
