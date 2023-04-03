// See https://aka.ms/new-console-template for more information
using Decorator_Pattern;

Console.WriteLine("Hello, World!");
Employee employee = new Employee();
employee.UserAdding();
Console.WriteLine("-----");
employee.UserRemoved();
Console.WriteLine("==============================================");
Roles roles = new Roles();
roles.UserAdding();
Console.WriteLine("-----");
roles.UserRemoved();
Console.WriteLine("==============================================");
Intern intern = new Intern();
intern.UserAdding();
Console.WriteLine("-----");
intern.UserRemoved();

//Console.ReadKey();