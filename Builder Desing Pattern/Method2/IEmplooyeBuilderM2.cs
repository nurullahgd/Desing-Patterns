namespace Desing_Patterns.Method2
{
    public interface IEmplooyeBuilderM2
    {
        EmplooyeM2 BuildEmployee();
        void SetEmail(string email);
        void SetFullName(string fullName);
        void SetUserName(string userName);
    }
}