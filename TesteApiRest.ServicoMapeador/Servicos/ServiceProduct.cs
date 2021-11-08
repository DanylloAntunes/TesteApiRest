using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TesteApiRest.Interfaces.ContratosDeServicos.Dados;
using TesteApiRest.Interfaces.ContratosDeServicos.Servicos;
using TesteApiRest.Negocio;
using TesteApiRest.Negocio.Interfaces;
using TesteApiRest.Negocio.Validadores;
using TesteApiRest.ServicoMapeador.Infraestrutura;
using TesteApiRest.ServicoMapeador.Infraestutura;
using TesteApiRest.ServicoMapeador.Mapeadores.Repositorios;
using TesteApiRest.ServicoMapeador.Servicos.Conversores;

namespace TesteApiRest.ServicoMapeador.Servicos
{
    public class ServiceProduct : Service<DtoProduct, Product>, IServiceProduct
    {
        public ServiceProduct(ContextoBD contexto) : base(contexto)
        {
        }

        protected override IConverter<DtoProduct, Product> GetConverter()
        {
            return new ConverterProduct();
        }

        protected override Product GetObjet(DtoProduct dto)
        {
            return this.GetRepository().Get(dto.Sku);
        }

        protected override IRepository<Product> GetRepository()
        {
            return new RepositoryProduct(this.contexto);
        }

        protected override ValidacoesObjeto<Product> GetValidator()
        {
            return new ValidacoesProduct((IRepositoryProduct)this.GetRepository());
        }
    }
}
