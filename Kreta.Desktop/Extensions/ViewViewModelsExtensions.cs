using Kreta.Desktop.ViewModels;
using Kreta.Desktop.ViewModels.Administration;
using Kreta.Desktop.ViewModels.ControlPanel;
using Kreta.Desktop.ViewModels.Login;
using Kreta.Desktop.ViewModels.SchoolCitizens;
using Kreta.Desktop.ViewModels.SchoolClasses;
using Kreta.Desktop.ViewModels.SchoolGrades;
using Kreta.Desktop.ViewModels.SchoolSubjects;
using Kreta.Desktop.Views;
using Kreta.Desktop.Views.Administration;
using Kreta.Desktop.Views.ControlPanel;
using Kreta.Desktop.Views.Login;
using Kreta.Desktop.Views.SchoolCitizens;
using Kreta.Desktop.Views.SchoolClasses;
using Kreta.Desktop.Views.SchoolGrade;
using Kreta.Desktop.Views.SchoolSubjects;
using Microsoft.Extensions.DependencyInjection;

namespace KretaDesktop.Extensions
{
    public static class ViewViewModelsExtensions
    {
        public static void ConfigureViewViewModels(this IServiceCollection services)
        {
            // MainView
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainView>(s => new MainView()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });

            // LoginView
            services.AddSingleton<LoginViewModel>();
            services.AddSingleton<LoginView>(s => new LoginView()
            {
                DataContext = s.GetRequiredService<LoginViewModel>()
            });

            // ControlPanel
            services.AddSingleton<ControlPanelViewModel>();
            services.AddSingleton<ControlPanelView>(s => new ControlPanelView()
            {
                DataContext = s.GetRequiredService<ControlPanelViewModel>()
            });
            // School Citizens
            services.AddSingleton<SchoolCitizensViewModel>();
            services.AddSingleton<SchoolCitizensView>(s => new SchoolCitizensView()
            {
                DataContext = s.GetRequiredService<SchoolCitizensViewModel>()
            });
            // Students
            services.AddSingleton<StudentViewModel>();
            services.AddSingleton<StudentView>(s => new StudentView()
            {
                DataContext = s.GetRequiredService<StudentView>()
            });

            //Parents
            services.AddSingleton<ParentViewModel>();
            services.AddSingleton<ParentView>(s => new ParentView()
            {
                DataContext = s.GetRequiredService<ParentViewModel>()
            });

            //Teacher
            services.AddSingleton<TeacherViewModel>();
            services.AddSingleton<TeacherView>(s => new TeacherView()
            {
                DataContext = s.GetRequiredService<TeacherViewModel>()
            });


            //SchoolClass
            services.AddSingleton<SchoolClassesViewModel>();
            services.AddSingleton<SchoolClassesView>(s => new SchoolClassesView()
            {
                DataContext = s.GetRequiredService<SchoolClassesViewModel>()
            });
            
            //SchoolSubject
            services.AddSingleton<SchoolSubjectsViewModel>();
            services.AddSingleton<SchoolSubjectsView>(s => new SchoolSubjectsView()
            {
                DataContext = s.GetRequiredService<SchoolSubjectsViewModel>()
            });

            //SchoolOsztalyzatok
            services.AddSingleton<SchoolGradesViewModel>();
            services.AddSingleton<SchoolGradesView>(s => new SchoolGradesView()
            {
                DataContext = s.GetRequiredService<SchoolGradesViewModel>()
            });
            services.AddSingleton<ActualLessonGradesViewModel>();
            services.AddSingleton<ActualLessonGradesView>(s => new ActualLessonGradesView()
            {
                DataContext = s.GetRequiredService<ActualLessonGradesViewModel>()
            });
            services.AddSingleton<EndOfYearGradesViewModel>();
            services.AddSingleton<EndOfYearGradesView>(s => new EndOfYearGradesView()
            {
                DataContext = s.GetRequiredService<EndOfYearGradesViewModel>()
            });
            services.AddSingleton<HalfOfYearGradesViewModel>();
            services.AddSingleton<HalfOfYearGradesView>(s => new HalfOfYearGradesView()
            {
                DataContext = s.GetRequiredService<HalfOfYearGradesViewModel>()
            });
            services.AddSingleton<TeachedClassesGradesViewModel>();
            services.AddSingleton<TeachedClassesGradesView>(s => new TeachedClassesGradesView()
            {
                DataContext = s.GetRequiredService<TeachedClassesGradesViewModel>()
            });
            //SchoolClasses
            services.AddSingleton<SchoolClassesManagmentViewModel>();
            services.AddSingleton<SchoolClassesManagmentView>(s => new SchoolClassesManagmentView()
            {
                DataContext = s.GetRequiredService<SchoolClassesManagmentViewModel>()
            });
            services.AddSingleton<SchoolClassesSubjectsViewModel>();
            services.AddSingleton<SchoolClassesSubjectsView>(s => new SchoolClassesSubjectsView()
            {
                DataContext = s.GetRequiredService<SchoolClassesSubjectsViewModel>()
            });
            services.AddSingleton<SchoolClassesTeachersViewModel>();
            services.AddSingleton<SchoolClassesTeachersView>(s => new SchoolClassesTeachersView()
            {
                DataContext = s.GetRequiredService<SchoolClassesTeachersViewModel>()
            });
            services.AddSingleton<SchoolClassesTimeTableViewModel>();
            services.AddSingleton<SchoolClassesTimeTableView>(s => new SchoolClassesTimeTableView()
            {
                DataContext = s.GetRequiredService<SchoolClassesTimeTableViewModel>()
            });
            services.AddSingleton<SchoolClessesStudentsViewModel>();
            services.AddSingleton<SchoolClessesStudentsView>(s => new SchoolClessesStudentsView()
            {
                DataContext = s.GetRequiredService<SchoolClessesStudentsViewModel>()
            });
            // Subjects
            services.AddSingleton<SubjectsManagmentViewModel>();
            services.AddSingleton<SubjectsManagmentView>(s => new SubjectsManagmentView()
            {
                DataContext = s.GetRequiredService<SubjectsManagmentViewModel>()
            });
            services.AddSingleton<SubjectsOfSchoollClassesViewModel>();
            services.AddSingleton<SubjectsOfSchoollClassesView>(s => new SubjectsOfSchoollClassesView()
            {
                DataContext = s.GetRequiredService<SubjectsOfSchoollClassesViewModel>()
            });
            services.AddSingleton<SubjectsOfTeachersViewModel>();
            services.AddSingleton<SubjectsOfTeachersView>(s => new SubjectsOfTeachersView()
            {
                DataContext = s.GetRequiredService<SubjectsOfTeachersViewModel>()
            });
            // Administration
            services.AddSingleton<AdministrationViewModel>();
            services.AddSingleton<AdministrationView>(s => new AdministrationView()
            {
                DataContext = s.GetRequiredService<AdministrationViewModel>()
            });
            services.AddSingleton<EducationLevelViewModel>();
            services.AddSingleton<EducationLevelView>(s => new EducationLevelView()
            {
                DataContext = s.GetRequiredService<EducationLevelViewModel>()
            });
            services.AddSingleton<TypeOfEducationViewModel>();
            services.AddSingleton<TypeOfEducationView>(s => new TypeOfEducationView()
            {
                DataContext = s.GetRequiredService<TypeOfEducationViewModel>()
            });

        }

    }
}
