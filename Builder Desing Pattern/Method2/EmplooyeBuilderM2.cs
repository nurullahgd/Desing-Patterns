using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns.Method2
{
    public abstract class EmplooyeBuilderM2 : IEmplooyeBuilderM2
    {
        protected EmplooyeM2 Employee { get; set; }

        public EmplooyeBuilderM2()
        {
            Employee = new EmplooyeM2();
        }

        public abstract void SetFullName(string fullName);
        public abstract void SetUserName(string userName);
        public abstract void SetEmail(string email);

        public EmplooyeM2 BuildEmployee() => Employee;
    }
}
