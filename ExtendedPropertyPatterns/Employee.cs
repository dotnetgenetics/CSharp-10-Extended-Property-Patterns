namespace ExtendedPropertyPatterns
{
    public class Department
    {
        public string DepartmentName { get; set; } = string.Empty;
    }

    public class Employee
    {
        public string Name { get; set; } = string.Empty;
        public Department EmployeeDepartment { get; set; }

        public Employee()
        {
            EmployeeDepartment = new Department();
        }
    }

    public class Payroll
    {
        public static double ComputePayrollVersionOne(Employee employee, double numHours)
        {
            double payroll;

            if (employee is { EmployeeDepartment: { DepartmentName: "Accounting" } })
                payroll = 150 * numHours;
            else if (employee is { EmployeeDepartment: { DepartmentName: "IT" } })
                payroll = 270 * numHours;
            else if (employee is { EmployeeDepartment: { DepartmentName: "Production" } })
                payroll = 100 * numHours;
            else
                payroll = 65 * numHours;

            return payroll;
        }

        public static double ComputePayrollVersionTwo(Employee employee, double numHours) =>
           employee switch
           {
               { EmployeeDepartment: { DepartmentName: "Accounting" } } => 150 * numHours,
               { EmployeeDepartment: { DepartmentName: "IT" } } => 270 * numHours,
               { EmployeeDepartment: { DepartmentName: "Production" } } => 100 * numHours,
               _ => 65 * numHours
           };
    }
}
