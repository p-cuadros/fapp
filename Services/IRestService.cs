using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinancieraAPP.Models;

namespace FinancieraAPP.Services
{
    public interface IRestService
    {
        Task<List<TipoDocumento>> RefreshDataAsync();
        Task SaveTodoItemAsync(TipoDocumento item, bool isNewItem);
        Task DeleteTodoItemAsync(string id);
    }
}