using System.ComponentModel.DataAnnotations;

namespace Banking.Models
{
    internal class Banker
    {
        [Key]
        public long Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Salary { get; set; }
        

        public Banker(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
