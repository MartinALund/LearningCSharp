using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marubo
{
    public interface IEntityHandler<T>
    {

        List<T> GetItems();
        T GetItem();

    }
}
