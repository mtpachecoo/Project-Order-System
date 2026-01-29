
namespace OrderSystem.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double baseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
    
        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            this.baseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
            
        }
        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int yaer, int month)
        {
            double sum = baseSalary;
            foreach( HourContract contract in Contracts)
            {
                if(contract.Date.Year == yaer && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
        
    }
}