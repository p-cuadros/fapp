using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FinancieraAPP.Models;
using FinancieraAPP.Services;
using System.Net.Http;
using System.Text.Json;
using System.Net.Http.Json;
namespace FinancieraAPP.ViewModels;
public partial class TipoDocumentoViewModel : ObservableObject
{
    ITipoDocumentoService _tipoService;
    //public TipoDocumentoViewModel(ITipoDocumentoService service)
    protected readonly HttpClient Http = new HttpClient() { BaseAddress = new Uri("http://localhost:5065") };

    public TipoDocumentoViewModel()
    {
        //_tipoService = new TipoDocumentoService(new RestService(new HttpsClientHandlerService()));
        try
        {

            Tipos = Http.GetFromJsonAsync<List<TipoDocumento>>("api/TiposDocumentos", new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                }).Result;
            
        }
        catch (System.Exception e)
        {
		    App.Current.MainPage.DisplayAlert("Alerta", e.Message, "OK");
            throw;
        }
        //Tipos = _tipoService.GetTasksAsync().Result;
        // Tipos = new List<TipoDocumento>() {
        //     new TipoDocumento() { ID=1, Descripcion="DNI" },
        //     new TipoDocumento() { ID=2, Descripcion="RUC" },
        // };
        edicion=false;
    }
    [ObservableProperty]
    private List<TipoDocumento> tipos;

    [ObservableProperty]
    private bool edicion;
  
    private TipoDocumento seleccion;
    public TipoDocumento Seleccion
    {
        get { return seleccion; }
        set { seleccion = value; OnPropertyChanged(); }
    }
    
    [RelayCommand]
    async Task SelectAsync()
    {
    }      
    [RelayCommand]
    async Task AddTipoDocumento()
    {
    }      

    [RelayCommand]
    async Task SaveCommand()
    {
    }      

    [RelayCommand]
    async Task EditCommand()
    {
    }      


}
