using WinFormsApp1.Models;

namespace WinFormsApp1.Resources.DBHandlers.WalletDBHandler
{
    public interface IWalletRepository
    {
        int Add(string name, decimal soDuBanDau, string mieuTa);
        int Update(int id, string name, string mieuTa, DateTime createdAt);
        int Delete(int id);
        public Wallet GetWallet(int id);
        List<Wallet> GetAll();
    }
}
