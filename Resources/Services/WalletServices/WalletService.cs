using WinFormsApp1.Models;
using WinFormsApp1.Resources.DBHandlers.WalletDBHandler;

namespace WinFormsApp1.Services.WalletServices
{
    public class WalletService : IWalletService
    {
        private readonly IWalletRepository walletRepository;

        public WalletService(IWalletRepository walletRepository)
        {
            this.walletRepository = walletRepository;
        }

        public void AddNewWallet(Wallet newWallet)
        {
            if (newWallet == null)
            {
                throw new Exception("Wallet is NULL. Cannot Add");
            }

            if(walletRepository == null)
            {
                throw new Exception("WalletRepository is NULL.");
            }

            int rowAffected = walletRepository.Add(newWallet.Name, newWallet.CurrentBallance, newWallet.Description);
        
            if(rowAffected == 0)
            {
                throw new Exception("Cannot ADD New Wallet");
            }
        }

        public void Delete(Wallet walletToDelete)
        {
            if (walletToDelete == null)
            {
                throw new Exception("DELETE: Wallet la NULL!!!");
            }
            if (walletRepository == null)
            {
                throw new Exception("WalletRepository is NULL.");
            }
            
            int rowAffected = walletRepository.Delete(walletToDelete.Id);

            if (rowAffected == 0)
            {
                throw new Exception("Cannot DELETE Wallet With Id: " + walletToDelete.Id);
            }
        }

        public List<Wallet> GetAll()
        {
            if (walletRepository == null)
            {
                throw new Exception("WalletRepository is NULL.");
            }

            return walletRepository.GetAll();
        }

        public Wallet GetWallet(int id)
        {
            if (walletRepository == null)
            {
                throw new Exception("WalletRepository is NULL.");
            }

            Wallet wallet = walletRepository.GetWallet(id);

            if (wallet == null)
            {
                throw new Exception("Cannot Get Wallet With Id:" + id);
            }

            return wallet;
        }

        public void Update(Wallet walletToUpdate, string newName, string newMieuTa, DateTime newCreatedAt)
        {
            if (walletRepository == null)
            {
                throw new Exception("WalletRepository is NULL.");
            }

            int rowAffected = walletRepository.Update(walletToUpdate.Id, newName, newMieuTa, newCreatedAt);

            if (rowAffected == 0)
            {
                throw new Exception("Cannot UPDATE Wallet With Id: " + walletToUpdate.Id);
            }
        }   
    }
}
