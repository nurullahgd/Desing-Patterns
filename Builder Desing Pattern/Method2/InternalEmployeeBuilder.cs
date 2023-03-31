using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns.Method2
{
    public class InternalEmployeeBuilder : EmplooyeBuilderM2
    {
        public override void SetEmail(string email)
        {
            var arr= email.Split('@');

            Employee.EmailAdress= arr[0]+"@company.com.tr";
        }

        public override void SetFullName(string fullName)
        {
            var arr = fullName.Split(new[] {' ','_','.'});
            var v1 = arr[0];
            var v2 = arr[1];
            Employee.FirstName = v1.Trim();
            Employee.LastName = v2.Trim();
        }

        public override void SetUserName(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
