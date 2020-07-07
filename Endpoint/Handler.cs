using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.Logging;
using System.Net.Http;
using System;
using System.Net;

public class Handler :
    IHandleMessages<Message>
{
    static ILog log = LogManager.GetLogger<Handler>();

    #region MessageHandler
    public Task Handle(Message message, IMessageHandlerContext context)
    {

        log.Info("Message received at endpoint, Here we need to Call Receiver Web API");

        WebClient client = new WebClient();
        client.Headers.Add("Content-Type:application/json"); //Content-Type  
        client.Headers.Add("Accept:application/json");
        client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko)");
        var result = client.DownloadString("https://localhost:44357/1"); //URI  
        
        log.Info(result);

        return Task.CompletedTask;
    }
    #endregion
}