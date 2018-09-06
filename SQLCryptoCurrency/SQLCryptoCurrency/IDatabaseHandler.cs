using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCryptoCurrency
{
    interface IDatabaseHandler
    {

        void ConnectToDatabase();
        void InsertIntoUserDatabase(User user);
        User GetUser(string username);

    }
}
