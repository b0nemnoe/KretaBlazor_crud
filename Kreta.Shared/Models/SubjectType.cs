
namespace Kreta.Shared.Models
{
    public class SubjectType : IDbEntity<SubjectType>
    {
        public SubjectType()
        {
            Id = Guid.Empty;
            SubjectTypeName = string.Empty;
        }
        public SubjectType(Guid id, string subjectTypeName)
        {
            Id = id;
            SubjectTypeName = subjectTypeName;
        }

        public Guid Id { get; set; }
        public string SubjectTypeName { get; set; }
        public bool HasId => Id!=Guid.Empty;
    }
}
