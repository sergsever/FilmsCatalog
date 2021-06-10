using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmsCatalog.Data
{
    public interface IDAO<Entity, KeyType>
    {
        public IEnumerable<Entity> GetAll();
        public void Add(Entity entity);
        public void Update(Entity entity);
		public Entity Find(KeyType key);

		public void Delete(Entity entity);
		
    }
}
