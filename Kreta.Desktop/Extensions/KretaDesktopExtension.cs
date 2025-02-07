using Kreta.HttpService.Services;
using Kreta.Shared.Assamblers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Kreta.Desktop.Extensions
{
    public static class KretaDesktopExtension
    {

        public static void ConfigureHttpCliens(this IServiceCollection services)
        {
            services.AddHttpClient("KretaApi", options =>
            {
                options.BaseAddress = new Uri("https://localhost:7090/");
            });
        }

        public static void ConfigureApiServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentHttpService, StudentHttpService>();
            services.AddScoped<ITeacherHttpService, TeacherHttpService>();
            services.AddScoped<IParentHttpService, ParentHttpService>();
            services.AddScoped<IEducationLavelService, EducationLevelHttpService>();
            services.AddScoped<IGradeHttpService, GradeHttpService>();
            services.AddScoped<IPublicSpaceHttpService, PublicSpaceHttpService>();
            services.AddScoped<ISchoolClassHttpService, SchoolClassHttpService>();
            services.AddScoped<ISubjectHttpService, SubjectHttpService>();
            services.AddScoped<ISubjectTypeHttpService, SubjectTypeHttpService>();
            services.AddScoped<ITypeOfEducationHttpService, TypeOfEducationHttpService>();
            services.AddScoped<IEducationLavelService, EducationLevelHttpService>();

            services.AddScoped<ISchoolClassSubjectsHttpService, SchoolClassSubjectsHttpService>();

        }

        public static void ConfigureAssamblers(this IServiceCollection services)
        {
            services.AddScoped<TeacherAssambler>();
            services.AddScoped<GradeAssambler>();
            services.AddScoped<ParentAssambler>();
            services.AddScoped<StudentAssambler>();
            services.AddScoped<SubjectAssambler>();
            services.AddScoped<EducationLevelAssambler>();
            services.AddScoped<SchoolClassAssambler>();
            services.AddScoped<AddressAssambler>();
            services.AddScoped<PublicSpaceAssambler>();
            services.AddScoped<SchoolClassAssambler>();
            services.AddScoped<TypeOfEducationAssambler>();
            services.AddScoped<EducationLevelAssambler>();

            services.AddScoped<SchoolClassSubjectsAssambler>();
        }
    }
}
