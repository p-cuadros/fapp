namespace FinancieraAPP.Services;
public interface IHttpsClientHandlerService
{
    HttpMessageHandler GetPlatformMessageHandler();      
}