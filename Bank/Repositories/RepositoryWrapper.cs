using Bank.Context;
using Bank.Repositories.Interfaces;

namespace Bank.Repositories
{
    public class RepositoryWrapper:IRepositoryWrapper
    {
        private MVCContext _dbContext;
        private IAccountTypeRepository? _accountTypeRepository;
        private IAddressRepository? _addressRepository;
        private IAdministratorRepository? _administratorRepository;
        private ITranzactionRepository? _tranzactionRepository;
        private IBankAccountRepository? _bankAccountRepository;
        private IClientRepository? _clientRepository;
        public IClientRepository ClientRepository
        {
            get
            {
                if( _clientRepository == null )
                {
                    _clientRepository = new ClientRepository(_dbContext);
                }
                return _clientRepository;
            }
        }
        public ITranzactionRepository TranzactionRepository
        {
            get
            {
                if(_tranzactionRepository==null)
                {
                    _tranzactionRepository=new TranzactionRepository(_dbContext);
                }
                return _tranzactionRepository;
            }
        }
        public IAccountTypeRepository AccountTypeRepository
        {
            get
            {
                if(_accountTypeRepository == null )
                {
                    _accountTypeRepository = new AccountTypeRepository(_dbContext);
                }
                return _accountTypeRepository; 
            }

        }
        public IAdministratorRepository AdministratorRepository
        {
            get
            {
                if(_administratorRepository==null)
                {
                    _administratorRepository = new AdministratorRepository(_dbContext);
                }
                return _administratorRepository;
            }
        }
        public IAddressRepository AddressRepository
        {
            get
            {
                if( _addressRepository==null)
                {
                    _addressRepository=new AddressRepository(_dbContext);
                }
                return _addressRepository;  
            }
        }
        public IBankAccountRepository BankAccountRepository
        {
            get
            {
                if(_bankAccountRepository==null)
                {
                    _bankAccountRepository=new BankAccountRepository(_dbContext);
                }
                return _bankAccountRepository;
            }
        }

        public RepositoryWrapper(MVCContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
