using System;
using System.Collections.Generic;
using System.Text;

namespace TesteApiRest.Negocio.Interfaces
{
    public interface IRepositoryProduct : IRepository<Product>
    {
        bool Exist(int sku);
    }
}
