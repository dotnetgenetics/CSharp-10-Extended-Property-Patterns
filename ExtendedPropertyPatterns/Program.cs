namespace ExtendedPropertyPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestEmployeeCsharp9x();
            TestEmployeeCsharp10();
            Console.ReadLine();
        }

        /// <summary>
        /// C# 9.0 Version
        /// </summary>
        static void TestEmployeeCsharp9x()
        {
            Employee employee = new Employee();
            employee.Name = "Greg Esguerra";
            employee.EmployeeDepartment.DepartmentName = "IT";

            double pay;
            pay = Payroll.ComputePayrollVersionTwo(employee, 40);
            Console.WriteLine($"Salary is: {pay}");
        }

        /// <summary>
        /// C# 10 Version
        /// </summary>
        static void TestEmployeeCsharp10()
        {
            EmployeeUpdated employee = new EmployeeUpdated();
            employee.Name = "Greg Esguerra";
            employee.EmployeeDepartment.DepartmentName = "IT";

            double pay;
            pay = PayrollUpdated.ComputePayrollVersionTwo(employee, 40);
            Console.WriteLine($"Salary is: {pay}");
        }
    }
}
