namespace Kreta.Shared.Models
{
    public interface IDbEntity<TEntity> where TEntity : class, new()
    {
        public string GetDbSetName() => new TEntity().GetType().Name;
        public Guid Id { get; set; }
        public bool HasId { get; }
    }
}
