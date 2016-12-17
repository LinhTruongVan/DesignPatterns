namespace FactoryMethod
{
    public interface ISavingAccountFactory
    {
        SavingAccount GetSavingAccount(string accountNumber);
    }
}