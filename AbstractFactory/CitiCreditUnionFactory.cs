using System;

namespace AbstractFactory
{
    public class CitiCreditUnionFactory : CreditUnionFactory
    {
        public override SavingAccount CreateSavingAccount()
        {
            Console.WriteLine("Returned Citi Saving Account");
            return new CitiSavingAccount();
        }

        public override LoanAccount CreateLoanAccount()
        {
            Console.WriteLine("Returned Citi Loan Account");
            return new CitiLoanAccount();
        }
    }
}