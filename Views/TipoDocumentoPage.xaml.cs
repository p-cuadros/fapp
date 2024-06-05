using FinancieraAPP.Models;

namespace FinancieraAPP.Views;

public partial class TipoDocumentoPage : ContentPage
{
	public List<TipoDocumento> tipos;
	public TipoDocumentoPage()
	{
		InitializeComponent();
		tipos = new List<TipoDocumento>() {
			new TipoDocumento() { ID=1, Descripcion="DNI" },
			new TipoDocumento() { ID=2, Descripcion="RUC" },
		};
	}
	protected override void OnAppearing()
	{
		base.OnAppearing();
		TiposListView.ItemsSource = tipos;
	}

	async void OnProductListItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
	}	

}