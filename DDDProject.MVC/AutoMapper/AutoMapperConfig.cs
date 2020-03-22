using AutoMapper;

namespace DDDProject.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public AutoMapperConfig()
        {
            RegisterMappings();
        }

        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}