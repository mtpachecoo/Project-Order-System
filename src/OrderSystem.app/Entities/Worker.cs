
namespace OrderSystem.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();
    
        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));

            if (baseSalary < 0)
                throw new ArgumentOutOfRangeException(nameof(baseSalary), "Base salary cannot be negative.");

         
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department ?? throw new ArgumentNullException(nameof(department));
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
            
        }
        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach( HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
        
    }
}