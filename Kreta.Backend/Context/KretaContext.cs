using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;
using Kreta.Shared.Models.SwitchTable;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Context
{
    public class KretaContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<EducationLevel> EducationLevels { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<TypeOfEducation> TypeOfEducations {  get; set; } 
        public DbSet<SubjectType> SubjectTypes { get; set; }    
        public DbSet<Address> Addresss { get; set; }
        public DbSet<PublicSpace> PublicSpaces { get; set; }
        public DbSet<TeachersTeachInSchoolClass> TeacherTeachInSchoolClass { get; set; }
        public DbSet<SchoolClassStudents> SchoolClassStudents { get; set; }
        public DbSet<SchoolClassSubjects> SchoolClassSubjects { get; set; }
        public KretaContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 1:1 (Head)Teacher - SchoolClass
            modelBuilder.Entity<Teacher>()
                .HasOne(teacher => teacher.HeadTeacherFoClass)
                .WithOne(schoolClass => schoolClass.HeadTeacher)
              //  .HasForeignKey<Teacher>(teacher => teacher.HeadTeacherForShoolClassId)
                .HasForeignKey<SchoolClass>(schoolClass => schoolClass.HeadTeacherId)
                .IsRequired(false);
            // 1:1 Parent - Student (Mather)
            /* modelBuilder.Entity<Parent>()
                 .HasOne(parent => parent.StudentOfParent)
                 .WithOne(student => student.Mather)
                 .HasForeignKey<Student>(student => student.MotherId)
                 .IsRequired(false);
             // 1:1 Parent - Student (Father)
             modelBuilder.Entity<Parent>()
                 .HasOne(parent => parent.StudentOfParent)
                 .WithOne(student => student.Father)
                 .HasForeignKey<Student>(student => student.FatherId)
                 .IsRequired(false);*/
            //modelBuilder.Entity<Parent>().HasKey(parent => parent.Id);
            //modelBuilder.Entity<Student>().HasOne(student =>student.Mather);
            //modelBuilder.Entity<Student>().HasOne(student => student.Father);

            // 1:1 Address - Teacher,Parent,Student 
            //modelBuilder.Entity<Address>()
            //    .HasOne(address => address.Teacher)
            //    .WithOne(teacher => teacher.Address);
            //.HasForeignKey<Teacher>(teacher => teacher.AddressId);
            /* modelBuilder.Entity<Address>()
                .HasOne(address => address.Parent)
                .WithOne(parent => parent.Address);
            //.HasForeignKey<Teacher>(parent => parent.AddressId);
            modelBuilder.Entity<Address>()
                .HasOne(address => address.Student)
                .WithOne(student => student.Address);
                //.HasForeignKey<Teacher>(student => student.AddressId);
            */

            // 1:N SchoolClass - Student
            modelBuilder.Entity<SchoolClass>()
                .HasMany(schoolClass => schoolClass.StudentsOfClass)
                .WithOne(student => student.SchoolClass)
                .HasForeignKey(student => student.SchoolClassID)
                .IsRequired(false);

            // 1:N EducationLevel-Student
            modelBuilder.Entity<EducationLevel>()
                .HasMany(educationLevel => educationLevel.Students)
                .WithOne(student => student.EducationLevel)
                .HasForeignKey(student => student.EducationLevelId)
                .IsRequired(false);
            // 1:N TypeOfEducation - SchoolClass
            modelBuilder.Entity<TypeOfEducation>()
                .HasMany(toe => toe.SchoolClasses)
                .WithOne(schoolClass => schoolClass.TypeOfEducation)
                .HasForeignKey(schoolClass => schoolClass.TypeOfEducationId)
                .IsRequired(false);

            // N:M SchoolClass - Subject
            modelBuilder.Entity<SchoolClassSubjects>()
                .HasOne(schoolClassSubject => schoolClassSubject.SchoolClass)
                .WithMany(subject => subject.SchoolClassSubjects)
                .HasForeignKey(schoolClassSubject => schoolClassSubject.SchoolClassId)
                .IsRequired(false);

            modelBuilder.Entity<SchoolClassSubjects>()
                .HasOne(schoolClassSubjects => schoolClassSubjects.Subject)
                .WithMany(schoolClass => schoolClass.SchoolClassSubjects)
                .HasForeignKey(schoolClassSubjects => schoolClassSubjects.SubjectId)
                .IsRequired(false);
            // N:M TeacherTeachInSchoolClass
            modelBuilder.Entity<TeachersTeachInSchoolClass>()
                .HasOne(teacherWhoTeachInSchoolClass => teacherWhoTeachInSchoolClass.TeacherTeachInScoolClass)
                .WithMany(schoolClass => schoolClass.SchoolClassWhereTeacherTeach)
                .HasForeignKey(teacherWhoTeachInSchoolClass => teacherWhoTeachInSchoolClass.TeacherId)
                .IsRequired(false);
            modelBuilder.Entity<TeachersTeachInSchoolClass>()
                .HasOne(teacherWhoTeachInSchoolClass => teacherWhoTeachInSchoolClass.SchoolClassWhoTeacherTeach)
                .WithMany(schoolClass => schoolClass.TeacherWhoTeachInSchoolClass)
                .HasForeignKey(teacherWhoTeachInSchoolClass => teacherWhoTeachInSchoolClass.SchoolClassId)
                .IsRequired(false);
            // N:M 

        }
    }
}
