using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Resources.DBHandlers.WalletDBHandler;
using WinFormsApp1.Services.WalletServices;

namespace WinFormsApp1.Resources.Controllers
{
    public class WalletsManagementController
    {
        private readonly IWalletRepository walletRepo;
        private readonly IWalletService walletService;
        public WalletsManagementController(IWalletRepository walletRepository, IWalletService walletService)
        {
            this.walletRepo = walletRepository;
            this.walletService = walletService;
        }
    }
}
