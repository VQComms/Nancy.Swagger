using Nancy.Bootstrapper;
using Nancy.Swagger.Services;

namespace Nancy.Swagger
{
    [SwaggerApi]
    public class SwaggerRegistrations : Registrations
    {
        public SwaggerRegistrations(ITypeCatalog typeCatalog)  : base(typeCatalog)
        {
            RegisterWithDefault<ISwaggerMetadataProvider>(typeof(DefaultSwaggerMetadataProvider));
            RegisterWithDefault<ISwaggerMetadataConverter>(typeof(DefaultSwaggerMetadataConverter));
            RegisterWithDefault<ISwaggerModelCatalog>(typeof(DefaultSwaggerModelCatalog));
            RegisterAll<ISwaggerModelDataProvider>();
        }
    }
}