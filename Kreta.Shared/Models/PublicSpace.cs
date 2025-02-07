
namespace Kreta.Shared.Models
{
    public class PublicSpace : IDbEntity<PublicSpace>
    {
        public PublicSpace()
        {
            Id = Guid.Empty;
            NameOfPublicSpace = string.Empty;
        }
        public PublicSpace(Guid id, string nameOfPublicSpace)
        {
            Id = id;
            NameOfPublicSpace = nameOfPublicSpace;
        }

        public Guid Id { get; set; }
        public string NameOfPublicSpace { get; set; } = string.Empty;

        public bool HasId => Id!=Guid.Empty;
    }
}
