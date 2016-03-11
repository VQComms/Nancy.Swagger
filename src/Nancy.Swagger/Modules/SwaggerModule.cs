using Nancy.Swagger.Services;

namespace Nancy.Swagger.Modules
{
    [SwaggerApi]
    public class SwaggerModule : LegacyNancyModule
    {
        public SwaggerModule(ISwaggerMetadataConverter converter)
            : base(SwaggerConfig.ResourceListingPath)
        {
            Get["/"] = _ => converter.GetResourceListing().ToJson();

            Get["/{resourcePath*}"] = _ => converter.GetApiDeclaration("/" + _.resourcePath).ToJson();
        }
    }
}