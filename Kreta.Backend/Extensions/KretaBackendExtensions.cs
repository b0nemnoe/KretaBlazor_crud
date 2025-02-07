using Kreta.Backend.Context;
using Kreta.Backend.Repos;
using Kreta.Backend.Repos.Managers;
using Kreta.Backend.Repos.SwitchTables;
using Kreta.Backend.Services;
using Kreta.Shared.Assamblers;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Extensions
{
    public static class KretaBackendExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {

            services.AddCors(option =>
                 option.AddPolicy(name: "KretaCors",
                     policy =>
                     {
                         policy.WithOrigins("https://localhost:7020/")
                         .AllowAnyHeader()
                         .AllowAnyMethod();
                     }
                 )
            );
        }

        public static void ConfigureInMemoryContext(this IServiceCollection services)
        {
            string dbName = "Kreta" + Guid.NewGuid();
            services.AddDbContext<KretaInMemoryContext>(
                options => options.UseInMemoryDatabase(databaseName: dbName)
            );
        }

        public static void ConfigureRepoService(this IServiceCollection services)
        {
            services.AddScoped<ITeacherRepo, TeacherRepo<KretaInMemoryContext>>();
            services.AddScoped<IGradeRepo, GradeRepo<KretaInMemoryContext>>();
            services.AddScoped<IParentRepo, ParentRepo<KretaInMemoryContext>>();
            services.AddScoped<IStudentRepo, StudentRepo<KretaInMemoryContext>>();
            services.AddScoped<ISubjectRepo, SubjectRepo<KretaInMemoryContext>>();
            services.AddScoped<IEducationLevelRepo, EducationLevelRepo<KretaInMemoryContext>>();
            services.AddScoped<ISchoolClassRepo, SchoolClassRepo<KretaInMemoryContext>>();
            services.AddScoped<IAddressRepo, AddressRepo<KretaInMemoryContext>>();
            services.AddScoped<IPublicSpaceRepo, PublicSpaceRepo<KretaInMemoryContext>>();
            services.AddScoped<ITypeOfEducationRepo, TypeOfEducationRepo<KretaInMemoryContext>>();
            services.AddScoped<ISubjectTypeRepo, SubjectTypeRepo<KretaInMemoryContext>>();

            services.AddScoped<ISchoolClassStudentsRepo,SchoolClassStudentsRepo<KretaInMemoryContext>>();
            services.AddScoped<ISchoolClassSubjectsRepo, SchoolClassSubjectsRepo<KretaInMemoryContext>>();
            services.AddScoped<ITeacherTeachInSchoolClass,TeacherTeachInSchoolClassRepo<KretaInMemoryContext>>();            

            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<IStatisticRepo, StatisticRepo>();
        }

        public static void ConfigureAssamblers(this IServiceCollection services)
        {
            services.AddScoped<TeacherAssambler>();
            services.AddScoped<GradeAssambler>();
            services.AddScoped<ParentAssambler>();
            services.AddScoped<StudentAssambler>();
            services.AddScoped<SubjectAssambler>();
            services.AddScoped<TypeOfEducationAssambler>();
            services.AddScoped<EducationLevelAssambler>();
            services.AddScoped<SchoolClassAssambler>();
            services.AddScoped<AddressAssambler>();
            services.AddScoped<PublicSpaceAssambler>();
            services.AddScoped<SchoolClassAssambler>();
            services.AddScoped<TypeOfEducationAssambler>();

            services.AddScoped<SchoolClassSubjectsAssambler>();
            services.AddScoped<TeachersTeachInSchoolClassAssambler>();
            services.AddScoped<SchoolClassStudentsAssambler>();
        }

        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<ISchoolClassSubjectService, SchoolClassSubjectService>();
        }
    }
}
