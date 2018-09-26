using Marubo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marubo
{
    public class EntityHandler<T> : IEntityHandler<T>
    {
        MaruboEntityModel dbContext;
        public EntityHandler()
        {
            dbContext = new MaruboEntityModel();
        }
        public T GetItem()
        {
            throw new NotImplementedException();
        }

        public List<T> GetItems()
        {
            throw new NotImplementedException();           
        }
    }
}
