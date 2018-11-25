using RestSharp;

namespace Trello.Net.Internal
{
    internal class WebhookDeleteRequest : WebhookRequest
    {
        public WebhookDeleteRequest(IWebhookId webhook) : 
            base(webhook, method: Method.DELETE)            
        {            
        }
    }
}