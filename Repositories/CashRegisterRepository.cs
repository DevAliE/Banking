using Banking.Interfaces;
using Banking.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Banking.Repositories
{
    internal class CashRegisterRepository : ICashRegisterRepository
    {
        private string path = Constants.FilePath.CashRegisterFilePath;
        public void Create(CashRegister cashRegister)
        {
            var lastCashRegister = GetAll().LastOrDefault();
            int id = lastCashRegister != null ? lastCashRegister.Id + 1 : 0;

            IBankerRepository br = new BankerRepository();

            var cashRegisters = GetAll();
            cashRegister.Id = id;


            cashRegisters.Add(cashRegister);
            File.WriteAllText(path, JsonConvert.SerializeObject(cashRegister, Formatting.Indented));
        }

        public void Delete(int id)
        {
            var cashRegisters = GetAll().Where(p => p.Id != id);
            File.WriteAllText(path, JsonConvert.SerializeObject(cashRegisters, Formatting.Indented));
        }

        public CashRegister Get(int id)
            => GetAll().FirstOrDefault(x => x.Id == id);

        public List<CashRegister> GetAll()
        {
            var text = File.ReadAllText(path);
            if (string.IsNullOrEmpty(text))
            {
                text = "[]";
                File.WriteAllText(path, text);
            }
            return JsonConvert.DeserializeObject<List<CashRegister>>(text);
        }

        public void Update(int id, CashRegister cashRegister)
        {
            var cashRegisters = GetAll().Select(p => p.Id == id ? p = cashRegister : p);
            File.WriteAllText(path, JsonConvert.SerializeObject(cashRegisters, Formatting.Indented));
        }
    }
}
