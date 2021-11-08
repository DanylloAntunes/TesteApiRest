using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteApiRest.Negocio;

namespace TesteApiRest.ServicoMapeador.Mapeadores.Mapeamento
{
    public class InventoryMap : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.Property(inventory => inventory.Id)
                .IsRequired();

            builder.Property(inventory => inventory.IdProduct)
                .IsRequired();

            builder.HasMany(Warehouse => Warehouse.Warehouses)
                 .WithOne(inventory => inventory.Inventory)
                 .HasForeignKey(Warehouse => Warehouse.IdInventory);
        }
    }
}