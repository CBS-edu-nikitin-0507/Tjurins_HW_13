using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Worker name: ");
            string name = Console.ReadLine();
            Console.Write("Worker surname: ");
            string surname = Console.ReadLine();
            Console.Write("Worker position: ");
            string position = Console.ReadLine();
            Console.Write("Worker experience: ");
            int experience = Int32.Parse(Console.ReadLine());
            Console.Write("Worker salary: ");
            double salary = Double.Parse(Console.ReadLine());
            
            Employee employee = new Employee(name, surname);
            GetWorkerInfo(employee, position,experience,salary);

        }

        public static void GetWorkerInfo(Employee employee,string position,int exp,double sal)
        {
            Console.Clear();
            Console.WriteLine("Name: "+employee.name);
            Console.WriteLine("Surname: "+employee.surname);
            Console.WriteLine("Position: "+ position);
            employee.CalculateSalary(exp,position,sal);
        }
    }
}
