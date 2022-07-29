using Banking.Models;
using System.Collections.Generic;

namespace Banking.Interfaces
{
    internal interface ICashRegisterRepository
    {
        void Create(CashRegister banker);

        void Update(int id, CashRegister banker);

        void Delete(int id);

        CashRegister Get(int id);

        List<CashRegister> GetAll();
    }
}
