namespace AbstractFactory
{
    public interface ICreditUnionFactory
    {
        SavingAccount CreateSavingAccount();
        LoanAccount CreateLoanAccount();
    }
}