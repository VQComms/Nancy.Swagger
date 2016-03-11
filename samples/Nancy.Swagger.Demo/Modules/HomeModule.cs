using Nancy.ModelBinding;
using Nancy.Swagger.Demo.Models;

namespace Nancy.Swagger.Demo.Modules
{
    public class HomeModule : LegacyNancyModule
    {
        public HomeModule()
        {
            Get["Home", "/"] = _ => "Hello Swagger! Visit http://localhost:3999/docs/index.html and enter http://localhost:3999/api-docs in the Swagger UI";

            Get["GetUsers", "/users"] = _ => new[] { new User { Name = "Vincent Vega", Age = 45 } };

            Post["PostUsers", "/users"] = _ =>
            {
                var result = this.BindAndValidate<User>();

                if (!ModelValidationResult.IsValid)
                {
                    return Negotiate.WithModel(new { Message = "Oops" })
                        .WithStatusCode(HttpStatusCode.UnprocessableEntity);
                }

                return Negotiate.WithModel(result).WithStatusCode(HttpStatusCode.Created);
            };
        }
    }
}