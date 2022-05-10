namespace Bank.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
        IAccountTypeRepository AccountTypeRepository { get; }
        IAddressRepository AddressRepository { get; }
        IAdministratorRepository AdministratorRepository { get; }
        IBankAccountRepository BankAccountRepository { get; }
        IClientRepository ClientRepository { get; }
        ITranzactionRepository TranzactionRepository { get; }
        void Save();
    }
}
