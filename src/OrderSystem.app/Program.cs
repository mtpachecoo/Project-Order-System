using OrderSystem.Entities;

namespace OrderSystem.app
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter departament's name: ");
            string deptName = Console.ReadLine();
            System.Console.Write("Enter worker data: ");
            System.Console.Write("Name: ");
            string name = Console.ReadLine();
            System.Console.Write("(Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            System.Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            System.Console.Write("How many contract to this worker? ");
            int contract = int.Parse(Console.ReadLine());
            for(int i = 1; i < contract; i++)
            {
                System.Console.WriteLine($"Enter #{i} contract data:");
                System.Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                System.Console.Write("Value por hour: ");
                double valueHour = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contracts = new HourContract (date, valueHour, hours); 
                worker.AddContract(contracts);


            }
        }
    }
}