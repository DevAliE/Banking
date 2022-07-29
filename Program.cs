using Banking.Models;
using Banking.Interfaces;
using Banking.Repositories;
using Banking.Enums;

namespace Banking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICashRegisterRepository cashRegisters = new CashRegisterRepository();
            cashRegisters.Create(new CashRegister(1, Functions.Cards, "8:00-18:00"));


            //foreach (var banker in bankers.GetAll())
            //    Console.WriteLine(banker.Name);

            //Console.WriteLine(bankers.Delete(1));

            //foreach (var banker in bankers.GetAll())
            //    Console.WriteLine(banker.Name);




            //var casregisters = new CashRegisterRepository();
            //casregisters.Create(new CashRegister(1, new Banker(1, "Asad", 100000), Functions.Credit, "9:00-18:00"));

            //foreach (var cashregister in casregisters.GetAll())
            //    Console.WriteLine(cashregister.Banker.Name + " " + cashregister.Functions + " " + cashregister.WorkingTime);

            //var res = casregisters.Get(1);


            //Console.WriteLine(res.WorkingTime + " " + res.Banker.Name);



        }
    }
}
