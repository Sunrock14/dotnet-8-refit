using Refit.Mvc.Helpers;

namespace Refit.Mvc.Extensions
{
    public static class ServiceCollector
    {
        public static void LoadRefitConfiguration(this WebApplicationBuilder builder)
        {

            //Appsetting içerisinden base url'i al
            //var appSettings = builder.Configuration.GetSection("AppSettings:RequestUrl").Value;

            ////İstek atılacak base url 
            //builder.Services.AddRefitClient<IApiService>().ConfigureHttpClient(c => c.BaseAddress = new Uri("https://localhost:7041"));

        }
    }
}