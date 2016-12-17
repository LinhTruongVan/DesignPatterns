using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountNumbers = new List<string>
            {
                "CITI-111",
                "NATIONAL-222"
            };

            var factoryProvider = new CreditUnionFactoryProvider() as ICreditUnionFactoryProvider;
            foreach (var accountNumber in accountNumbers)
            {
                var factory = factoryProvider.CreateCreditUnionFactory(accountNumber);
                var savingAccount = factory.CreateSavingAccount();
                var loanAccount = factory.CreateLoanAccount();

            }

            Console.ReadLine();
        }
    }

    public interface ICreditUnionFactoryProvider
    {
        CreditUnionFactory CreateCreditUnionFactory(string accountNumber);
    }

    public class CreditUnionFactoryProvider : ICreditUnionFactoryProvider
    {
        public CreditUnionFactory CreateCreditUnionFactory(string accountNumber)
        {
            if (accountNumber.StartsWith("CITI"))
            {
                return new CitiCreditUnionFactory();
            }
            if (accountNumber.StartsWith("NATIONAL"))
            {
                return new NationalCreditUnionFactory();
            }
            throw  new ArgumentException("Invalid account number");
        }
    }
}
