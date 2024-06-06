using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinancieraAPP.Models;

namespace FinancieraAPP.Services
{
    public class TipoDocumentoService : ITipoDocumentoService
    {
        IRestService _restService;

        public TipoDocumentoService(IRestService service)
        {
            _restService = service;
        }

        public Task<List<TipoDocumento>> GetTasksAsync()
        {
            return _restService.RefreshDataAsync();
        }

        public Task SaveTaskAsync(TipoDocumento item, bool isNewItem = false)
        {
            return _restService.SaveTodoItemAsync(item, isNewItem);
        }

        public Task DeleteTaskAsync(TipoDocumento item)
        {
            return _restService.DeleteTodoItemAsync(item.ID.ToString());
        }
    }
}