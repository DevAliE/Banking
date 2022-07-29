using Banking.Models;
using System.Collections.Generic;

namespace Banking.Interfaces
{
    internal interface IBankerRepository
    {
        void Create(Banker banker);

        void Update(long id, Banker banker);

        void Delete(long id);

        Banker Get(long id);

        List<Banker> GetAll();
    }
}
