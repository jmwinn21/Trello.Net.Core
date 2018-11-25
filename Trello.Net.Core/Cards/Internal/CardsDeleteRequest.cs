using RestSharp;

namespace Trello.Net.Internal
{
	internal class CardsDeleteRequest : CardsRequest
	{
		public CardsDeleteRequest(ICardId card)
			: base(card, method: Method.DELETE)
		{			
		}
	}
}