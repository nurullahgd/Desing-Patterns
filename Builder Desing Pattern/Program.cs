// See https://aka.ms/new-console-template for more information
using Desing_Patterns.Method1;
using Desing_Patterns.Method2;
using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        

        //var eb = new EndPointBuilder("https://localhost");

        //eb
        //    .Append("api")
        //    .Append("v1")
        //    .Append("user")
        //    .AppendParam("id","5")
        //    .AppendParam("username","test");


        //var url = eb.Build();
        //Console.WriteLine(url);


        //var empBuilder = new EmplooyeBuilderM1();

        //var employee =empBuilder.SetFullName("Nurullah Gündoğdu")
        //    .SetUserName("nurullahgd")
        //    .SetEmailAdress("nurullah.gnd65@gmail.com");
        //Console.WriteLine(employee.employee.FirstName);
        IEmplooyeBuilderM2 employeeBuilder = new InternalEmployeeBuilder();
        employeeBuilder.SetEmail("nurullah.gnd65@gmail.com");
        employeeBuilder.SetFullName("Nurullah Gündoğdu");
        var emp = employeeBuilder.BuildEmployee();
        Console.WriteLine(emp.EmailAdress);
        Console.ReadKey();
        
    }
}