using WalletWasabi.Services;
using WalletWasabi.Wallets;

namespace WalletWasabi.Fluent.ViewModels.Wallets.HardwareWallet
{
	public class ClosedHardwareWalletViewModel : ClosedWalletViewModel
	{
		internal ClosedHardwareWalletViewModel(WalletManagerViewModel walletManager, Wallet wallet, LegalChecker legalChecker) : base(walletManager, wallet, legalChecker)
		{
		}
	}
}
