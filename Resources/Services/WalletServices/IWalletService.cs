using WinFormsApp1.Models;

namespace WinFormsApp1.Services.WalletServices
{
    public interface IWalletService
    {
        void AddNewWallet(Wallet newWallet);
        void Update(Wallet walletToUpdate, string newName, string newMieuTa, DateTime newCreatedAt);
        void Delete(Wallet walletToDelete);
        Wallet GetWallet(int id);
        List<Wallet> GetAll();
    }
}
