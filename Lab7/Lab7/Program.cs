namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            static void PrintEmployee(Employee employee, int itemsLeft)
            {
                Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
                Console.WriteLine($"Items left in the stack: {itemsLeft}");
            }

            Employee employee1 = new Employee(1, "Jeff", "Male", 20000);
            Employee employee2 = new Employee(2, "Gustaf", "Male", 24999);
            Employee employee3 = new Employee(3, "Daniel", "Male", 18999);
            Employee employee4 = new Employee(4, "Jessica", "Female", 16000);
            Employee employee5 = new Employee(5, "Kristina", "Female", 17000);

            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(employee1);
            stack.Push(employee2);
            stack.Push(employee3);
            stack.Push(employee4);
            stack.Push(employee5);

            // Print all objects in the stack
            Console.WriteLine("All items in the stack:");
            foreach (Employee employee in stack)
            {
                PrintEmployee(employee, stack.Count);
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Retrieve using Pop method:");

            // Pop all items in the stack
            while (stack.Count > 0)
            {
                Employee employee = stack.Pop();
                PrintEmployee(employee, stack.Count);
            }

            // Re-add all items to the stack
            stack.Push(employee1);
            stack.Push(employee2);
            stack.Push(employee3);
            stack.Push(employee4);
            stack.Push(employee5);

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Retrieve using Peek method:");

            // Peek at the top two objects
            for (int i = 0; i < 2; i++)
            {
                Employee employee = stack.Peek();
                PrintEmployee(employee, stack.Count);
            }

            Console.WriteLine("------------------------------------------");

            // Check if employee3 is in the stack
            Console.WriteLine(stack.Contains(employee3) ? "Employee3 is in stack" : "Employee3 is NOT in stack");

            Console.WriteLine("------------------------------------------\n");



            // Part 2 - List operations
            List<Employee> employees = new List<Employee> { employee1, employee2, employee3, employee4, employee5 };

            // Check if employee2 exists in the list using Contains
            Console.WriteLine(employees.Contains(employee2) ? "Employee2 object exists in the list" : "Employee2 object does not exist in the list");

            Console.WriteLine("------------------------------------------");

            // Find the first Male employee
            Employee firstMaleEmployee = employees.Find(emp => emp.Gender == "Male");
            if (firstMaleEmployee != null)
            {
                Console.WriteLine($"ID = {firstMaleEmployee.Id}, Name = {firstMaleEmployee.Name}, Gender = {firstMaleEmployee.Gender}, Salary = {firstMaleEmployee.Salary}");
            }

            Console.WriteLine("------------------------------------------");

            // Find all Male employees
            List<Employee> maleEmployees = employees.FindAll(emp => emp.Gender == "Male");
            Console.WriteLine("All Male Employees:");
            foreach (Employee maleEmployee in maleEmployees)
            {
                Console.WriteLine($"ID = {maleEmployee.Id}, Name = {maleEmployee.Name}, Gender = {maleEmployee.Gender}, Salary = {maleEmployee.Salary}");
            }
        }
    }
}
