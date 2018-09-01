using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.PracticalAspNet.Data.Repository
{
    public class BaseRepository : IDisposable
    {
        private RestaurantContext _dbContext;

        public RestaurantContext DbContext => _dbContext;

        public BaseRepository()
        {
            _dbContext = new RestaurantContext();
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }
    }
}
