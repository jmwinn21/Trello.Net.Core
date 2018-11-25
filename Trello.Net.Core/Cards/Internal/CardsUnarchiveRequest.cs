using RestSharp;

namespace Trello.Net.Internal
{
	internal class CardsUnarchiveRequest : CardsRequest
	{
		public CardsUnarchiveRequest(ICardId card)
			: base(card, "closed", Method.PUT)
		{
			this.AddValue("false");			
		}
	}
}