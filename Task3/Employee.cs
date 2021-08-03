using System;

namespace Task3
{
    public class Employee
    {
        public string name;
        public string surname;

        public double tax = 0.315;
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void CalculateSalary(int exp, string position, double salary)
        {
            int salaryBonus;
            int expCoef;
            switch (position)
            {
                case "1st level worker":
                    salaryBonus = 0;
                    expCoef = exp / 1;
                    Console.WriteLine("Salary: "+(salaryBonus + salary*expCoef));
                    Console.WriteLine("Tax: " + (salaryBonus + salary * expCoef)*tax);
                    break;
                case "2nd level worker":
                    salaryBonus = 300;
                    expCoef = exp / 1;
                    Console.WriteLine("Salary: " + (salaryBonus + salary * expCoef));
                    Console.WriteLine("Tax: " + (salaryBonus + salary * expCoef) * tax);
                    break;
                case "3rd level worker":
                    salaryBonus = 600;
                    expCoef = exp / 1;
                    Console.WriteLine("Salary: " + (salaryBonus + salary * expCoef));
                    Console.WriteLine("Tax: " + (salaryBonus + salary * expCoef) * tax);
                    break;
                default:
                    Console.WriteLine("There is no positions like that.");
                    break;
            }
        }
    }
}