using System.Linq;
using TesteApiRest.Negocio;
using TesteApiRest.Negocio.Interfaces;
using TesteApiRest.ServicoMapeador.Infraestutura;

namespace TesteApiRest.ServicoMapeador.Mapeadores.Repositorios
{
    public class RepositoryProduct : Repository<Product>, IRepositoryProduct
    {
        public RepositoryProduct(ContextoBD contexto) : base(contexto)
        {
        }

        public bool Exist(int sku)
        {
            return this.Contexto.Set<Product>().Any(produto => produto.Sku == sku);
        }

        public override Product Get(int id)
        {
            return this.Contexto.Set<Product>().FirstOrDefault(produto => produto.Sku == id);
        }
    }
}
