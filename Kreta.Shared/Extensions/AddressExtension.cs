using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.Shared.Extensions
{
    public static class AddressExtension
    {
        public static AddressDto ToDto(this Address educationLevel)
        {
            return new AddressDto
            {
                Id = educationLevel.Id,
                PublicSpaceName = educationLevel.PublicSpaceName,
                City = educationLevel.City,
                PostalCode = educationLevel.PostalCode,
                Door = educationLevel.Door,
                Floor = educationLevel.Floor,
                House = educationLevel.House,
                PublicScapeID=educationLevel.PublicScapeID,
                Parent = educationLevel.Parent,
                Student = educationLevel.Student,
                Teacher = educationLevel.Teacher,
                ParentId = educationLevel.ParentId,
                StudentId = educationLevel.StudentId,
                TeacherId = educationLevel.TeacherId,

            };
        }

        public static Address ToModel(this AddressDto model)
        {
            return new Address
            {
                Id = model.Id,
                PublicSpaceName = model.PublicSpaceName,
                City = model.City,
                PostalCode = model.PostalCode,
                Door = model.Door,
                Floor = model.Floor,
                House = model.House,
                PublicScapeID = model.PublicScapeID,
                Parent = model.Parent,
                Teacher = model.Teacher,
                Student= model.Student,
                ParentId= model.ParentId,
                TeacherId= model.TeacherId,
                StudentId= model.StudentId,
            };
        }
    }
}
