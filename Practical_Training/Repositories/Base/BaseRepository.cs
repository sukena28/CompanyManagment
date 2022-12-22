using Practical_Training.Models.Share;

namespace Practical_Training.Repositories.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly List<T> _entities;

        public BaseRepository(List<T> entities)
        {
            _entities = entities;
        }

        public void Add(T entity)
        {
            _entities.ToList().Add(entity);
        }

        public void Update(int id, T entity)
        {
            var existingEntity = _entities.FirstOrDefault(i => i.Id == 1);


            if (existingEntity == null)
                return;


            var index = _entities.IndexOf(existingEntity);

            if (index >= 0)
            {
                _entities.RemoveAt(index);
                _entities.Insert(index, entity);
            }
        }

        public void Delete(T entity)
        {
            _entities.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _entities;
        }

        public T GetById(int id)
        {
            var entity = _entities.FirstOrDefault(e => e.Id == id);

            if (entity == null)
            {
                throw new NullReferenceException($"No entity was found with ID {id}.");
            }
            return entity;
        }

    }
}
