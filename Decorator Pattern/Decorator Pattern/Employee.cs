using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class Employee
    {
        public void UserAdding()
        {
            Console.WriteLine($"{GetType().Name} Welcome to company");

        }
        public void UserRemoved()
        {
            Console.WriteLine($"{GetType().Name} Goodbye. We miss you");
        }
    }
    public class EmployeeDecorator : Employee
    {
        public virtual void UserAdding()
        {
            //do something
            base.UserAdding();
        }
        public virtual void UserRemoved()
        {
            base.UserRemoved();
            //do something
        }
    }
    public class Roles : EmployeeDecorator
    {

        public override void UserAdding()
        {
            base.UserAdding();
            Console.WriteLine("You are new Admin!");
        }
        public override void UserRemoved()
        {
            Console.WriteLine("Your permission denied.");
            base.UserRemoved();
            
        }
    }
    public class Intern :EmployeeDecorator
    {
        public override void UserAdding()
        {
            base.UserAdding();
            Console.WriteLine($"{GetType().Name} Your internship is started");
        }
        public override void UserRemoved()
        {
            Console.WriteLine($"{GetType().Name} Your internship is Ended");
            base.UserRemoved();
            
        }
    }
}
