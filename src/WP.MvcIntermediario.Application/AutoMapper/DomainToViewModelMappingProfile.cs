using AutoMapper;
using WP.MvcIntermediario.Application.ViewModels;
using WP.MvcIntermediario.Dominio.Models;

namespace WP.MvcIntermediario.Application.AutoMapper
{
    class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();
        }
    }
}
