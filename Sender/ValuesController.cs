using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NServiceBus;

[ApiController]
[Route("")]
public class ValuesController : Controller
{
    IMessageSession messageSession;

    #region MessageSessionInjection
    public ValuesController(IMessageSession messageSession)
    {
        this.messageSession = messageSession;
    }
    #endregion


    #region MessageSessionUsage
    [HttpGet]
    public async Task<string> Get()
    {
        var message = new Message();
        await messageSession.Send(message)
            .ConfigureAwait(false);
        return "SenderAPI sent Message to endpoint, Endpoint call the Receiver Web API";
    }
    #endregion
}
