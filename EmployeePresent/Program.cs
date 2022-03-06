//uc2
int Present = 1;
int Emp_per_rate = 20;
int empwage = 0;
int emphr = 0;
Random random = new Random();
int EmployeeStatus = random.Next(0,2);
if (EmployeeStatus == Present)
{
    Console.WriteLine("Employee is present");
    emphr = 8;
}
else
{
    Console.WriteLine("Employee is Absent");
    emphr = 0;
}
empwage = (Emp_per_rate * emphr);
Console.WriteLine("Dailly wage " + empwage);



