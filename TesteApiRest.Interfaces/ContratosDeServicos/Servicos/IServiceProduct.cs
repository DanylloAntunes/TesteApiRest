using System;
using System.Collections.Generic;
using System.Text;
using TesteApiRest.Interfaces.ContratosDeServicos.Dados;

namespace TesteApiRest.Interfaces.ContratosDeServicos.Servicos
{
    public interface IServiceProduct
    {
        DtoProduct Get(int codigo);
        void Save(DtoProduct dto);
        void Update(DtoProduct dto);
        void Remove(int sku);
    }
}
