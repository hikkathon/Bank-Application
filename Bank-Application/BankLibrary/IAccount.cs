namespace BankLibrary
{
    public interface IAccount
    {
        // Положить деньги на счёт
        void Put(decimal sum);
        // Взять со счёта
        decimal Withdraw(decimal sum);
    }
}
