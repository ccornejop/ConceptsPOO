﻿// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

Employee employee1 = new SaladyEmployee()
{ 
    Id = 1010, 
    FirstName = "Sandra", 
    LastName = "Morales", 
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1815453.45M
};
//Console.WriteLine(employee1);


Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Patricia",
    LastName = "Gutierrez",
    BirthDate = new Date(1995, 5, 23),
    HiringDate = new Date(2022, 2, 5),
    IsActive = true,
    Sales = 320000000M,
    CommissionPercentaje = 0.03F
};
//Console.WriteLine(employee2);


Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Gonzalo",
    LastName = "Cardona",
    BirthDate = new Date(1985, 5, 23),
    HiringDate = new Date(2022, 2, 5),
    IsActive = true,
    HourValue = 12356.56M,
    Hours = 123.5F
    
};
//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirstName = "Jazmin",
    LastName = "Salazar",
    BirthDate = new Date(1988, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Base = 860678.45M,
    Sales = 58000000M,
    CommissionPercentaje = 0.015F

};
//Console.WriteLine(employee4);


ICollection<Employee> employees = new List<Employee>()
{ 
    employee1, employee2, employee3, employee4
};

decimal payroll = 0;

foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("                              ===================");
Console.WriteLine($"TOTAL                         {$"{payroll:C2}",18}");

Invoice invoice1 = new Invoice()
{
    Description = "iPhone 13",
    Id = 1,
    Price = 5300000M,
    Quantity = 6
};

Invoice invoice2 = new Invoice()
{
    Description = "Posta Premium",
    Id = 2,
    Price = 32000M,
    Quantity = 17.5F
};
Console.WriteLine(invoice1);
Console.WriteLine(invoice2);














//Date date1 = new Date(2022,2,11);
//Console.WriteLine(date1.ToString());

//try
//{
//	Console.WriteLine(new Date(2024, 2, 29));
//	Console.WriteLine(new Date(1974, 9, 23));
//	Console.WriteLine(new Date(1985, 11, 31));
//}
//catch (Exception error)
//{

//    Console.WriteLine(error.Message);
//}