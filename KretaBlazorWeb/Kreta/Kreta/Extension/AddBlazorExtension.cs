using Blazored.LocalStorage;
using Kreta.HttpService.Services;
using Kreta.Shared.Assamblers;
using Kreta.ViewModel;
using KretaWeb.Components.Layout;
using MudBlazor.Services;

namespace KretaWeb.Extension
{
    public static class AddBlazorExtension
    {
        public static void AddBlazor(this IServiceCollection services)
        {
            services.AddMudServices();
            services.AddBlazoredLocalStorage();
            services.AddServices();
            services.SetUpHttpClient();
        }

        private static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ThemeService>();

            services.AddScoped<StudentAssambler>();
            services.AddScoped<TypeOfEducationAssambler>();

            services.AddScoped<IStudentHttpService, StudentHttpService>();
            services.AddScoped<IStudentViewModelBase, StudentViewModelBase>();

            services.AddScoped<ITypeOfEducationViewModel, TypeOfEducationViewModel>();
            services.AddScoped<ITypeOfEducationHttpService, TypeOfEducationHttpService>();
        }

        private static void SetUpHttpClient(this IServiceCollection services)
        {
            services.AddHttpClient("KretaApi", options =>
            {
                options.BaseAddress = new Uri("https://localhost:7090/");
            });
        }
    }
}
