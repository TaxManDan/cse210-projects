Employee employee = new Employee();
float employeeSalary = employee.CalculatePay();
Console.WriteLine(employeeSalary);
var employee2 = new HourlyEmployee(12,40);
float employeePay = employee2.CalculatePay();
Console.WriteLine(employeePay);