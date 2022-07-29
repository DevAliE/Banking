using Banking.Models;
using System.Collections.Generic;

namespace Banking.Interfaces
{
    internal interface IBankerRepository
    {
        void Create(Banker banker);

        void Update(int id, Banker banker);

        void Delete(int id);

        Banker Get(int id);

        List<Banker> GetAll();
    }
}
