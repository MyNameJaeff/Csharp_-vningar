using System;
using System.Collections;

namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void PrintEmployee(Employee employee, Stack stack)
            {
                Console.WriteLine($"Items left in the stack: {stack.Count}");
                Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
            }

            Employee employee1 = new Employee(1, "Jeff", "Male", 20000);
            Employee employee2 = new Employee(2, "Gustaf", "Male", 24999);
            Employee employee3 = new Employee(3, "Daniel", "Male", 18999);
            Employee employee4 = new Employee(4, "Jessica", "Female", 16000);
            Employee employee5 = new Employee(5, "Kristina", "Female", 17000);

            Stack stack = new Stack();
            stack.Push(employee1);
            stack.Push(employee2);
            stack.Push(employee3);
            stack.Push(employee4);
            stack.Push(employee5);

            foreach (Employee employee in stack)
            {
                PrintEmployee(employee, stack);
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Retrive using peek method");

            for (int i = 0; i < 2; i++)
            {
                Employee employee = (Employee)stack.Peek()!;
                PrintEmployee(employee, stack);           
            }

            Console.WriteLine("------------------------------------------");

            Console.WriteLine(stack.Contains(employee3) ? "Emp3 is in stack" : "Emp3 is NOT in stack");

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Retrive using pop method"); // Had to put pop last because stacks would be empty otherwise

            while (stack.Count > 0)
            {
                Employee employee = (Employee)stack.Pop()!;
                PrintEmployee(employee, stack);
            }

            List<Employee> employees = new List<Employee>();
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);

            // Kontrollera om employee2 finns i listan med Contains()
            Console.WriteLine(employees.Contains(employee2) ? "Employee2 object exists in the list" : "Employee2 object does not exist in the list");

            Console.WriteLine("------------------------------------------");

            // Använd Find() för att hitta det första objektet med Gender = "Male"
            Employee firstMaleEmployee = employees.Find(emp => emp.Gender == "Male")!;
            if (firstMaleEmployee != null)
            {
                Console.WriteLine($"ID = {firstMaleEmployee.Id}, Name = {firstMaleEmployee.Name}, Gender = {firstMaleEmployee.Gender}, Salary = {firstMaleEmployee.Salary}");
            }

            Console.WriteLine("------------------------------------------");

            // Använd FindAll() för att hitta alla objekt med Gender = "Male"
            List<Employee> maleEmployees = employees.FindAll(emp => emp.Gender == "Male");
            Console.WriteLine("All Male Employees:");
            foreach (Employee maleEmployee in maleEmployees)
            {
                Console.WriteLine($"ID = {maleEmployee.Id}, Name = {maleEmployee.Name}, Gender = {maleEmployee.Gender}, Salary = {maleEmployee.Salary}");
            }

        }
    }
}
