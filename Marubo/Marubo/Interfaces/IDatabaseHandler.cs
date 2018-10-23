using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marubo.Interfaces
{
    interface IDatabaseHandler
    {  
        void InsertIntoCustomerDatabase(Customer customer);
        Customer GetCustomer(string email);
        void UpdateCustomer(Customer customer);
    }
}
