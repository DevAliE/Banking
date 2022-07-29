using Banking.Interfaces;
using Banking.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Banking.Repositories
{
    internal class BankerRepository : IBankerRepository
    {
        private readonly string path = Constants.FilePath.BankerFilePath;

        public void Create(Banker banker)
        {
            var lastBankir = GetAll().LastOrDefault();
            long id = lastBankir != null ? lastBankir.Id + 1 : 0;

            
            var bankers = GetAll();
            banker.Id = id;
            bankers.Add(banker);
            File.WriteAllText(path, JsonConvert.SerializeObject(bankers, Formatting.Indented));
        }
        public void Delete(int id)
        {
            var bankers = GetAll().Where(p => p.Id != id);
            File.WriteAllText(path, JsonConvert.SerializeObject(bankers, Formatting.Indented));
        }
        public Banker Get(int id)
            => GetAll().FirstOrDefault(x => x.Id == id);
        public List<Banker> GetAll()
        {
            var text = File.ReadAllText(path);
            if (string.IsNullOrEmpty(text))
            {
                text = "[]";
                File.WriteAllText(path, text);

            }
            return JsonConvert.DeserializeObject<List<Banker>>(text);
        }
        public void Update(int id, Banker banker)
        {
            var bankers = GetAll().Select(p => p.Id == id ? p = banker : p);
            File.WriteAllText(path, JsonConvert.SerializeObject(bankers, Formatting.Indented));
        }
    }
}
