using Kreta.Shared.Models;

namespace Kreta.Shared.Assamblers
{
    public class DefaultAssambler<TEntity, TEntityDto> : Assambler<TEntity, TEntityDto>
        where TEntity : class, IDbEntity<TEntity>, new()
        where TEntityDto : class, new()
    {
        public DefaultAssambler()
        {
            // Alapértelmezett inicializáció, ha szükséges
        }
        public override TEntityDto ToDto(TEntity entity)
        {
            // Implementáció a DTO konverzióhoz
            return new TEntityDto();
        }

        public override TEntity ToModel(TEntityDto dto)
        {
            // Implementáció az Entity konverzióhoz
            return new TEntity();
        }
    }
}
