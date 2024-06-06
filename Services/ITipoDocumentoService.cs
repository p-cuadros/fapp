using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinancieraAPP.Models;

namespace FinancieraAPP.Services;
public interface ITipoDocumentoService
{
    Task<List<TipoDocumento>> GetTasksAsync();
    Task SaveTaskAsync(TipoDocumento item, bool isNewItem);
    Task DeleteTaskAsync(TipoDocumento item);        
}
