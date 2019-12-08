using AutoMapper;
using WP.MvcIntermediario.Application.ViewModels;
using WP.MvcIntermediario.Dominio.Models;

namespace WP.MvcIntermediario.Application.AutoMapper
{
    class ViewModelToDomainMappingProfile: Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<EnderecoViewModel, Endereco>();
        }
    }
}
