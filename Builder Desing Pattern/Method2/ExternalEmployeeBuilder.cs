using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns.Method2
{
    public class ExternalEmployeeBuilder : EmplooyeBuilderM2
    {
        public override void SetEmail(string email)
        {
            throw new NotImplementedException();
        }

        public override void SetFullName(string fullName)
        {
            throw new NotImplementedException();
        }

        public override void SetUserName(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
