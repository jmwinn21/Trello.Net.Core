using RestSharp;

namespace Trello.Net.Internal
{
	internal class CardsArchiveRequest : CardsRequest
	{
		public CardsArchiveRequest(ICardId card)
			: base(card, "closed", Method.PUT)
		{
			this.AddValue("true");			
		}
	}
}