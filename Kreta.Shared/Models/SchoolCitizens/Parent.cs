namespace Kreta.Shared.Models.SchoolCitizens
{
    public class Parent : IDbEntity<Parent>
    {
        public Parent()
        {
            Id = Guid.Empty;
            LastName = string.Empty;
            FirstName = string.Empty;
            IsWoman = false;
            BirthDay = DateTime.MinValue;
            PlaceOfBirth = string.Empty;
            MathersName = string.Empty;
        }
        public Parent(Guid id, string firstName, string lastName, bool isWoman, DateTime birthDay, string placeOfBirth, string mathersName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            IsWoman = isWoman;
            BirthDay = birthDay;
            PlaceOfBirth = placeOfBirth;
            MathersName = mathersName;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsWoman { get; set; }
        public Guid StudentOfParentId { get; set; }
        //public virtual Student? StudentOfParent { get; set; }
        public DateTime BirthDay { get; set; }
        public string PlaceOfBirth { get; set; }
        public string MathersName { get; set; }
        public Guid? AddressId { get; set; }
        //public virtual Address? Address { get; set; }
        public string HungarianName => $"{LastName} {FirstName}";
        public bool HasId => Id != Guid.Empty;
        public bool IsMan => !IsWoman;

        public override string ToString()
        {
            string woman = IsWoman ? "nő" : "férfi";

            return $"{HungarianName} {woman} {String.Format("{0:yyyy.MM.dd.}", BirthDay)} {PlaceOfBirth} {MathersName}";
        }
    }
}
