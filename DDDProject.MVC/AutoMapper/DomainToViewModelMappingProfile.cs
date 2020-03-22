
using AutoMapper;
using DDDProject.Domain.Entities;
using DDDProject.MVC.ViewModels;

namespace DDDProject.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {

        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ProdutoViewModel, Produto>();
        }
    }
}