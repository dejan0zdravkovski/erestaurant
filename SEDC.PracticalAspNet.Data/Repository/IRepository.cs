using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.PracticalAspNet.Data.Repository
{
    public interface IRepository<T>
    {
        IList<T> GetAll();

        T Get(int id);

        T Create(T item);

        void Update(T item);

        void Delete(T item);
    }
}
