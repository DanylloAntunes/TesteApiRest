using System;
using System.Collections.Generic;
using System.Text;

namespace TesteApiRest.ServicoMapeador.Infraestrutura
{
    public interface IConverter<TDto, TObj>
    {
        TObj ConverterToObject(TDto dto);
        TDto ConverterToDto(TObj objeto);
        TObj ConverterToUpdate(TObj objeto, TDto dto);
    }
}
