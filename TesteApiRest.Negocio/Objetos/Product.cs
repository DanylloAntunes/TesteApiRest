using System;

namespace TesteApiRest.Negocio
{
    public class Product
    {
        public Guid Id { get; set; }

        public int Sku { get; set; }

        public string Name { get; set; }

        public Inventory Inventory { get; set; }

        public bool IsMarketable { get { return Inventory?.Quantity > 0; } }
    }
}
