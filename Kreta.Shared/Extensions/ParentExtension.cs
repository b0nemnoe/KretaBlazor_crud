using Kreta.Shared.Dtos;
using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.Shared.Extensions
{
    public static class ParentExtension
    {
        public static ParentDto ToDto(this Parent parent)
        {
            return new ParentDto
            {
                Id = parent.Id,
                FirstName = parent.FirstName,
                LastName = parent.LastName,
                IsWoman = parent.IsWoman,
                BirthDay = parent.BirthDay,
                PlaceOfBirth = parent.PlaceOfBirth,
                MathersName = parent.MathersName,
               // StudentOfParent = parent.StudentOfParent,
                //Address = parent.Address,
                AddressId = parent.AddressId,
            };
        }

        public static Parent ToModel(this ParentDto parentdto)
        {
            return new Parent
            {
                Id = parentdto.Id,
                FirstName = parentdto.FirstName,
                LastName = parentdto.LastName,
                IsWoman = parentdto.IsWoman,
                BirthDay= parentdto.BirthDay,
                PlaceOfBirth= parentdto.PlaceOfBirth,
                MathersName= parentdto.MathersName,
              //  StudentOfParent= parentdto.StudentOfParent,
                AddressId= parentdto.AddressId,
              //  Address= parentdto.Address,
            };
        }
    }
}
