using System;

namespace AbstractFactory
{
    public class NationalCreditUnionFactory : CreditUnionFactory
    {
        public override SavingAccount CreateSavingAccount()
        {
            Console.WriteLine("Returned National Saving Account");
            return new NationalSavingAccount();
        }

        public override LoanAccount CreateLoanAccount()
        {
            Console.WriteLine("Returned National Loan Account");
            return new NationalLoanAccount();
        }
    }
}