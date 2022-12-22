using Practical_Training.Models.Share;
using System.Collections.Generic;

namespace Practical_Training.Repositories.Base
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Add(T entity);

        T GetById(int id);

        void Update(int id, T entity);

        void Delete(T entity);

        IEnumerable<T> GetAll();
    }
}