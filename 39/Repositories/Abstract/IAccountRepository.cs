using _39.Enttities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39.Abstract
{
    interface IAccountRepository
    {
        void Add(Account account);
        void Update(Account account);

        List<Account> Get();
        Account Get(int id);

        void Delete(int id);    
    }
}
