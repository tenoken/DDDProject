
using AutoMapper;
using DDDProject.Domain.Entities;
using DDDProject.MVC.ViewModels;

namespace DDDProject.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Produto, ProdutoViewModel>();
        }
    }
}