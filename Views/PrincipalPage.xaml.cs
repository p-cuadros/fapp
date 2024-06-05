using FinancieraAPP.Models;
namespace FinancieraAPP.Views;

public partial class PrincipalPage : FlyoutPage
{
	public PrincipalPage()
	{
		InitializeComponent();
        flyoutPage.collectionView.SelectionChanged += OnSelectionChanged;
	}
    void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var item = e.CurrentSelection.FirstOrDefault() as FlyoutPageItem;
        if (item != null)
        {            
            Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
            if (!((IFlyoutPageController)this).ShouldShowSplitMode)
                IsPresented = false;
        }		
	}
}