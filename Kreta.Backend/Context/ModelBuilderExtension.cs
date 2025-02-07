using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;
using Kreta.Shared.Models.SwitchTable;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //ID-s
            #region Id-s
            Guid publicSpaceId1 = Guid.NewGuid();
            Guid publicSpaceId2 = Guid.NewGuid();
            Guid publicSpaceId3 = Guid.NewGuid();

            Guid schoolClassId1 = Guid.NewGuid();
            Guid schoolClassId2 = Guid.NewGuid();
            Guid schoolClassId3 = Guid.NewGuid();

            Guid teacherId1 = Guid.NewGuid();
            Guid teacherId2 = Guid.NewGuid();
            Guid teacherId3 = Guid.NewGuid();
            Guid teacherId4 = Guid.NewGuid();
            Guid teacherId5 = Guid.NewGuid();

            Guid addressId1 = Guid.NewGuid();
            Guid addressId2 = Guid.NewGuid();
            Guid addressId3 = Guid.NewGuid();
            Guid addressId4 = Guid.NewGuid();
            Guid addressId5 = Guid.NewGuid();
            Guid addressId6 = Guid.NewGuid();

            Guid typeOfSubject1 = Guid.NewGuid();
            Guid typeOfSubject2 = Guid.NewGuid();
            Guid typeOfSubject3 = Guid.NewGuid();

            Guid subjectId1 = Guid.NewGuid();
            Guid subjectId2 = Guid.NewGuid();
            Guid subjectId3 = Guid.NewGuid();

            Guid typeOfEducation1 = Guid.NewGuid();
            Guid typeOfEducation2 = Guid.NewGuid();
            Guid typeOfEducation3 = Guid.NewGuid();

            Guid EducationLevelId1 = Guid.NewGuid();
            Guid EducationLevelId2 = Guid.NewGuid();

            Guid parentId1 = Guid.NewGuid();
            Guid parentId2 = Guid.NewGuid();
            Guid parentId3 = Guid.NewGuid();
            Guid parentId4 = Guid.NewGuid();
            Guid parentId5 = Guid.NewGuid();
            Guid parentId6 = Guid.NewGuid();

            Guid studentId1 = Guid.NewGuid();
            Guid studentId2 = Guid.NewGuid();
            Guid studentId3 = Guid.NewGuid();
            Guid studentId4 = Guid.NewGuid();
            Guid studentId5 = Guid.NewGuid();
            Guid studentId6 = Guid.NewGuid();
            Guid studentId7 = Guid.NewGuid();
            #endregion

            // Table
            #region Public space
            List<PublicSpace> publicSpaces = new List<PublicSpace>()
            {
                new PublicSpace()
                {
                    Id = publicSpaceId1,
                    NameOfPublicSpace="utca",
                },
                new PublicSpace()
                {
                    Id = publicSpaceId2,
                    NameOfPublicSpace="tér",
                },
                new PublicSpace()
                {
                    Id = publicSpaceId3,
                    NameOfPublicSpace="sugárút",
                },
            };
            #endregion
            #region Address
            List<Address> addresses = new List<Address>
            {
                new Address
                {
                    Id = addressId1,
                    City="Szeged",
                    PublicSpaceName="Szentháromság",
                    House=10,
                    PostalCode=6722,
                    PublicScapeID=publicSpaceId1,
                },
                new Address
                {
                    Id = addressId2,
                    City="Szeged",
                    PublicSpaceName="Kossuth Lajos",
                    House=85,
                    PostalCode=6724,
                    PublicScapeID=publicSpaceId3,
                },
                new Address
                {
                    Id = addressId3,
                    City="Szeged",
                    PublicSpaceName="Boldogasszony",
                    House=22,
                    PostalCode=6722,
                    PublicScapeID=publicSpaceId3,
                },
                new Address
                {
                    Id = addressId4,
                    City="Szeged",
                    PublicSpaceName="Zászló",
                    House=56,
                    PostalCode=6722,
                    PublicScapeID=publicSpaceId1,
                },
                new Address
                {
                    Id = addressId5,
                    City="Szeged",
                    PublicSpaceName="Kossuth Lajos",
                    House=2,
                    PostalCode=6724,
                    PublicScapeID=publicSpaceId3,
                },
                new Address
                {
                    Id = addressId6,
                    City="Szeged",
                    PublicSpaceName="Bokor",
                    House=45,
                    PostalCode=6722,
                    PublicScapeID=publicSpaceId1,
                },

            };
            #endregion
            #region Subject type
            List<SubjectType> subjectTypes = new List<SubjectType>
            {
                new SubjectType
                {
                    Id = typeOfSubject1,
                    SubjectTypeName="Természettudomány",
                },
                new SubjectType
                {
                    Id = typeOfSubject2,
                    SubjectTypeName="Idegen nyelv",
                },
                new SubjectType
                {
                    Id = typeOfSubject3,
                    SubjectTypeName="Közgazdaságtan",
                },
            };
            #endregion
            #region Subject
            List<Subject> subjects = new List<Subject>
            {
                new Subject
                {
                    Id=subjectId1,
                    SubjectName="Földrajz",
                    ShortName="Föci",
                    SubjectTypeId=typeOfSubject1,
                    CompulsoryExaminationSubject=false,
                    OptionalExaminationSubject=true,
                },
                new Subject
                {
                    Id=subjectId2,
                    SubjectName="Angol",
                    ShortName="Angol",
                    SubjectTypeId=typeOfSubject2,
                    CompulsoryExaminationSubject=true,
                    OptionalExaminationSubject=false,
                },
                new Subject
                {
                    Id=subjectId3,
                    SubjectName="Marketing",
                    ShortName="Market",
                    SubjectTypeId=typeOfSubject3,
                    CompulsoryExaminationSubject=false,
                    OptionalExaminationSubject=false,
                }
            };
            #endregion
            #region Type of education
            List<TypeOfEducation> typeOfEducations = new()
            {
                new TypeOfEducation
                {
                    Id = typeOfEducation1,
                    EducationName="Szoftverfejlesztő és -tesztelő"
                },
                new TypeOfEducation
                {
                    Id = typeOfEducation2,
                    EducationName="Idegen nyelvű ipari és kereskedelmi technikus"
                },
                new TypeOfEducation
                {
                    Id = typeOfEducation3,
                    EducationName="Vállalkozási ügyviteli ügyintéző"
                }
            };
            #endregion
            #region EducationLevel
            List<EducationLevel> educationLevels = new()
            {
                new EducationLevel
                {
                    Id=EducationLevelId1,
                    StudentEducationLevel="érettségi",
                    DurationOfEducation=4,
                },
                new EducationLevel
                {
                    Id=EducationLevelId2,
                    StudentEducationLevel="szakképzés",
                    DurationOfEducation=2,
                }
            };
            #endregion
            #region Parent
            List<Parent> parents = new()
            {
                new Parent
                {
                    Id=parentId1,
                    FirstName="Virág",
                    LastName="Vas",
                    IsWoman=true,
                    BirthDay=new DateTime(1998,8,8),
                    PlaceOfBirth="Szeged",
                    MathersName="Érc Kitti",
                    StudentOfParentId=studentId1,
                    AddressId=addressId1,
                },
                new Parent
                {
                    Id=parentId2,
                    FirstName="Petra",
                    LastName="Pénzes",
                    IsWoman=true,
                    BirthDay=new DateTime(1997,7,7),
                    PlaceOfBirth="Kistelek",
                    MathersName="Szegény Szandi",

                },
                new Parent
                {
                    Id=parentId3,
                    FirstName="Ferenc",
                    LastName="Fukar",
                    IsWoman=false,
                    BirthDay=new DateTime(1995,5,5),
                    PlaceOfBirth="Szeged",
                    MathersName="Adakozó Andor",
                    StudentOfParentId=studentId1,
                    AddressId=addressId2,

                },
                new Parent
                {
                    Id=parentId4,
                    FirstName="Fruzsi",
                    LastName="Fukar",
                    IsWoman=true,
                    BirthDay=new DateTime(1994,4,4),
                    PlaceOfBirth="Makó",
                    MathersName="Adó Anna",
                    StudentOfParentId=studentId4,

                },
                new Parent
                {
                    Id=parentId5,
                    FirstName="Hedvig",
                    LastName="Hosszú",
                    IsWoman=true,
                    BirthDay=new DateTime(1992,2,2),
                    PlaceOfBirth="Szeged",
                    MathersName="Alacsony Anikó",
                    StudentOfParentId=studentId7,

                },
                new Parent
                {
                    Id=parentId6,
                    FirstName="Milán",
                    LastName="Magas",
                    IsWoman=false,
                    BirthDay=new DateTime(1992,2,2),
                    PlaceOfBirth="Deszk",
                    MathersName="Alacsony Anikó",
                    StudentOfParentId=studentId7,
                }
            };
            #endregion
            #region Student
            List<Student> students = new()
            {
                new Student
                {
                    Id=studentId1,
                    FirstName="János",
                    LastName="Jegy",
                    IsWoman=false,
                    BirthDay=new DateTime(2022,10,10),
                    PlaceOfBirth="Szeged",
                    EducationLevelId=EducationLevelId1,
                    MotherId=parentId1,
                    FatherId=parentId3,
                    AddressId=addressId1,
                    SchoolClassID=schoolClassId1
                },
                new Student
                {
                    Id=studentId2,
                    FirstName="Nóra",
                    LastName="Nagy",
                    IsWoman=true,
                    BirthDay=new DateTime(2021,4,4),
                    PlaceOfBirth="Kiskunhalas",
                    EducationLevelId=EducationLevelId2,
                    SchoolClassID=schoolClassId1,
                    AddressId=addressId3,
                    MotherId=null,
                    FatherId=null,
                },
                new Student
                {
                    Id=studentId3,
                    FirstName="Valér",
                    LastName="Vas",
                    IsWoman=false,
                    BirthDay=new DateTime(2022,7,7),
                    PlaceOfBirth="Makó",
                    EducationLevelId=EducationLevelId1,
                    SchoolClassID=schoolClassId1,
                    MotherId=null,
                    FatherId=null,
                },
                new Student
                {
                    Id=studentId4,
                    FirstName="Márta",
                    LastName="Kis",
                    PlaceOfBirth="Szabadka",
                    IsWoman=true,
                    BirthDay=new DateTime(2019,9,9),
                    EducationLevelId=EducationLevelId1,
                    SchoolClassID=schoolClassId2,
                    MotherId=parentId4,
                    FatherId=null,
                },
                new Student
                {
                    Id=studentId5,
                    FirstName="Milán",
                    LastName="Magas",
                    IsWoman=false,
                    BirthDay=new DateTime(2017,7,7),
                    PlaceOfBirth="Apátfalva",
                    EducationLevelId=EducationLevelId2,
                    MotherId=parentId1,
                    FatherId=null,
                    SchoolClassID=schoolClassId2,
                    AddressId=addressId4,
                },
                new Student
                {
                    Id=studentId6,
                    FirstName="Fruzsina",
                    LastName="Fukar",
                    IsWoman=false,
                    BirthDay=new DateTime(2019,9,9),
                    PlaceOfBirth="Miskolc",
                    EducationLevelId=EducationLevelId2,
                    SchoolClassID=schoolClassId2,
                    MotherId=null,
                    FatherId=null,
                },
                new Student
                {
                    Id=studentId7,
                    FirstName="Kinga",
                    LastName="Kilógó",
                    IsWoman=false,
                    BirthDay=new DateTime(2019,9,9),
                    PlaceOfBirth="Miskolc",
                    MotherId=parentId5,
                    FatherId=parentId6,
                    SchoolClassID=schoolClassId3,
                    EducationLevelId=null,
                }
            };
            #endregion
            #region Teacher
            List<Teacher> teachers = new()
            {
                new Teacher
                {
                    Id=teacherId1,
                    FirstName="Martin",
                    LastName="Magyar",
                    BirthDay=new DateTime(2000,10,10),
                    IsHeadTeacher=true,
                    HeadTeacherForShoolClassId=schoolClassId1,
                    PlaceOfBirth="Miskolc",
                    IsWoman=false,
                    MathersName="Miskolci Mária"

                },
                new Teacher
                {
                    Id=teacherId2,
                    FirstName="Mirjam",
                    LastName="Metek",
                    BirthDay=new DateTime(2000,11,11),
                    IsHeadTeacher=true,
                    HeadTeacherForShoolClassId=schoolClassId2,
                    PlaceOfBirth="Eger",
                    IsWoman=true,
                    MathersName="Egri Etelka"

                },
                new Teacher
                {
                    Id=teacherId3,
                    FirstName="Feri",
                    LastName="Földrajz",
                    BirthDay=new DateTime(2000,12,12),
                    IsHeadTeacher=true,
                    HeadTeacherForShoolClassId=schoolClassId3,
                    PlaceOfBirth="Szabadka",
                    IsWoman=false,
                    MathersName="Szabadkai Szabina",
                    AddressId=addressId5,

                },
                new Teacher
                {
                    Id=teacherId4,
                    FirstName="Éva",
                    LastName="Ének",
                    BirthDay=new DateTime(2000,1,1),
                    IsHeadTeacher=false,
                    PlaceOfBirth="Baja",
                    IsWoman=true,
                    MathersName="Bajai Betti"
                },
                new Teacher
                {
                    Id=teacherId5,
                    FirstName="Adorján",
                    LastName="Angol",
                    BirthDay=new DateTime(2000,3,3),
                    IsHeadTeacher=false,
                    PlaceOfBirth="Kecskemét",
                    IsWoman=false,
                    MathersName="Kecskeméti Kati",
                    AddressId=addressId6,
                }
            };
            #endregion
            #region School class
            List<SchoolClass> schoolClasses = new List<SchoolClass>
            {
                new SchoolClass
                {
                    Id=schoolClassId1,
                    SchoolYear=9,
                    SchoolClassType=SchoolClassType.ClassA,
                    YearOfEnrolment=2025,
                    IsArchived=false,
                    TypeOfEducationId=typeOfEducation1,
                    HeadTeacherId=teacherId1,
                },
                new SchoolClass
                {
                    Id=schoolClassId2,
                    SchoolYear=10,
                    SchoolClassType=SchoolClassType.ClassB,
                    YearOfEnrolment=2024,
                    IsArchived=false,
                    TypeOfEducationId=typeOfEducation2,
                    HeadTeacherId=teacherId2,
                },
                new SchoolClass
                {
                    Id=schoolClassId3,
                    SchoolYear=14,
                    SchoolClassType=SchoolClassType.ClassB,
                    YearOfEnrolment=2024,
                    IsArchived=false,
                    TypeOfEducationId=typeOfEducation3,
                    HeadTeacherId=teacherId3,
                },
            };
            #endregion

            //Switch table
            #region School class subjects
            List<SchoolClassSubjects> schoolClassSubjects = new List<SchoolClassSubjects>
            {
                new SchoolClassSubjects
                {
                    Id=Guid.NewGuid(),
                    SchoolClassId=schoolClassId1,
                    SubjectId=subjectId1,
                    NumberOfHours=3,
                    IsTheHoursInOne=false,
                },
                new SchoolClassSubjects
                {
                    Id=Guid.NewGuid(),
                    SchoolClassId=schoolClassId1,
                    SubjectId=subjectId3,
                    NumberOfHours=1,
                    IsTheHoursInOne=true,
                },
                new SchoolClassSubjects
                {
                    Id=Guid.NewGuid(),
                    SchoolClassId=schoolClassId2,
                    SubjectId=subjectId2,
                    NumberOfHours=2,
                    IsTheHoursInOne=false,
                },
                new SchoolClassSubjects
                {
                    Id=Guid.NewGuid(),
                    SchoolClassId=schoolClassId3,
                    SubjectId=subjectId1,
                    NumberOfHours=2,
                    IsTheHoursInOne=false,
                },
                new SchoolClassSubjects
                {
                    Id=Guid.NewGuid(),
                    SchoolClassId=schoolClassId3,
                    SubjectId=subjectId2,
                    NumberOfHours=2,
                    IsTheHoursInOne=true,
                },
                new SchoolClassSubjects
                {
                    Id=Guid.NewGuid(),
                    SchoolClassId=schoolClassId3,
                    SubjectId=subjectId3,
                    NumberOfHours=4,
                    IsTheHoursInOne=false,
                }
            };
            #endregion
            #region Teacher teach in school class
            List<TeachersTeachInSchoolClass> teachersTeachInSchoolClasses = new List<TeachersTeachInSchoolClass>
            {
                new TeachersTeachInSchoolClass
                {
                    Id = Guid.NewGuid(),
                    SchoolClassId = schoolClassId2,
                    TeacherId = teacherId5,
                    IsTheHoursInOne = false,
                    NumberOfHours=3,
                },
                new TeachersTeachInSchoolClass
                {
                    Id = Guid.NewGuid(),
                    SchoolClassId = schoolClassId1,
                    TeacherId = teacherId5,
                    IsTheHoursInOne = false,
                    NumberOfHours=2,
                },
                new TeachersTeachInSchoolClass
                {
                    Id = Guid.NewGuid(),
                    SchoolClassId = schoolClassId2,
                    TeacherId = teacherId4,
                    IsTheHoursInOne = true,
                    NumberOfHours=3,
                },

            };

            #endregion
            #region School class students
            List<SchoolClassStudents> schoolClassStudents = new List<SchoolClassStudents>
            {
                new SchoolClassStudents
                {
                    Id=Guid.NewGuid(),
                    StudnetId = studentId1,
                    SchoolClassId=schoolClassId1,
                    DateOfEnrolment=new DateOnly(2022,09,01),
                },
                new SchoolClassStudents
                {
                    Id=Guid.NewGuid(),
                    StudnetId = studentId2,
                    SchoolClassId=schoolClassId1,
                    DateOfEnrolment=new DateOnly(2022,09,01),
                },
                new SchoolClassStudents
                {
                    Id=Guid.NewGuid(),
                    StudnetId = studentId3,
                    SchoolClassId=schoolClassId2,
                    DateOfEnrolment=new DateOnly(2023,09,01),
                },
            };
            #endregion

            modelBuilder.Entity<EducationLevel>().HasData(educationLevels);
            modelBuilder.Entity<TypeOfEducation>().HasData(typeOfEducations);
            modelBuilder.Entity<SubjectType>().HasData(subjectTypes);
            modelBuilder.Entity<Address>().HasData(addresses);

            modelBuilder.Entity<Student>().HasData(students);
            modelBuilder.Entity<Teacher>().HasData(teachers);
            modelBuilder.Entity<Parent>().HasData(parents);
            modelBuilder.Entity<SchoolClass>().HasData(schoolClasses);
            modelBuilder.Entity<Subject>().HasData(subjects);
            modelBuilder.Entity<PublicSpace>().HasData(publicSpaces);
            modelBuilder.Entity<SchoolClassSubjects>().HasData(schoolClassSubjects);
            modelBuilder.Entity<TeachersTeachInSchoolClass>().HasData(teachersTeachInSchoolClasses);
        }
    }
}
