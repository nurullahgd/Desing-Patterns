using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns.Method1
{
    public class EmplooyeBuilderM1 
    {
        public EmployeeM1 employee { get; set; }

        public EmplooyeBuilderM1()
        {
            employee = new EmployeeM1();
        }
        public EmplooyeBuilderM1 SetFullName(string fullName)
        {
            var arr=fullName.Split(' ');
            var v1 = arr[0];
            var v2 = arr[1];
            employee.FirstName = v1.Trim();
            employee.LastName = v2.Trim();
            return this;
        }

        public EmplooyeBuilderM1 SetEmailAdress(string email)
        {
            employee.EmailAdress= email;
            return this;
        }

        public EmplooyeBuilderM1 SetUserName(string username)
        {

            employee.UserName=username;
            return this;
        }

        public EmployeeM1 BuildEmplooye()
        {
            return employee;
        }

    }
}
