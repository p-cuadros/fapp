//using MauiApp1;

using FinancieraAPP.Views;

namespace FinancieraAPP;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new PrincipalPage();// AppShell();
	}
}
