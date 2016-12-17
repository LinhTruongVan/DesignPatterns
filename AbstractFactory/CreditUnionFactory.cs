namespace AbstractFactory
{
    public abstract class CreditUnionFactory : ICreditUnionFactory
    {
        public abstract SavingAccount CreateSavingAccount();

        public abstract LoanAccount CreateLoanAccount();
    }
}