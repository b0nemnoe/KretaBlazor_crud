namespace Kreta.Shared.Models.SchoolCitizens
{
    public class Student : IDbEntity<Student>
    {
        public Student(Guid id, string firstName, string lastName, DateTime birthsDay, string placeOfBirth, bool isWooman, bool isSchoolDivisionSecretary, Guid educationLevelId, Guid schoolClassId, Guid motherId, Guid fatherId, Guid addressId)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthsDay;
            PlaceOfBirth = placeOfBirth;
            IsWoman = isWooman;
            IsSchoolClassSecretary = isSchoolDivisionSecretary;
            EducationLevelId = educationLevelId;
            SchoolClassID = schoolClassId;
            MotherId = motherId;
            FatherId = fatherId;
            AddressId = addressId;
        }

        public Student()
        {
            Id = Guid.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthDay = new DateTime();
            PlaceOfBirth = string.Empty;
            IsWoman = false;
            IsSchoolClassSecretary = false;
            EducationLevelId = Guid.Empty;
            SchoolClassID = Guid.Empty;
            MotherId = Guid.Empty;
            FatherId = Guid.Empty;
            AddressId = Guid.Empty;
        }

        public Guid Id { get; set; }
        public Guid? EducationLevelId { get; set; }
        public virtual EducationLevel? EducationLevel { get; set; }
        public Guid? SchoolClassID { get; set; }
        public virtual SchoolClass? SchoolClass { get; set; }
        public Guid? MotherId { get; set; }
        public virtual Parent? Mather { get; set; }
        public Guid? FatherId { get; set; }
        public virtual Parent? Father { get; set; }
        public Guid? AddressId { get; set; }
        //public virtual Address? Address {get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string PlaceOfBirth { get; set; }
        public bool IsWoman { get; set; }
        public bool IsMan => !IsWoman;
        public bool IsSchoolClassSecretary { get; set; }
        public string HungarianName => $"{LastName} {FirstName}";

        public bool HasId => Id != Guid.Empty;

        public override string ToString()
        {
            string gender = IsWoman ? "nő" : "férfi";
            return $"{HungarianName} {gender} - ({String.Format("{0:yyyy.MM.dd.}", BirthDay)})";
        }
    }
}
