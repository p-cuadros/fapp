using FinancieraAPP.Models;
using FinancieraAPP.ViewModels;

namespace FinancieraAPP.Views;

public partial class TipoDocumentoPage : ContentPage
{
	public List<TipoDocumento> tipos;
	public TipoDocumentoPage()
	{
		BindingContext = new TipoDocumentoViewModel();
		InitializeComponent();
	}
}