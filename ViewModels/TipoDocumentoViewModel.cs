using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FinancieraAPP.Models;
using FinancieraAPP.Services;

namespace FinancieraAPP.ViewModels;
public partial class TipoDocumentoViewModel : ObservableObject
{
    ITipoDocumentoService _tipoService;
    public TipoDocumentoViewModel()
    {
        //_tipoService = service;
        //Tipos = _tipoService.GetTasksAsync().Result;
        Tipos = new List<TipoDocumento>() {
            new TipoDocumento() { ID=1, Descripcion="DNI" },
            new TipoDocumento() { ID=2, Descripcion="RUC" },
        };
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
