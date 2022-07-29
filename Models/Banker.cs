namespace Banking.Models
{
    internal class Banker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Banker(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
