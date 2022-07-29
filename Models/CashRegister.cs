
using Banking.Enums;

namespace Banking.Models
{
    internal class CashRegister
    {
        public int Id { get; set; }

        public Functions Functions { get; set; }

        public int BankerId { get; set; }

        public string WorkingTime { get; set; }

        public CashRegister(int bankerId, Functions functions, string workingTime)
        {
            Functions = functions;
            BankerId = bankerId;
            WorkingTime = workingTime;
        }

    }
}
