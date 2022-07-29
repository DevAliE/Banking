using Banking.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Banking.Interfaces
{
    internal interface ICashRegisterRepository
    {
        void Create(CashRegister banker);

        void Update(long id, CashRegister banker);

        void Delete(long id);
        [DataType(DataType.EmailAddress)]
        CashRegister Get(long id);

        List<CashRegister> GetAll();
    }
}
