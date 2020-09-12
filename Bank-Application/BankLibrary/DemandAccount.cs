namespace BankLibrary
{
    public class DemandAccount : Account
    {
        public DemandAccount(decimal sum, int percentage) : base(sum, percentage) { }

        protected internal override void Open()
        {
            base.OnOpened(new AccountEventArgs($"Открыт новый счёт до востребования! Id счёта: {this.Id}", this.Sum));
        }
    }
}
