namespace QuickBy.Dominio.Entities
{
    public class Product : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public override void Validate()
        {
            ClearMessageValidation();

            if (string.IsNullOrEmpty(Name))
                AddMessageCritical("Critica - Nome do produto não informado.");

            if (string.IsNullOrEmpty(Description))
                AddMessageCritical("Critica - Descrição do produto não informada.");

            if (Price == 0)
                AddMessageCritical("Critica - Preço do produto não informado.");
        }
    }
}
